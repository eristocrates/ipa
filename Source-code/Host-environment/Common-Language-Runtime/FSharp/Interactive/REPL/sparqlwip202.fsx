
type IGraph with 
    member inline this.S<'Subject when 'Subject : (member asINode: INode)> (S:'Subject ) = this.GetTriplesWithSubject(S.asINode) |> Seq.toArray
    member inline this.SP<'Subject,'Predicate when 'Subject : (member asINode: INode) and 'Predicate : (member asINode: INode) > (S:'Subject, P:'Predicate ) = this.GetTriplesWithSubjectPredicate(S.asINode, P.asINode) |> Seq.toArray
    member this.BlankNodes =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.Blank)
      |> Array.map (fun node -> node :?> BlankNode)
      |> Array.sortBy (fun node -> node.InternalID)
    member this.UriNodes =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.Uri)
      |> Array.map (fun node -> node :?> UriNode)
      |> Array.sortBy (fun node -> node.Uri.OriginalString)
    member this.LiteralNodes =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.Literal)
      |> Array.map (fun node -> node :?> LiteralNode)
      |> Array.filter (fun node -> node.Language = String.Empty)
      |> Array.sortBy (fun node -> node.DataType.OriginalString, node.Value)
    member this.LanguageLiteralNodes =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.Literal)
      |> Array.map (fun node -> node :?> LiteralNode)
      |> Array.filter (fun node -> node.Language <> String.Empty)
      |> Array.sortBy (fun node -> node.Language, node.Value)
    member this.GraphLiteralNodes  =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.GraphLiteral)
      |> Array.map (fun node -> node :?> GraphLiteralNode)
      
    member this.VariableNodes =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.Variable)
      |> Array.map (fun node -> node :?> VariableNode)
    member this.TripleNodes =
      this.AllNodes
      |> Seq.toArray
      |> Array.filter (fun node -> node.NodeType = NodeType.Triple)
      |> Array.map (fun node -> node :?> TripleNode)
      |> Array.sortBy (fun node -> node.Triple.Subject.ToString(), node.Triple.Predicate.ToString(), node.Triple.Object.ToString())

type IriReference with 
    static member fromUriNode (uriNode:UriNode) = IriReference uriNode.Uri
    member this.lexicalForm = this.uri.OriginalString
    member this.identity = this.lexicalForm

    member this.asUrl = DomUrl this.uri.OriginalString 
    member this.asUri = this.uri
    member this.asUriNode = new UriNode (this.asUri)
    member this.asINode:INode = this.asUriNode
    member this.asRDFResource = new RDFResource(this.lexicalForm)
    member this.maybeCurie = 
      match namespaceMapper.ReduceToQName this.lexicalForm with 
      | true, qname -> Some qname 
      | false, _ -> None
    member this.iriref = $"<{this.uri.OriginalString}>"

        


type INamespaceMapper with 

    member this.GetNamespaceName (prefix:string) = this.GetNamespaceUri prefix |> _.OriginalString
    member this.GetNamespaceUrl (prefix:string) = this.GetNamespaceName prefix |> DomUrl
    member this.GetNamespaceIriReference (prefix:string) = this.GetNamespaceName  prefix |> IriReference









type NLanguageTag.LanguageTag with 
    member this.asString = this.ToString()
type InitialTextDirection =
    | Ltr
    | Rtl
    member this.asString = this.ToString().ToLowerInvariant()











































































type Arc =
    {
        uuid : Guid
        tailPoint : Point
        legisignPoint : Point
        headPoint : Point
    }
and [< CustomComparison ; CustomEquality>] Iri = 
    | IRIREF of IriReference
    | PrefixedIri of PrefixedName
    | SkolemIri of SkolemizedName
    static member fromUri(uri:Uri) = 
                match namespaceMapper.ReduceToQName uri.OriginalString with 
                | false, _ -> IriReference uri |> IRIREF 
                | true, qname -> PrefixedName.fromQname qname |> PrefixedIri 
    static member fromUriNode(uriNode:UriNode) = 
                match namespaceMapper.ReduceToQName uriNode.Uri.OriginalString with 
                | false, _ -> IriReference uriNode.Uri |> IRIREF 
                | true, qname -> PrefixedName.fromQname qname |> PrefixedIri 
    member this.asSubject = IriSubject this
    member this.asPredicate = IriPredicate this
    member this.asObject = IriObject this
    member this.asRdfName = IriName this
    member this.asRdfReference = NamedReference this.asIriReference

    member this.asIriReference = 
      match this with 
      | IRIREF iriReference -> iriReference
      | PrefixedIri prefixedName -> prefixedName.asIriReference
      | SkolemIri skolemizedName -> skolemizedName.asIriReference
    member this.lexicalForm = 
      match this with 
      | IRIREF iriReference -> iriReference.lexicalForm
      | PrefixedIri prefixedName -> prefixedName.lexicalForm
      | SkolemIri skolemizedName -> skolemizedName.lexicalForm
    member this.iriref = $"<{this.lexicalForm}>"
    member this.asUrl = 
      match this with 
      | IRIREF iriReference -> iriReference.asUrl
      | PrefixedIri prefixedName -> prefixedName.asUrl
      | SkolemIri skolemizedName -> skolemizedName.asUrl
    member this.asUri = 
      match this with 
      | IRIREF iriReference -> iriReference.asUri
      | PrefixedIri prefixedName -> prefixedName.asUri
      | SkolemIri skolemizedName -> skolemizedName.asUri
    member this.asUriNode = 
      match this with 
      | IRIREF iriReference -> iriReference.asUriNode
      | PrefixedIri prefixedName -> prefixedName.asUriNode
      | SkolemIri skolemizedName -> skolemizedName.asUriNode
    member this.asINode = 
      match this with 
      | IRIREF iriReference -> iriReference.asINode
      | PrefixedIri prefixedName -> prefixedName.asINode
      | SkolemIri skolemizedName -> skolemizedName.asINode

    member this.asRDFResource = 
      match this with 
      | IRIREF iriReference -> iriReference.asRDFResource
      | PrefixedIri prefixedName -> prefixedName.asRDFResource
      | SkolemIri skolemizedName -> skolemizedName.asRDFResource
    member this.maybeCurie = 
      match this with 
      | IRIREF iriReference -> iriReference.maybeCurie
      | PrefixedIri prefixedName -> Some prefixedName.curie
      | SkolemIri skolemizedName -> skolemizedName.maybeCurie

      
    member this.identity = this.lexicalForm
    
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? IriReference as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | :? SkolemizedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.lexicalForm.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? IriReference as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | :? SkolemizedName as other -> compare this.identity other.identity
            | _ -> 
                invalidArg (nameof other) (
                    sprintf "%s can only be compared with %s, %s, %s, or %s"
                        typeof<Iri>.Name
                        typeof<Iri>.Name
                        typeof<IriReference>.Name
                        typeof<PrefixedName>.Name
                        typeof<SkolemizedName>.Name
                )
                        
and [< CustomComparison ; CustomEquality>] PrefixedName = 
    {
      prefixId:PrefixId
      localName:string
    }
    static member fromQname (qname:string)  =
        {
          prefixId = PrefixId.fromPrefixLabel qname[..qname.IndexOf ":" - 1]
          localName = qname[qname.IndexOf ":" + 1..]
        }
    member this.asSubject = PrefixedIri this |> IriSubject
    member this.asPredicate = PrefixedIri this |> IriPredicate
    member this.asObject = PrefixedIri this |> IriObject
    member this.asRdfName = PrefixedIri this |> IriName
    member this.asRdfReference = NamedReference this.asIriReference
    member this.asXName = XName.op_Implicit(this.lexicalForm)
    member this.asXmlQualifiedName = new XmlQualifiedName(this.localName, this.prefixId.namespaceName)
    
        
    member this.lexicalForm = this.prefixId.namespaceName + this.localName
    member this.curieDelimited infixDelimiter = this.prefixId.prefixLabel + infixDelimiter + this.localName
    member this.curie = this.curieDelimited ":"
    member this.asUrl = DomUrl this.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode :INode = this.asUriNode
    member this.asIriReference = IriReference this.lexicalForm
    member this.asRDFResource = new RDFResource(this.lexicalForm)
    member this.identity = this.lexicalForm
    
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? IriReference as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | :? SkolemizedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.lexicalForm.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? IriReference as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | :? SkolemizedName as other -> compare this.identity other.identity
            | _ -> 
                invalidArg (nameof other) (
                    sprintf "%s can only be compared with %s, %s, %s, or %s"
                        typeof<Iri>.Name
                        typeof<Iri>.Name
                        typeof<IriReference>.Name
                        typeof<PrefixedName>.Name
                        typeof<SkolemizedName>.Name
                )
                        
and PrefixId = 
  {
    prefixLabel :string
    namespaceName :string
  }
  static member fromNamespaceLabel (namespaceName:string) (prefixLabel:string)  = 
    let prefixId = {prefixLabel = prefixLabel ; namespaceName = namespaceName}
    namespaceMapper.AddNamespace(prefixId.asNamespaceMap)
    prefixId

  static member rdf = PrefixId.fromNamespaceLabel "http://www.w3.org/1999/02/22-rdf-syntax-ns#"  "rdf"
  static member rdfs = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/01/rdf-schema#"  "rdfs"
  static member owl = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/07/owl#"  "owl"
  static member xsd = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema#"  "xsd"
  static member xsi = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema-instance#"  "xsi"
  static member xdt = PrefixId.fromNamespaceLabel "https://www.w3.org/2003/05/xpath-datatypes#"  "xdt"
  static member owlTime = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time#"  "owlTime"
  

  member this.asPrefixedName = 
    {
        prefixId = this
        localName = String.Empty
    }

  member this.prefix (localName:string) = { prefixId = this ; localName = localName} |> PrefixedIri
  member this.asSubject = PrefixedIri this.asPrefixedName |> IriSubject
  member this.asPredicate = PrefixedIri this.asPrefixedName |> IriPredicate
  member this.asObject = PrefixedIri this.asPrefixedName |> IriObject
  member this.asRdfName = PrefixedIri this.asPrefixedName |> IriName
  member this.asRdfReference = NamedReference this.asIriReference
  member this.asIriReference = this.asPrefixedName.asIriReference

  static member fromPrefixLabel (prefixLabel:string) = 
      {
        prefixLabel = prefixLabel 
        namespaceName = namespaceMapper.GetNamespaceUri prefixLabel |> _.OriginalString
      }
  member this.XNamespace = XNamespace.op_Implicit this.namespaceName
  member this.XName (localName:string) = XNamespace.Xmlns + localName
  member this.asRDFNamespace = new RDFNamespace(this.prefixLabel, this.namespaceName)
  member this.asNamespaceMap = this.prefixLabel, Uri this.namespaceName
  member this.namespaceIriReference = IriReference this.namespaceName
  member this.namespaceUrl = DomUrl this.namespaceName
  member this.namespaceUri = Uri this.namespaceName
  member this.directory = this.namespaceUrl.asFolder
  member this.asFileExtension (dotExtension:string) = 

        let mimeType = MimeType.FromFileName(dotExtension)
        Path.Combine (this.namespaceUrl.asFolder.FullName, mimeType.MediaType, $"{mimeType.SubType}{dotExtension}") |> FileInfo
and [<CustomComparison ; CustomEquality>] SkolemizedName = 
    {
      uuid:Guid
      blankNode:BlankReference
    }
    member this.maybeCurie = 
      match namespaceMapper.ReduceToQName this.lexicalForm with 
      | true, qname -> Some qname 
      | false, _ -> None
      
    member this.asSubject = SkolemIri this |> IriSubject
    member this.asPredicate = SkolemIri this |> IriPredicate
    member this.asObject = SkolemIri this |> IriObject
    member this.asRdfName = SkolemIri this |> IriName
    member this.asRdfReference = NamedReference this.asIriReference
    member this.lexicalForm = $"{wellKnownGenid}/{this.uuid.asString}"
    member this.asUrl = DomUrl this.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode :INode = this.asUriNode
    member this.asIriReference = IriReference this.lexicalForm
    member this.asRDFResource = new RDFResource(this.lexicalForm)

    member this.identity = this.lexicalForm
    
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? IriReference as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | :? SkolemizedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? IriReference as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | :? SkolemizedName as other -> compare this.identity other.identity
            | _ -> 
                invalidArg (nameof other) (
                    sprintf "%s can only be compared with %s, %s, %s, or %s"
                        typeof<Iri>.Name
                        typeof<Iri>.Name
                        typeof<IriReference>.Name
                        typeof<PrefixedName>.Name
                        typeof<SkolemizedName>.Name
                )
and BlankReference = 
    {
      blankNodeIdentifier: string
    }
    static member fromBlankNode(blankNode:VDS.RDF.BlankNode) = {blankNodeIdentifier = blankNode.InternalID}
    
    member this.asSubject = BlankSubject this 
    member this.asObject = BlankObject this 
    member this.asRdfReference = AnonymousReference this
    member this.lexicalForm = this.blankNodeIdentifier
    member this.curie = "_:" + this.blankNodeIdentifier
    member this.asBlankNode = new VDS.RDF.BlankNode(this.blankNodeIdentifier)
    member this.asRDFResource = new RDFResource(this.curie)
    member this.asINode:INode = this.asBlankNode

and [<CustomEquality ; CustomComparison>] RdfLiteral = 
    | PlainLiteral of PlainLiteral
    | DatatypedLiteral of DatatypedLiteral
    static member fromLiteralNode (literalNode:LiteralNode) = 
            match literalNode.Value, literalNode.DataType, literalNode.Language.ToLowerInvariant() with
            | lexicalForm, null, lang when not (String.IsNullOrWhiteSpace lang) -> NLanguageTag.LanguageTag.Parse lang |> RdfLiteral.languageTagged  lexicalForm
            | lexicalForm, datatypeUri, lang when not (isNull datatypeUri) && String.IsNullOrWhiteSpace lang -> 
                {
                    lexicalForm = lexicalForm
                    datatypeIri = Iri.fromUri datatypeUri 
                } |> DatatypedLiteral
            | lexicalForm ,_ ,_ -> RdfLiteral.simple lexicalForm
    static member fromILiteralNode (iliteralNode:ILiteralNode) = iliteralNode :?> LiteralNode |> RdfLiteral.fromLiteralNode
    
    static member simple(lexicalForm:string) = SimpleString lexicalForm |> PlainLiteral
    static member datatyped(lexicalForm:string) (datatypeIri:Iri) =
        {
            lexicalForm = lexicalForm 
            datatypeIri = datatypeIri 
        } |> DatatypedLiteral 
    static member languageTagged (lexicalForm:string) (languageTag:NLanguageTag.LanguageTag) = 
        {
            lexicalForm = lexicalForm 
            languageTag = languageTag
        } |> LanguageString |> PlainLiteral 
    static member language(lexicalForm:string) (language:Language) = 
        {
            lexicalForm = lexicalForm 
            languageTag = new NLanguageTag.LanguageTag(language)
        } |> LanguageString |> PlainLiteral 
    static member en (lexicalForm:string) = RdfLiteral.language lexicalForm Language.EN
    static member US (lexicalForm:string) = new NLanguageTag.LanguageTag(Language.EN, Region.US) |> RdfLiteral.languageTagged lexicalForm 


    static member inline autotyped<'ValueType>(value: 'ValueType) =

        let datatypedLiteral =
            let invariantString =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> { lexicalForm = (if value then "true" else "false") ; datatypeIri = PrefixId.xsd.prefix "boolean" }
            | :? (Byte array) as value -> { lexicalForm = Convert.ToBase64String(value) ; datatypeIri = PrefixId.xsd.prefix "base64Binary" }
            | :? Byte as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedByte" }
            | :? DateOnly as value -> { lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "date" }
            | :? DateTime as value -> { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "dateTime" }
            | :? DateTimeOffset as value -> { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "dateTimeStamp" }
            | :? Decimal as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "decimal" }
            | :? Double as value -> { lexicalForm = value.ToString("R", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "double" }
            | :? Int16 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "short" }
            | :? Int32 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "int" }
            | :? Int64 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "long" }
            | :? SByte as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "byte" }
            | :? Single as value -> { lexicalForm = value.ToString("R", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "float" }
            | :? TimeOnly as value -> { lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "time" }
            | :? TimeSpan as value -> { lexicalForm = Xml.XmlConvert.ToString(value) ; datatypeIri = PrefixId.xsd.prefix "duration" }
            | :? UInt16 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedShort" }
            | :? UInt32 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedInt" }
            | :? UInt64 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedLong" }
            | :? Uri as value -> { lexicalForm = value.OriginalString ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? DomUrl as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? IriReference as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? XmlQualifiedName as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "QName" }
            | :? Guid as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "ID" }
            | :? String as value -> { lexicalForm = value ; datatypeIri = PrefixId.xsd.prefix "string" }
            | null  -> { lexicalForm = "true" ; datatypeIri = PrefixId.xsi.prefix "nil" }
            | value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xdt.prefix "anyAtomicType" }

        datatypedLiteral |> DatatypedLiteral

    static member True = RdfLiteral.autotyped true 
    static member False = RdfLiteral.autotyped false
    member this.asObject = LiteralObject this
    member this.asRdfName = LiteralName this
    member this.lexicalForm = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.lexicalForm
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.lexicalForm
    member this.maybeCurie = 
      match this with 
      | PlainLiteral plainLiteral -> None
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.curie
    member this.asLiteralNode = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.asLiteralNode
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.asLiteralNode
      
    member this.asINode :INode = this.asLiteralNode
    member this.datatypeIri = 
      match this with 
      | PlainLiteral plainLiteral -> PrefixId.xsd.prefix "string"
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.datatypeIri
      
    member this.maybeLanguageTag = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.maybeLanguageTag
      | DatatypedLiteral datatypedLiteral -> None
    member this.maybeBaseDirection = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.maybeBaseDirection
      | DatatypedLiteral datatypedLiteral -> None

    member this.identity = 
        match this with 
        | PlainLiteral plainLiteral -> plainLiteral.identity
        | DatatypedLiteral datatypedLiteral -> datatypedLiteral.identity
        
    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality ; CustomComparison>] PlainLiteral = 
    | SimpleString of string
    | LanguageString of LanguageString
    | DirectedLanguageString of DirectedLanguageString
    member this.asObject = PlainLiteral this |> LiteralObject
    member this.asRdfName = PlainLiteral this |> LiteralName 
    member this.lexicalForm = 
      match this with 
      | SimpleString rdfString -> rdfString
      | LanguageString languageString -> languageString.lexicalForm
      | DirectedLanguageString directedLanguageString -> directedLanguageString.lexicalForm
    member this.curie = 
      match this with 
      | SimpleString rdfString -> rdfString
      | LanguageString languageString -> languageString.curie
      | DirectedLanguageString directedLanguageString -> directedLanguageString.curie
    member this.asLiteralNode = 
      match this with 
      | SimpleString rdfString -> new LiteralNode (rdfString)
      | LanguageString languageString -> new LiteralNode (languageString.lexicalForm, languageString.languageTag.asString)
      | DirectedLanguageString directedLanguageString -> new LiteralNode (directedLanguageString.lexicalForm, directedLanguageString.i18nIri.asUri)
    member this.asINode :INode = this.asLiteralNode
    member this.maybeLanguageTag = 
      match this with 
      | SimpleString rdfString -> None
      | LanguageString languageString -> Some languageString.languageTag
      | DirectedLanguageString directedLanguageString -> Some directedLanguageString.languageTag
    member this.maybeBaseDirection = 
      match this with 
      | SimpleString rdfString -> None
      | LanguageString languageString -> None
      | DirectedLanguageString directedLanguageString -> Some directedLanguageString.baseDirection
    member this.identity = 
      match this with 
      | SimpleString rdfString -> (rdfString, (PrefixId.xsd.prefix "string").identity, None, None)
      | LanguageString languageString -> languageString.identity
      | DirectedLanguageString directedLanguageString -> directedLanguageString.identity
      
    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality ; CustomComparison>] LanguageString = 
    {
    lexicalForm:string
    languageTag:NLanguageTag.LanguageTag
    }
    member this.asObject = LanguageString this |> PlainLiteral |> LiteralObject
    member this.asRdfName = LanguageString this |> PlainLiteral |> LiteralName
    member this.curie = sprintf "%s@%s" this.lexicalForm this.languageTag.asString
    member this.identity = (this.lexicalForm, (PrefixId.rdf.prefix "langString").identity, Some(this.languageTag.asString), None)

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()  
    interface IComparable with
      member this.CompareTo(other: obj) =
          match other with
          | :? RdfLiteral as other -> compare this.identity other.identity
          | :? PlainLiteral as other -> compare this.identity other.identity
          | :? DatatypedLiteral as other -> compare this.identity other.identity
          | :? LanguageString as other -> compare this.identity other.identity
          | :? DirectedLanguageString as other -> compare this.identity other.identity
          | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality ; CustomComparison>] DirectedLanguageString = 
    {
    lexicalForm:string
    languageTag:NLanguageTag.LanguageTag
    baseDirection:InitialTextDirection
    }
    member this.asObject = DirectedLanguageString this |> PlainLiteral |> LiteralObject
    member this.asRdfName = DirectedLanguageString this |> PlainLiteral |> LiteralName
    member this.curie = sprintf "%s@%s--%s" this.lexicalForm this.languageTag.asString this.baseDirection.asString
    member this.i18nIri:Iri = IriReference $"https://www.w3.org/ns/i18n#{this.languageTag.asString}_{this.baseDirection.asString}" |> IRIREF
    // TODO from i18nIri
    member this.identity = (this.lexicalForm, (PrefixId.rdf.prefix "dirLangString").identity, Some(this.languageTag.asString), Some(this.baseDirection.asString))

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()  
    interface IComparable with
      member this.CompareTo(other: obj) =
          match other with
          | :? RdfLiteral as other -> compare this.identity other.identity
          | :? PlainLiteral as other -> compare this.identity other.identity
          | :? DatatypedLiteral as other -> compare this.identity other.identity
          | :? LanguageString as other -> compare this.identity other.identity
          | :? DirectedLanguageString as other -> compare this.identity other.identity
          | _ -> compare this.identity (RdfLiteral.autotyped other).identity

and [<CustomEquality ; CustomComparison>] DatatypedLiteral = 
    {
    lexicalForm:string
    datatypeIri:Iri
    }
    member this.asObject = DatatypedLiteral this  |> LiteralObject
    member this.asRdfName = DatatypedLiteral this |> LiteralName
    member this.asLiteralNode = new LiteralNode (this.lexicalForm, this.datatypeIri.asUri)
    member this.asINode :INode = this.asLiteralNode
    member this.curie = 
        match this.datatypeIri.maybeCurie with 
        | Some curie -> Some(sprintf "%s^^%s" this.lexicalForm curie)
        | None -> None
    member this.identity = (this.lexicalForm, this.datatypeIri.identity, None, None)

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()  
    interface IComparable with
      member this.CompareTo(other: obj) =
          match other with
          | :? RdfLiteral as other -> compare this.identity other.identity
          | :? PlainLiteral as other -> compare this.identity other.identity
          | :? DatatypedLiteral as other -> compare this.identity other.identity
          | :? LanguageString as other -> compare this.identity other.identity
          | :? DirectedLanguageString as other -> compare this.identity other.identity
          | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality ; CustomComparison>] RdfVariable = 
    {
        uuid :Guid
        identifier:string
        mutable bindingCell : Adaptive.cval<Point option>
    }
    static member fromVariableNode (variableNode:VariableNode) = 
            {
                uuid = new Guid()
                identifier = variableNode.VariableName
                bindingCell = Adaptive.cval (None:Point option)
            }
    static member fromIdentifier (identifier:string) = 
            {
                uuid = new Guid()
                identifier = identifier
                bindingCell = Adaptive.cval (None:Point option)
            }
    member this.asSubject = VariableSubject this
    member this.asPredicate = VariablePredicate this
    member this.asObject = VariableObject this

    member this.lexicalForm = this.identifier
    member this.questionForm = "?" + this.lexicalForm
    member this.dollarForm = "$" + this.lexicalForm
    member this.asVariableNode = new VariableNode(this.identifier)
    member this.asINode :INode = this.asVariableNode
    member this.asSparqlVariable = new SparqlVariable(this.identifier)
    member this.asBlankReference = { blankNodeIdentifier = this.identifier}
    member this.asSkolemIri = { uuid = this.uuid ; blankNode = this.asBlankReference}
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) = patternBuilder.PatternItemFactory.CreateVariablePattern(this.identifier)
    member this.binding : Adaptive.aval<Point option> = this.bindingCell :> Adaptive.aval<Point option>
    member this.bind (point:Point) = transact (fun () -> this.bindingCell.Value <- Some point)
    member this.unbind() = transact (fun () -> this.bindingCell.Value <- None)
    member this.maybeTerm = this.binding |> Adaptive.AVal.force
    member this.identity = this.uuid

    override this.Equals(other: obj) =
        match other with
        | :? RdfVariable as otherVariable -> this.identity = otherVariable.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfVariable as otherVariable -> compare this.identity otherVariable.identity 
            | _ -> invalidArg (nameof other) "An RdfVariable can only be compared with another RdfVariable."

and RdfSubject = 
    | IriSubject of Iri
    | BlankSubject of BlankReference
    | VariableSubject of RdfVariable
    static member fromINode (inode:INode) = 
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriSubject
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankSubject
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariableSubject
    member this.maybePredicate = 
        match this with 
        | IriSubject  iri -> Some iri.asPredicate
        | BlankSubject  blankReference -> None
        | VariableSubject  rdfVariable -> Some rdfVariable.asPredicate
    member this.asObject = 
        match this with 
        | IriSubject  iri -> iri.asObject
        | BlankSubject  blankReference -> blankReference.asObject
        | VariableSubject  rdfVariable -> rdfVariable.asObject
    member this.maybeRdfName = 
        match this with 
        | IriSubject  iri -> Some iri.asRdfName
        | BlankSubject  blankReference -> None
        | VariableSubject  rdfVariable -> None
    member this.maybeRdfReference = 
        match this with 
        | IriSubject  iri -> Some iri.asRdfReference
        | BlankSubject  blankReference -> Some blankReference.asRdfReference
        | VariableSubject  rdfVariable -> None
    member this.asVertex = SubjectVertex this
    member this.asRdfTerm = 
        match this with 
        | IriSubject  iri -> IriPoint iri
        | BlankSubject  blankReference -> BlankPoint blankReference
        | VariableSubject  rdfVariable -> VariablePoint rdfVariable
    member this.lexicalForm = 
        match this with 
        | IriSubject  iri -> iri.lexicalForm
        | BlankSubject  blankReference -> blankReference.lexicalForm
        | VariableSubject  rdfVariable -> rdfVariable.lexicalForm
    member this.maybeCurie = 
        match this with 
        | IriSubject  iri -> iri.maybeCurie
        | BlankSubject  blankReference -> Some blankReference.curie
        | VariableSubject  rdfVariable -> None
    member this.asINode = 
        match this with 
        | IriSubject  iri -> iri.asINode
        | BlankSubject  blankReference -> blankReference.asINode
        | VariableSubject  rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableSubject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)

and RdfPredicate = 
    | IriPredicate of Iri
    | VariablePredicate of RdfVariable
    static member fromINode (inode:INode) = 
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriPredicate
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariablePredicate
    member this.asSubject = 
        match this with 
        | IriPredicate  iri -> iri.asSubject
        | VariablePredicate  rdfVariable -> rdfVariable.asSubject
    member this.asObject = 
        match this with 
        | IriPredicate  iri -> iri.asObject
        | VariablePredicate  rdfVariable -> rdfVariable.asObject
    member this.maybeRdfName = 
        match this with 
        | IriPredicate  iri -> Some iri.asRdfName
        | VariablePredicate  rdfVariable -> None
    member this.maybeRdfReference = 
        match this with 
        | IriPredicate  iri -> Some(NamedReference iri.asIriReference)
        | VariablePredicate  rdfVariable -> None
    member this.asEdge = PredicateEdge this
    member this.asRdfTerm = 
        match this with 
        | IriPredicate  iri -> IriPoint iri
        | VariablePredicate  rdfVariable -> VariablePoint rdfVariable
    member this.lexicalForm = 
        match this with 
        | IriPredicate  iri -> iri.lexicalForm
        | VariablePredicate  rdfVariable -> rdfVariable.lexicalForm
    member this.maybeCurie = 
        match this with 
        | IriPredicate  iri -> iri.maybeCurie
        | VariablePredicate  rdfVariable -> None
    member this.asINode = 
        match this with 
        | IriPredicate  iri -> iri.asINode
        | VariablePredicate  rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariablePredicate rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)

and RdfObject = 
    | IriObject of Iri
    | BlankObject of BlankReference
    | LiteralObject of RdfLiteral
    | TripleTermObject of RdfTripleTerm
    | VariableObject of RdfVariable
    static member fromINode (inode:INode) = 
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriObject
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankObject
        | NodeType.Literal ->
            inode :?> LiteralNode
            |> RdfLiteral.fromLiteralNode
            |> LiteralObject
        | NodeType.Triple ->
            inode :?> TripleNode
            |> RdfTripleTerm.fromTripleNode
            |> TripleTermObject
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariableObject
    member this.maybeSubject = 
        match this with 
        | IriObject  iri -> Some (IriSubject iri)
        | BlankObject  blankReference -> Some (BlankSubject blankReference)
        | LiteralObject  rdfLiteral -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject  rdfVariable -> Some (VariableSubject rdfVariable )
    member this.maybePredicate = 
        match this with 
        | IriObject  iri -> Some (IriPredicate iri)
        | BlankObject  blankReference -> None
        | LiteralObject  rdfLiteral -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject  rdfVariable -> Some (VariablePredicate rdfVariable )
    member this.asRdfTerm = 
        match this with 
        | IriObject  iri -> IriPoint iri
        | BlankObject  blankReference -> BlankPoint blankReference
        | LiteralObject  rdfLiteral -> LiteralPoint rdfLiteral
        | TripleTermObject tripleTerm -> TriplePoint tripleTerm
        | VariableObject  rdfVariable -> VariablePoint rdfVariable
    member this.lexicalForm = 
        match this with 
        | IriObject  iri -> iri.lexicalForm
        | BlankObject  blankReference -> blankReference.lexicalForm
        | LiteralObject  rdfLiteral -> rdfLiteral.lexicalForm
        | TripleTermObject tripleTerm -> tripleTerm.lexicalForm
        | VariableObject  rdfVariable -> rdfVariable.lexicalForm
    member this.maybeCurie = 
        match this with 
        | IriObject  iri -> iri.maybeCurie
        | BlankObject  blankReference -> Some blankReference.curie
        | LiteralObject  rdfLiteral -> rdfLiteral.maybeCurie
        | TripleTermObject tripleTerm -> Some tripleTerm.curiesAndOrLexicalForms
        | VariableObject  rdfVariable -> None
    member this.asINode = 
        match this with 
        | IriObject  iri -> iri.asINode
        | BlankObject  blankReference -> blankReference.asINode
        | LiteralObject  rdfLiteral -> rdfLiteral.asINode
        | TripleTermObject tripleTerm -> tripleTerm.asINode
        | VariableObject  rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableObject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)


and PredicateObjectList =
    {

      verb: RdfPredicate
      objectLists: ObjectList array

     }

    static member inline fromTerms (predicate: RdfPredicate) (objects: RdfObject array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun rdfObject ->
                { rdfObject = rdfObject
                  annotations = [||]

                })

        }

and ObjectList =
    { rdfObject: RdfObject
      annotations: Annotation array }
and Annotation =
    | AnnotationReifier of RdfSubject
    | AnnotationBlock of PredicateObjectList
and RdfTriple =
    { curSubject: RdfSubject
      curPredicate: RdfPredicate
      curObject: RdfObject }
    static member fromVDSTriple (vdsTriple:VDS.RDF.Triple) = 

        { curSubject = RdfSubject.fromINode vdsTriple.Subject
          curPredicate = RdfPredicate.fromINode vdsTriple.Predicate
          curObject = RdfObject.fromINode vdsTriple.Object }
    static member inline fromTerms
        (rdfSubject: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject))
        (rdfPredicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate))
        (rdfObject: ^ObjectType when ^ObjectType: (member asObject: RdfObject))
        =
        { curSubject = rdfSubject.asSubject
          curPredicate = rdfPredicate.asPredicate
          curObject = rdfObject.asObject }
    static member setFromTerms
        (rdfSubjects: RdfSubject array)
        (rdfPredicates: RdfPredicate array)
        (rdfObjects: RdfObject array)
        =
        rdfObjects
        |> Array.Parallel.collect (fun rdfObject ->

            rdfPredicates
            |> Array.Parallel.collect (fun rdfPredicate ->

                rdfSubjects
                |> Array.Parallel.map (fun rdfSubject ->

                    {

                      curSubject = rdfSubject
                      curPredicate = rdfPredicate
                      curObject = rdfObject

                    }

                )))
        |> HashSet.ofSeq
    static member setFromSubjectsPredicateObjectLists
        (rdfSubjects: RdfSubject array)
        (predicateObjectLists: PredicateObjectList array)
        =
        rdfSubjects
        |> Array.Parallel.collect (fun rdfSubject ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    { curSubject = rdfSubject
                      curPredicate = predicateObjectList.verb
                      curObject = objectList.rdfObject }

                )

            )

        )
        |> HashSet.ofSeq
    member this.lexicalTriple = this.curSubject.lexicalForm, this.curPredicate.lexicalForm, this.curObject.lexicalForm
    member this.lexicalForms = 
        [|
            this.curSubject.lexicalForm
            this.curPredicate.lexicalForm
            this.curObject.lexicalForm
        |]

    member this.lexicalForm = this.lexicalForms |> String.concat " "
    member this.points =
        [| this.curSubject.asRdfTerm
           this.curPredicate.asRdfTerm
           this.curObject.asRdfTerm |]
    member this.curiesAndOrLexicalForms = 
        this.points
         |> Array.map (fun point -> defaultArg point.maybeCurie point.lexicalForm )
        |> String.concat " "
    member this.verticies = 
        [| SubjectVertex this.curSubject
           ObjectVertex this.curObject |]
    member this.asVDSTriple = new Triple (this.curSubject.asINode, this.curPredicate.asINode, this.curObject.asINode)
    member this.asITriplePattern  (patternBuilder: TriplePatternBuilder) =
        TriplePattern(
            this.curSubject.asPatternItem patternBuilder,
            this.curPredicate.asPatternItem patternBuilder,
            this.curObject.asPatternItem patternBuilder
        )
        :> ITriplePattern
and RdfTripleTerm = 
    {
        ttTriple:RdfTriple 
    }
    static member fromVDSTriple (vdsTriple:VDS.RDF.Triple) = 
        {
            ttTriple = RdfTriple.fromVDSTriple vdsTriple
        }
    static member fromTripleNode (tripleNode:TripleNode) = RdfTripleTerm.fromVDSTriple tripleNode.Triple
    member this.ttSubject = this.ttTriple.curSubject
    member this.ttPredicate = this.ttTriple.curPredicate
    member this.ttObject = this.ttTriple.curObject
    member this.asTripleNode = new TripleNode(this.ttTriple.asVDSTriple)
    member this.lexicalForm = this.ttTriple.lexicalForm
    member this.curiesAndOrLexicalForms = this.ttTriple.curiesAndOrLexicalForms
    member this.asINode :INode = this.asTripleNode

and Formula =
    {

      subjects: RdfSubject array
      predicates: RdfPredicate array
      objects: RdfObject array
      predicateObjectLists: PredicateObjectList array
      triples: HashSet<RdfTriple>

     }
    static member Empty =

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromIGraph(igraph: IGraph) =
        { Formula.Empty with
            triples =
                igraph.Triples
                |> PSeq.map (fun vdsTriple ->

                    RdfTriple.fromVDSTriple vdsTriple

                )
                |> HashSet.ofSeq

         }

    static member fromGraphLiteralNode(graphLiteralNode: GraphLiteralNode) =
        Formula.fromIGraph graphLiteralNode.SubGraph


    member this.ITriplePatterns(patternBuilder: TriplePatternBuilder) : ITriplePattern array =
        this.triples
        |> Seq.toArray
        |> Array.map (fun rdfTriple -> patternBuilder |> rdfTriple.asITriplePattern)

    member this.asRdfTripleSet: RdfTripleSet = { triples = this.triples }


    static member fromRdfSubject rdfSubject =

        { subjects = [| rdfSubject |]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfSubjects rdfSubjects =

        { subjects = rdfSubjects |> List.toArray
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfPredicate rdfPredicate =

        { subjects = [||]
          predicates = [| rdfPredicate |]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfPredicates rdfPredicates =

        { subjects = [||]
          predicates = rdfPredicates
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfObject rdfObject =

        { subjects = [||]
          predicates = [||]
          objects = [| rdfObject |]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfObjects rdfObjects =

        { subjects = [||]
          predicates = [||]
          objects = rdfObjects
          predicateObjectLists = [||]
          triples = HashSet.empty

        }


    member this.materializeTriples =
        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples =
            Seq.concat [ this.triples
                         RdfTriple.setFromTerms this.subjects this.predicates this.objects
                         RdfTriple.setFromSubjectsPredicateObjectLists this.subjects this.predicateObjectLists ]
            |> HashSet.ofSeq


        }

    static member materializeFormula(formula: Formula) = formula.materializeTriples

    member this.addFormulas(formulas: Formula list) =
        { this with
            triples =
                Seq.concat [ this.triples
                             formulas |> Seq.collect (fun formula -> formula.triples) |> HashSet.ofSeq ]
                |> HashSet.ofSeq }



    member this.addRdfSubjects rdfSubjects =
        { this with subjects = this.subjects |> Array.append rdfSubjects }

    member this.addRdfSubject rdfSubject = this.addRdfSubjects [| rdfSubject |]


    member this.addRdfPredicates rdfPredicates =

        { this with predicates = this.predicates |> Array.append rdfPredicates }

    member this.addPredicateObjectLists predicateObjectLists =

        { this with
            predicateObjectLists =
                this.predicateObjectLists
                |> Array.append predicateObjectLists }

    member this.addRdfPredicate rdfPredicate =
        this.addRdfPredicates [| rdfPredicate |]

    member this.addRdfObjects rdfObjects =
        { this with objects = this.objects |> Array.append rdfObjects }

    member this.addRdfObject rdfObject = this.addRdfObjects [| rdfObject |]

    member this.addRdfLiteral rdfLiteral =
        RdfLiteral.autotyped rdfLiteral
        |> RdfObject.LiteralObject
        |> this.addRdfObject

    member this.addRdfLiterals rdfLiterals =
        rdfLiterals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> RdfLiteral.autotyped
            |> RdfObject.LiteralObject)
        |> this.addRdfObjects
    member this.lexicalForm = 
        this.triples
        |> Seq.toArray
        |> Array.map (fun triple -> triple.lexicalForm)
        |> String.concat "\n"
    member this.curiesAndOrLexicalForms = 
        this.triples
        |> Seq.toArray
        |> Array.map (fun triple -> triple.curiesAndOrLexicalForms)
        |> String.concat "\n"


and Point = 
  | IriPoint of Iri
  | BlankPoint of BlankReference
  | LiteralPoint of RdfLiteral
  | TriplePoint of RdfTripleTerm
  | VariablePoint of RdfVariable
  | FormulaPoint of Formula
  
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriPoint
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankPoint
        | NodeType.Literal ->
            inode :?> LiteralNode
            |> RdfLiteral.fromLiteralNode
            |> LiteralPoint
        | NodeType.Triple ->
            inode :?> TripleNode
            |> RdfTripleTerm.fromTripleNode
            |> TriplePoint
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariablePoint
        | NodeType.GraphLiteral ->
           inode :?> GraphLiteralNode
           |> Formula.fromGraphLiteralNode
           |> FormulaPoint
  member this.lexicalForm = 
    match this with 
    | IriPoint iri -> iri.lexicalForm
    | BlankPoint blankNode -> blankNode.lexicalForm
    | LiteralPoint literal -> literal.lexicalForm
    | VariablePoint variable -> variable.lexicalForm
    | TriplePoint tripleTerm -> tripleTerm.lexicalForm
    | FormulaPoint formula -> formula.lexicalForm
  member this.maybeCurie = 
    match this with 
    | IriPoint iri -> iri.maybeCurie
    | BlankPoint blankNode -> Some blankNode.curie
    | LiteralPoint literal -> literal.maybeCurie
    | VariablePoint variable -> None
    | TriplePoint tripleTerm -> Some tripleTerm.curiesAndOrLexicalForms
    | FormulaPoint formula -> Some formula.curiesAndOrLexicalForms



and Vertex =
    | SubjectVertex of RdfSubject
    | ObjectVertex of RdfObject


    member this.asRenderedString (prefixDelimiter: string)  =
        match this with
        | SubjectVertex rdfSubject -> defaultArg rdfSubject.maybeCurie rdfSubject.lexicalForm |> _.Replace(":",prefixDelimiter)
        | ObjectVertex rdfObject -> defaultArg  rdfObject.maybeCurie rdfObject.lexicalForm |> _.Replace(":",prefixDelimiter)

and Edge =
    | PredicateEdge of RdfPredicate
    | TripleEdge of RdfTriple

    member this.asRenderedString (prefixDelimiter: string)  =
        match this with
        | PredicateEdge rdfPredicate -> defaultArg rdfPredicate.maybeCurie rdfPredicate.lexicalForm |> _.Replace(":",prefixDelimiter)
        | TripleEdge rdfTriple -> defaultArg rdfTriple.curPredicate.maybeCurie rdfTriple.lexicalForm |> _.Replace(":",prefixDelimiter)

and RdfName = 
    | IriName of Iri
    | LiteralName of RdfLiteral

and RdfReference = 
  | NamedReference of IriReference
  | AnonymousReference of BlankReference


and RdfTripleSet =
    { triples: HashSet<RdfTriple> }

    member this.verticies =
        this.triples
        |> Array.ofSeq
        |> Array.Parallel.collect (fun triple -> triple.verticies)
        |> Array.distinct

    member this.points =
        this.triples
        |> PSeq.collect (fun triple -> triple.points)
        |> PSeq.distinct
        |> Array.ofSeq
        |> Array.distinct

    member this.iris =
        this.points
        |> Array.Parallel.choose (fun point ->
            match point with
            | IriPoint iri -> Some iri
            | _ -> None)
        |> Array.distinct

    member this.prefixedNames =
        this.iris
        |> Array.Parallel.choose (fun iri ->
            match iri with
            | PrefixedIri prefixedName -> Some prefixedName
            | _ -> None)
        |> Array.distinct

    member this.prefixIds =
        this.prefixedNames
        |> Array.Parallel.map (fun prefixedName -> prefixedName.prefixId)
        |> Array.distinct


    static member fromIGraph(igraph: IGraph) =
        { triples =
            igraph.Triples
            |> PSeq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> HashSet.ofSeq }






























































type VDS.RDF.BlankNode with 
    member this.asBlankReference = { blankNodeIdentifier = this.InternalID}
type VDS.RDF.UriNode with 
    member this.asIriReference = IriReference this.Uri
type VDS.RDF.LiteralNode with 
    member this.asRDFLiteral = 
        match this.DataType.OriginalString, this.Language with 
        | "http://www.w3.org/2001/XMLSchema#string", _ -> SimpleString this.Value |> PlainLiteral
        | "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString", languageTagString -> 
            {
              lexicalForm = this.Value
              languageTag = LanguageTag.Parse languageTagString
            } |> LanguageString |> PlainLiteral
        | datatype, "" -> 
            DatatypedLiteral {
                            lexicalForm = this.Value
                            datatypeIri =  Iri.fromUri this.DataType 
                          }
        | _ -> failwithf "%O %s %s failed " this this.DataType.OriginalString this.Language

type IGraph with 
    member this.RdfsEntailedGraph() = 
        let rdfsEntailedGraph = new ThreadSafeGraph()
        rdfsEntailedGraph.Assert this.Triples |> ignore
        RdfsReasoner().Apply rdfsEntailedGraph
        rdfsEntailedGraph
type RDFGraph with 
    member this.triples = this |> Seq.toArray
type RDFNamespace with 
    member this.NamespaceName = this.NamespaceUri.OriginalString


type INode with 
    member this.asRdfTerm = 
          match this with 
          | :? UriNode as uriNode -> Iri.fromUriNode uriNode |> IriPoint
          | :? BlankNode as blankNode -> BlankReference.fromBlankNode blankNode |> BlankPoint
          | :? LiteralNode as literalNode -> RdfLiteral.fromLiteralNode literalNode |> LiteralPoint
          | :? TripleNode as tripleNode -> RdfTripleTerm.fromTripleNode tripleNode |> TriplePoint 
          | :? VariableNode as variableNode -> RdfVariable.fromVariableNode variableNode |> VariablePoint
          | :? GraphLiteralNode as graphLiteralNode -> Formula.fromGraphLiteralNode graphLiteralNode |> FormulaPoint




type OntologyClass with 
    member this.asRdfTerm = this.Resource.asRdfTerm
type OntologyProperty with 
    member this.asRdfTerm = this.Resource.asRdfTerm
































type RdfDocument = 
  {
    rdfFile: FileInfo
  }
  static member fromTurtleVocabulary (prefixId:PrefixId) = { rdfFile = prefixId.asFileExtension ".ttl" }
  member this.asIGraph :IGraph = 
        let igraph = new ThreadSafeGraph()
        FileLoader.Load(igraph,this.rdfFile.FullName)
        namespaceMapper.Import igraph.NamespaceMap
        igraph
  member this.asOntologyGraph = 
        let ontologyGraph = new OntologyGraph()
        FileLoader.Load(ontologyGraph,this.rdfFile.FullName)
        namespaceMapper.Import ontologyGraph.NamespaceMap
        ontologyGraph
  member this.asRDFGraph = RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, this.rdfFile.FullName)
  // member this.asOWLOntology = task { return! OWLOntology.FromRDFGraphAsync this.asRDFGraph } |> Async.AwaitTask |> Async.RunSynchronously
  member this.asDataTable = this.asRDFGraph.ToDataTable()
  member this.points = 
      this.asIGraph.AllNodes
    |> Seq.toArray
    |> Array.map Point.fromINode
  member this.iris = this.points |> Array.choose (fun point -> 
    match point with 
    | IriPoint iri -> Some iri
    | _ -> None
    )
  member this.prefixedNames = this.iris |> Array.choose (fun iri -> 
    match iri with 
    | PrefixedIri prefixedName -> Some prefixedName
    | _ -> None
    )

  member this.literals = this.points |> Array.choose (fun point -> 
    match point with 
    | LiteralPoint literal -> Some literal
    | _ -> None
    )
  member this.blankNodes = this.points |> Array.choose (fun point -> 
    match point with 
    | BlankPoint blankNode -> Some blankNode
    | _ -> None
    )

  member this.namespacedNames (namespacePrefixId:PrefixId) = 
      this.prefixedNames |> Array.filter (fun prefixedName -> prefixedName.prefixId.namespaceName = namespacePrefixId.namespaceName) |> Array.sortBy (fun prefixedName -> prefixedName.localName)







module RdfLiteral =



    let true_ = RdfLiteral.autotyped true
    let false_ = RdfLiteral.autotyped false

    module Binary =

        let base64 (bytes: Byte array) =
            let valueString = Convert.ToBase64String(bytes)

            PrefixId.xsd.prefix "base64Binary"
            |> RdfLiteral.datatyped valueString

        let hex (bytes: Byte array) =
            let valueString = Convert.ToHexString(bytes)

            PrefixId.xsd.prefix "hexBinary"
            |> RdfLiteral.datatyped valueString


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let valueString = Xml.XmlConvert.ToString(timespan)

                PrefixId.xsd.prefix "duration"
                |> RdfLiteral.datatyped valueString

            let dayTimeDuration (timespan: TimeSpan) =
                let valueString = Xml.XmlConvert.ToString(timespan)

                PrefixId.xdt.prefix "dayTimeDuration"
                |> RdfLiteral.datatyped valueString


            let yearMonthDuration (years: int) (months: int) =
                let totalMonths = years * 12 + months

                let valueString =
                    if totalMonths = 0 then
                        "P0M"
                    else
                        let absoluteMonths = abs totalMonths
                        let yearsPart = absoluteMonths / 12
                        let monthsPart = absoluteMonths % 12
                        let sign = if totalMonths < 0 then "-" else ""

                        let yearText =
                            if yearsPart = 0 then
                                ""
                            else
                                $"{yearsPart}Y"

                        let monthText =
                            if monthsPart = 0 then
                                ""
                            else
                                $"{monthsPart}M"

                        $"{sign}P{yearText}{monthText}"

                PrefixId.xdt.prefix "yearMonthDuration"
                |> RdfLiteral.datatyped valueString


        module date =

            let only (date: DateOnly) =
                let valueString = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "date"
                |> RdfLiteral.datatyped valueString

            let fromDatetime (datetime: DateTime) =
                let valueString = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "date"
                |> RdfLiteral.datatyped valueString

            let time (datetime: DateTime) =
                let valueString = datetime.ToString("o", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "dateTime"
                |> RdfLiteral.datatyped valueString

            let timeStamp (datetimeOffset: DateTimeOffset) =
                let valueString = datetimeOffset.ToString("o", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "dateTimeStamp"
                |> RdfLiteral.datatyped valueString



        module time =

            let only (time: TimeOnly) =
                let valueString = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "time"
                |> RdfLiteral.datatyped valueString

            let fromDatetime (datetime: DateTime) =
                let valueString =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "time"
                |> RdfLiteral.datatyped valueString

        module period =

            let day (datetime: DateTime) =
                let valueString =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gDay"
                |> RdfLiteral.datatyped valueString


            let month (datetime: DateTime) =
                let valueString =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gMonth"
                |> RdfLiteral.datatyped valueString


            let monthDay (datetime: DateTime) =
                let valueString =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gMonthDay"
                |> RdfLiteral.datatyped valueString


            let year (datetime: DateTime) =
                let valueString = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "gYear"
                |> RdfLiteral.datatyped valueString


            let yearMonth (datetime: DateTime) =
                let valueString =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gYearMonth"
                |> RdfLiteral.datatyped valueString
            let generalDay (day: int) =
                // TODO find a strongly typed parse instead of validation
                // test <@ day >= 1 && day <= 99 @>
                let valueString = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.owlTime.prefix "generalDay"
                |> RdfLiteral.datatyped valueString


            let generalMonth (month: int) =
                // TODO find a strongly typed parse instead of validation
                // test <@ month >= 1 && month <= 20 @>
                let valueString = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.owlTime.prefix "generalMonth"
                |> RdfLiteral.datatyped valueString


            let generalYear (year: int) =
                let valueString = year.ToString("0000", CultureInfo.InvariantCulture)

                PrefixId.owlTime.prefix "generalYear"
                |> RdfLiteral.datatyped valueString


    module Numeric =

        let private bigintValueString (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            PrefixId.xsd.prefix "integer"
            |> RdfLiteral.datatyped (bigintValueString value)

        let negativeInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value < 0I @>

            PrefixId.xsd.prefix "negativeInteger"
            |> RdfLiteral.datatyped (bigintValueString value)

        let nonNegativeInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value >= 0I @>

            PrefixId.xsd.prefix "nonNegativeInteger"
            |> RdfLiteral.datatyped (bigintValueString value)

        let nonPositiveInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value <= 0I @>

            PrefixId.xsd.prefix "nonPositiveInteger"
            |> RdfLiteral.datatyped (bigintValueString value)

        let positiveInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value > 0I @>

            PrefixId.xsd.prefix "positiveInteger"
            |> RdfLiteral.datatyped (bigintValueString value)
















type SparqlResultSet with
    member this.columnByVariables(rdfVariable: RdfVariable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> Point.fromINode)
        |> Seq.toArray

// ─────────────────────────────────────────────────────────────
// Existing dotNetRDF query-form adapters
// ─────────────────────────────────────────────────────────────

let SELECTALL () : ISelectBuilder = QueryBuilder.SelectAll()


let SELECT (variables: RdfVariable seq) : ISelectBuilder =
    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let CONSTRUCT (patternBuilder: TriplePatternBuilder) (formula: Formula) : IQueryBuilder =
    QueryBuilder.Construct(
        Action<IDescribeGraphPatternBuilder> (fun constructTemplate ->
            constructTemplate.Where(patternBuilder |> formula.ITriplePatterns)
            |> ignore)
    )


let ASK () : IQueryBuilder = QueryBuilder.Ask()


let DISCOVER (variables: RdfVariable seq) : IDescribeBuilder =
    variables
    |> Seq.map (fun variable -> variable.questionForm)
    |> Seq.toArray
    |> QueryBuilder.Describe


let DESCRIBE (iris: Iri seq) : SparqlQuery =
    iris
    |> Seq.map (fun iri -> iri.asUri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


let repairDescribeVariables (query: SparqlQuery) : SparqlQuery =
    if query.QueryType = SparqlQueryType.Describe then

        let queryVariables = query.Variables :?> Generic.ICollection<SparqlVariable>

        query.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variableName = token.Value.Substring(1)

            let alreadyRegistered =
                queryVariables
                |> Seq.exists (fun variable -> variable.Name = variableName)

            if not alreadyRegistered then
                queryVariables.Add(SparqlVariable(variableName, true)))

    query


let WHERE (patternBuilder: TriplePatternBuilder) (formula: Formula) (queryBuilder: IQueryBuilder) : SparqlQuery =
    queryBuilder
        .Where(patternBuilder |> formula.ITriplePatterns)
        .BuildQuery()
    |> repairDescribeVariables


let processQuery (graph: IGraph) (query: SparqlQuery) : obj =
    let dataset = new InMemoryDataset(graph)

    let processor = new LeviathanQueryProcessor(dataset)

    processor.ProcessQuery(query)


type FromWhereDraft =
    { sourceGraph: IGraph option
      whereFormula: Formula option }


let  emptyFromWhereDraft =
    { sourceGraph = None
      whereFormula = None }


type FromWhereBuilder<'Result>(execute: IGraph -> Formula -> 'Result) =

    member _.Yield(_: unit) : FromWhereDraft = emptyFromWhereDraft

    member _.Zero() : FromWhereDraft = emptyFromWhereDraft

    member _.For(_draft: FromWhereDraft, continuation: unit -> FromWhereDraft) : FromWhereDraft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: FromWhereDraft, graph: IGraph) : FromWhereDraft =
        match draft.sourceGraph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with sourceGraph = Some graph }


    [<CustomOperation("where")>]
    member _.Where(draft: FromWhereDraft, formula: Formula) : FromWhereDraft =
        match draft.whereFormula with
        | Some _ -> invalidOp "The query already contains a where clause."

        | None -> { draft with whereFormula = Some formula }


    member _.Run(draft: FromWhereDraft) : 'Result =
        let graph =
            match draft.sourceGraph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        let whereFormula =
            match draft.whereFormula with
            | Some formula -> formula

            | None -> invalidOp "The query requires a 'where' clause."


        execute graph whereFormula

type FromDraft = { sourceGraph: IGraph option }


let private emptyFromDraft = { sourceGraph = None }


type FromBuilder<'Result>(execute: IGraph -> 'Result) =

    member _.Yield(_: unit) : FromDraft = emptyFromDraft

    member _.Zero() : FromDraft = emptyFromDraft

    member _.For(_draft: FromDraft, continuation: unit -> FromDraft) : FromDraft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: FromDraft, graph: IGraph) : FromDraft =
        match draft.sourceGraph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with sourceGraph = Some graph }


    member _.Run(draft: FromDraft) : 'Result =
        let graph =
            match draft.sourceGraph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        execute graph

module sparql =

    let select (variables: RdfVariable seq) : FromWhereBuilder<SparqlResultSet> =
        FromWhereBuilder<SparqlResultSet> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = SELECT variables :> IQueryBuilder

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> SparqlResultSet)


    let selectAll: FromWhereBuilder<SparqlResultSet> =
        FromWhereBuilder<SparqlResultSet> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = SELECTALL() :> IQueryBuilder

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> SparqlResultSet)


    let construct (constructFormula: Formula) : FromWhereBuilder<IGraph> =
        FromWhereBuilder<IGraph> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = CONSTRUCT patternBuilder constructFormula

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> IGraph)


    let ask: FromWhereBuilder<bool> =
        FromWhereBuilder<bool> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let query = ASK() |> WHERE patternBuilder whereFormula

            let resultSet = processQuery graph query :?> SparqlResultSet

            resultSet.Result)


    let discover (variables: RdfVariable seq) : FromWhereBuilder<IGraph> =
        FromWhereBuilder<IGraph> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = DISCOVER variables :> IQueryBuilder

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> IGraph)


    let describe (iris: Iri seq) : FromBuilder<IGraph> =
        FromBuilder<IGraph> (fun graph ->

            let query = DESCRIBE iris

            processQuery graph query :?> IGraph)















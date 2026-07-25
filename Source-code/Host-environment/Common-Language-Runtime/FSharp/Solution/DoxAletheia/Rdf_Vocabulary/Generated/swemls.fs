namespace https.w3id.org.semsys.ns.swemls.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swemls =
    let _namespace_iri = Namespace_Iri swemls |> NamespaceIRI
    /// <summary>
    ///   <para>swemls:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>SWeML System</para>
    /// labels<para>System</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#System">https://w3id.org/semsys/ns/swemls#System</seealso>
    let System = Prefixed_Name(swemls, "System") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Taiwan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Taiwan</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Taiwan">https://w3id.org/semsys/ns/swemls#Taiwan</seealso>
    let Taiwan = Prefixed_Name(swemls, "Taiwan") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Thailand</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Thailand</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Thailand">https://w3id.org/semsys/ns/swemls#Thailand</seealso>
    let Thailand = Prefixed_Name(swemls, "Thailand") |> PrefixedName
    /// <summary>
    ///   <para>swemls:The_Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>The Netherlands</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#The_Netherlands">https://w3id.org/semsys/ns/swemls#The_Netherlands</seealso>
    let The_Netherlands = Prefixed_Name(swemls, "The_Netherlands") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Tunisia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Tunisia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Tunisia">https://w3id.org/semsys/ns/swemls#Tunisia</seealso>
    let Tunisia = Prefixed_Name(swemls, "Tunisia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Turkey</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Turkey">https://w3id.org/semsys/ns/swemls#Turkey</seealso>
    let Turkey = Prefixed_Name(swemls, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>swemls:UK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>UK</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#UK">https://w3id.org/semsys/ns/swemls#UK</seealso>
    let UK = Prefixed_Name(swemls, "UK") |> PrefixedName
    /// <summary>
    ///   <para>swemls:USA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>USA</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#USA">https://w3id.org/semsys/ns/swemls#USA</seealso>
    let USA = Prefixed_Name(swemls, "USA") |> PrefixedName
    /// <summary>
    ///   <para>swemls:author_country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Country to which authors describing the SWeML systems in their paper are affiliated to</para>
    /// labels<para>author country</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#author_country">https://w3id.org/semsys/ns/swemls#author_country</seealso>
    let author_country = Prefixed_Name(swemls, "author_country") |> PrefixedName
    /// <summary>
    ///   <para>swemls:componentModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the system with component models</para>
    /// labels<para>component model</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#componentModel">https://w3id.org/semsys/ns/swemls#componentModel</seealso>
    let componentModel = Prefixed_Name(swemls, "componentModel") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Fusion-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Basic pattern type: a single algorithmic module consumes more than one input</para>
    /// labels<para>Fusion Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Fusion-Pattern">https://w3id.org/semsys/ns/swemls#Fusion-Pattern</seealso>
    let Fusion_Pattern = Prefixed_Name(swemls, "Fusion-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:M-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M-Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#M-Pattern">https://w3id.org/semsys/ns/swemls#M-Pattern</seealso>
    let M_Pattern = Prefixed_Name(swemls, "M-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Other-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Other Patterns that do not fit in any other category</para>
    /// labels<para>Other Patterns</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Other-Pattern">https://w3id.org/semsys/ns/swemls#Other-Pattern</seealso>
    let Other_Pattern = Prefixed_Name(swemls, "Other-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:T-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Advanded pattern type: a chain of Atomic and Fusion Patterns</para>
    /// labels<para>T-Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#T-Pattern">https://w3id.org/semsys/ns/swemls#T-Pattern</seealso>
    let T_Pattern = Prefixed_Name(swemls, "T-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Y-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Advanced pattern type: combination of two (or more) Atomic Patterns via a Fusion Pattern</para>
    /// labels<para>Y-Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Y-Pattern">https://w3id.org/semsys/ns/swemls#Y-Pattern</seealso>
    let Y_Pattern = Prefixed_Name(swemls, "Y-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:ProcessingEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Processing engine, that processes semantic web resources e.g.  SPARQL query engine, reasoner</para>
    /// labels<para>Processing Engine</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ProcessingEngine">https://w3id.org/semsys/ns/swemls#ProcessingEngine</seealso>
    let ProcessingEngine = Prefixed_Name(swemls, "ProcessingEngine") |> PrefixedName

    /// <summary>
    ///   <para>swemls:SemanticWebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Semantic entities or relations</para>
    /// labels<para>Semantic Web Resource</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SemanticWebResource">https://w3id.org/semsys/ns/swemls#SemanticWebResource</seealso>
    let SemanticWebResource =
        Prefixed_Name(swemls, "SemanticWebResource") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasResourceFormalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the symbol formalism with the semantic web resource data</para>
    /// labels<para>Resource Formalism</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasResourceFormalism">https://w3id.org/semsys/ns/swemls#hasResourceFormalism</seealso>
    let hasResourceFormalism =
        Prefixed_Name(swemls, "hasResourceFormalism") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasResourceSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the semantic web resource with the resource size</para>
    /// labels<para>resource size</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasResourceSize">https://w3id.org/semsys/ns/swemls#hasResourceSize</seealso>
    let hasResourceSize = Prefixed_Name(swemls, "hasResourceSize") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the semantic web resource with the resource type</para>
    /// labels<para>resource type</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasResourceType">https://w3id.org/semsys/ns/swemls#hasResourceType</seealso>
    let hasResourceType = Prefixed_Name(swemls, "hasResourceType") |> PrefixedName
    /// <summary>
    ///   <para>swemls:ResourceFormalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Formalism of the semantic web resource data</para>
    /// labels<para>Symbol Formalism</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ResourceFormalism">https://w3id.org/semsys/ns/swemls#ResourceFormalism</seealso>
    let ResourceFormalism = Prefixed_Name(swemls, "ResourceFormalism") |> PrefixedName
    /// <summary>
    ///   <para>swemls:ResourceSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Size of the semantic web resource(s) in triples</para>
    /// labels<para>Resource Size</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ResourceSize">https://w3id.org/semsys/ns/swemls#ResourceSize</seealso>
    let ResourceSize = Prefixed_Name(swemls, "ResourceSize") |> PrefixedName
    /// <summary>
    ///   <para>swemls:ResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource type of the semantic web resources resource, e.g. ontology, queries</para>
    /// labels<para>Resource Type</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ResourceType">https://w3id.org/semsys/ns/swemls#ResourceType</seealso>
    let ResourceType = Prefixed_Name(swemls, "ResourceType") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Pakistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Pakistan</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Pakistan">https://w3id.org/semsys/ns/swemls#Pakistan</seealso>
    let Pakistan = Prefixed_Name(swemls, "Pakistan") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Palestine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Palestine</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Palestine">https://w3id.org/semsys/ns/swemls#Palestine</seealso>
    let Palestine = Prefixed_Name(swemls, "Palestine") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Paper in which the SWeML system is described</para>
    /// labels<para>Paper</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Paper">https://w3id.org/semsys/ns/swemls#Paper</seealso>
    let Paper = Prefixed_Name(swemls, "Paper") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Poland</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Poland">https://w3id.org/semsys/ns/swemls#Poland</seealso>
    let Poland = Prefixed_Name(swemls, "Poland") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Portual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Portual</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Portual">https://w3id.org/semsys/ns/swemls#Portual</seealso>
    let Portual = Prefixed_Name(swemls, "Portual") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Portugal</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Portugal">https://w3id.org/semsys/ns/swemls#Portugal</seealso>
    let Portugal = Prefixed_Name(swemls, "Portugal") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Republic_of_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Republic of Korea</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Republic_of_Korea">https://w3id.org/semsys/ns/swemls#Republic_of_Korea</seealso>
    let Republic_of_Korea = Prefixed_Name(swemls, "Republic_of_Korea") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Romania</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Romania">https://w3id.org/semsys/ns/swemls#Romania</seealso>
    let Romania = Prefixed_Name(swemls, "Romania") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Russia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Russia">https://w3id.org/semsys/ns/swemls#Russia</seealso>
    let Russia = Prefixed_Name(swemls, "Russia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Saudi_Arabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Saudi Arabia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Saudi_Arabia">https://w3id.org/semsys/ns/swemls#Saudi_Arabia</seealso>
    let Saudi_Arabia = Prefixed_Name(swemls, "Saudi_Arabia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Saudi_Ariabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Saudi Ariabia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Saudi_Ariabia">https://w3id.org/semsys/ns/swemls#Saudi_Ariabia</seealso>
    let Saudi_Ariabia = Prefixed_Name(swemls, "Saudi_Ariabia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Scotland</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Scotland">https://w3id.org/semsys/ns/swemls#Scotland</seealso>
    let Scotland = Prefixed_Name(swemls, "Scotland") |> PrefixedName
    /// <summary>
    ///   <para>swemls:SemanticModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deductive Model</para>
    /// labels<para>Semantic Model</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SemanticModel">https://w3id.org/semsys/ns/swemls#SemanticModel</seealso>
    let SemanticModel = Prefixed_Name(swemls, "SemanticModel") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A representation of symbolic data such as semantic entities or relations.</para>
    /// labels<para>Symbol</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Symbol">https://w3id.org/semsys/ns/swemls#Symbol</seealso>
    let Symbol = Prefixed_Name(swemls, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Singapore</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Singapore">https://w3id.org/semsys/ns/swemls#Singapore</seealso>
    let Singapore = Prefixed_Name(swemls, "Singapore") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Slovenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Slovenia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Slovenia">https://w3id.org/semsys/ns/swemls#Slovenia</seealso>
    let Slovenia = Prefixed_Name(swemls, "Slovenia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>South Korea</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#South_Korea">https://w3id.org/semsys/ns/swemls#South_Korea</seealso>
    let South_Korea = Prefixed_Name(swemls, "South_Korea") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Spain</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Spain">https://w3id.org/semsys/ns/swemls#Spain</seealso>
    let Spain = Prefixed_Name(swemls, "Spain") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Sri_Lanka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Sri Lanka</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Sri_Lanka">https://w3id.org/semsys/ns/swemls#Sri_Lanka</seealso>
    let Sri_Lanka = Prefixed_Name(swemls, "Sri_Lanka") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Sudan</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Sudan">https://w3id.org/semsys/ns/swemls#Sudan</seealso>
    let Sudan = Prefixed_Name(swemls, "Sudan") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Sweden</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Sweden">https://w3id.org/semsys/ns/swemls#Sweden</seealso>
    let Sweden = Prefixed_Name(swemls, "Sweden") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Switzerland</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Switzerland">https://w3id.org/semsys/ns/swemls#Switzerland</seealso>
    let Switzerland = Prefixed_Name(swemls, "Switzerland") |> PrefixedName
    /// <summary>
    ///   <para>swemls:StatisticalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inductive Model</para>
    /// labels<para>Statistical Model</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#StatisticalModel">https://w3id.org/semsys/ns/swemls#StatisticalModel</seealso>
    let StatisticalModel = Prefixed_Name(swemls, "StatisticalModel") |> PrefixedName
    /// <summary>
    ///   <para>swemls:UAE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>UAE</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#UAE">https://w3id.org/semsys/ns/swemls#UAE</seealso>
    let UAE = Prefixed_Name(swemls, "UAE") |> PrefixedName
    /// <summary>
    ///   <para>swemls:componentInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>component input</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#componentInput">https://w3id.org/semsys/ns/swemls#componentInput</seealso>
    let componentInput = Prefixed_Name(swemls, "componentInput") |> PrefixedName
    /// <summary>
    ///   <para>swemls:componentOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>component output</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#componentOutput">https://w3id.org/semsys/ns/swemls#componentOutput</seealso>
    let componentOutput = Prefixed_Name(swemls, "componentOutput") |> PrefixedName

    /// <summary>
    ///   <para>swemls:evaluation_data_split</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on used training, development and test set
    /// used in evaluation: yes, no</para>
    /// labels<para>evaluation data split</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#evaluation_data_split">https://w3id.org/semsys/ns/swemls#evaluation_data_split</seealso>
    let evaluation_data_split =
        Prefixed_Name(swemls, "evaluation_data_split") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasAuthorsCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a paper with the countries of author's affiliations</para>
    /// labels<para>has authors country</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasAuthorsCountry">https://w3id.org/semsys/ns/swemls#hasAuthorsCountry</seealso>
    let hasAuthorsCountry = Prefixed_Name(swemls, "hasAuthorsCountry") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasCorrespondingPatternStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the corresponding step of a pattern workflow with a specific system component</para>
    /// labels<para>has corresponding pattern step</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep">https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep</seealso>
    let hasCorrespondingPatternStep =
        Prefixed_Name(swemls, "hasCorrespondingPatternStep") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a SWeML system with a research area it is associated with</para>
    /// labels<para>has area</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasArea">https://w3id.org/semsys/ns/swemls#hasArea</seealso>
    let hasArea = Prefixed_Name(swemls, "hasArea") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Keywords assigned to the publication by the authors</para>
    /// labels<para>has keyword</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasKeyword">https://w3id.org/semsys/ns/swemls#hasKeyword</seealso>
    let hasKeyword = Prefixed_Name(swemls, "hasKeyword") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasProcessingEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>SWeMLs can have one or more processing engines</para>
    /// labels<para>has processing engine</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasProcessingEngine">https://w3id.org/semsys/ns/swemls#hasProcessingEngine</seealso>
    let hasProcessingEngine =
        Prefixed_Name(swemls, "hasProcessingEngine") |> PrefixedName

    /// <summary>
    ///   <para>swemls:evaluation_data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on used data sets: yes, no</para>
    /// labels<para>evaluation data</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#evaluation_data">https://w3id.org/semsys/ns/swemls#evaluation_data</seealso>
    let evaluation_data = Prefixed_Name(swemls, "evaluation_data") |> PrefixedName
    /// <summary>
    ///   <para>swemls:evaluation_metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on used metrics in evaluation: yes, no</para>
    /// labels<para>evaluation metrics</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#evaluation_metrics">https://w3id.org/semsys/ns/swemls#evaluation_metrics</seealso>
    let evaluation_metrics = Prefixed_Name(swemls, "evaluation_metrics") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasApplicationDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the system with the application domain it is working in</para>
    /// labels<para>has application domain</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasApplicationDomain">https://w3id.org/semsys/ns/swemls#hasApplicationDomain</seealso>
    let hasApplicationDomain =
        Prefixed_Name(swemls, "hasApplicationDomain") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasCorrespondingPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A SWeML system has a corresponding pattern</para>
    /// labels<para>has corresponding pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern">https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern</seealso>
    let hasCorrespondingPattern =
        Prefixed_Name(swemls, "hasCorrespondingPattern") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasDataIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data as in- output(s) in the workflow</para>
    /// labels<para>has data I/O</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasDataIO">https://w3id.org/semsys/ns/swemls#hasDataIO</seealso>
    let hasDataIO = Prefixed_Name(swemls, "hasDataIO") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasSystemIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes in- and outputs to SWeML systems</para>
    /// labels<para>has system I/O</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSystemIO">https://w3id.org/semsys/ns/swemls#hasSystemIO</seealso>
    let hasSystemIO = Prefixed_Name(swemls, "hasSystemIO") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>System has documentation providing details about e.g. training steps or split, used datasets and evaluation metrics</para>
    /// labels<para>has documentation</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasDocumentation">https://w3id.org/semsys/ns/swemls#hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(swemls, "hasDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A SWeML system can have one or more models</para>
    /// labels<para>has model</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasModel">https://w3id.org/semsys/ns/swemls#hasModel</seealso>
    let hasModel = Prefixed_Name(swemls, "hasModel") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasStatisticalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A SWeML system linking to at least one statistical model</para>
    /// labels<para>has statistical model</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStatisticalModel">https://w3id.org/semsys/ns/swemls#hasStatisticalModel</seealso>
    let hasStatisticalModel =
        Prefixed_Name(swemls, "hasStatisticalModel") |> PrefixedName

    /// <summary>
    ///   <para>swemls:hasStepKR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking SWeMLs to Knowledge Representation component(s) in different steps of the workflow</para>
    /// labels<para>has KR step</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepKR">https://w3id.org/semsys/ns/swemls#hasStepKR</seealso>
    let hasStepKR = Prefixed_Name(swemls, "hasStepKR") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasSystemComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>SWeMLs can have one or more system components</para>
    /// labels<para>has system component</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSystemComponent">https://w3id.org/semsys/ns/swemls#hasSystemComponent</seealso>
    let hasSystemComponent = Prefixed_Name(swemls, "hasSystemComponent") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking SWeMLs to Machine Learning component(s) in different steps of the workflow</para>
    /// labels<para>has ML step</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML">https://w3id.org/semsys/ns/swemls#hasStepML</seealso>
    let hasStepML = Prefixed_Name(swemls, "hasStepML") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepML3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ML step 3</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML3">https://w3id.org/semsys/ns/swemls#hasStepML3</seealso>
    let hasStepML3 = Prefixed_Name(swemls, "hasStepML3") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepML4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ML step 4</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML4">https://w3id.org/semsys/ns/swemls#hasStepML4</seealso>
    let hasStepML4 = Prefixed_Name(swemls, "hasStepML4") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasSymbolUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking system to symbol usage</para>
    /// labels<para>has symbol usage</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSymbolUsage">https://w3id.org/semsys/ns/swemls#hasSymbolUsage</seealso>
    let hasSymbolUsage = Prefixed_Name(swemls, "hasSymbolUsage") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the system to the task it is solving</para>
    /// labels<para>has task</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasTask">https://w3id.org/semsys/ns/swemls#hasTask</seealso>
    let hasTask = Prefixed_Name(swemls, "hasTask") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasTrainingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the training type of the system</para>
    /// labels<para>has training type</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasTrainingType">https://w3id.org/semsys/ns/swemls#hasTrainingType</seealso>
    let hasTrainingType = Prefixed_Name(swemls, "hasTrainingType") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 2</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData2">https://w3id.org/semsys/ns/swemls#hasVariableData2</seealso>
    let hasVariableData2 = Prefixed_Name(swemls, "hasVariableData2") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 3</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData3">https://w3id.org/semsys/ns/swemls#hasVariableData3</seealso>
    let hasVariableData3 = Prefixed_Name(swemls, "hasVariableData3") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 5</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData5">https://w3id.org/semsys/ns/swemls#hasVariableData5</seealso>
    let hasVariableData5 = Prefixed_Name(swemls, "hasVariableData5") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 6</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData6">https://w3id.org/semsys/ns/swemls#hasVariableData6</seealso>
    let hasVariableData6 = Prefixed_Name(swemls, "hasVariableData6") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableSW1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable SW 1</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW1">https://w3id.org/semsys/ns/swemls#hasVariableSW1</seealso>
    let hasVariableSW1 = Prefixed_Name(swemls, "hasVariableSW1") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableSW2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable SW 2</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW2">https://w3id.org/semsys/ns/swemls#hasVariableSW2</seealso>
    let hasVariableSW2 = Prefixed_Name(swemls, "hasVariableSW2") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableSW3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable SW 3</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW3">https://w3id.org/semsys/ns/swemls#hasVariableSW3</seealso>
    let hasVariableSW3 = Prefixed_Name(swemls, "hasVariableSW3") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableSW4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable SW 4</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableSW4">https://w3id.org/semsys/ns/swemls#hasVariableSW4</seealso>
    let hasVariableSW4 = Prefixed_Name(swemls, "hasVariableSW4") |> PrefixedName
    /// <summary>
    ///   <para>swemls:has_link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Link of the paper</para>
    /// labels<para>has link</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#has_link">https://w3id.org/semsys/ns/swemls#has_link</seealso>
    let has_link = Prefixed_Name(swemls, "has_link") |> PrefixedName
    /// <summary>
    ///   <para>swemls:has_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of the paper</para>
    /// labels<para>has title</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#has_title">https://w3id.org/semsys/ns/swemls#has_title</seealso>
    let has_title = Prefixed_Name(swemls, "has_title") |> PrefixedName
    /// <summary>
    ///   <para>swemls:infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on used infrastructure: yes, no</para>
    /// labels<para>infrastructure</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#infrastructure">https://w3id.org/semsys/ns/swemls#infrastructure</seealso>
    let infrastructure = Prefixed_Name(swemls, "infrastructure") |> PrefixedName
    /// <summary>
    ///   <para>swemls:parameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on used parameters: yes, no</para>
    /// labels<para>parameters</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#parameters">https://w3id.org/semsys/ns/swemls#parameters</seealso>
    let parameters = Prefixed_Name(swemls, "parameters") |> PrefixedName
    /// <summary>
    ///   <para>swemls:process_steps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on performed processing steps, such as
    /// pre-processing, cross-validation: yes, no</para>
    /// labels<para>process steps</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#process_steps">https://w3id.org/semsys/ns/swemls#process_steps</seealso>
    let process_steps = Prefixed_Name(swemls, "process_steps") |> PrefixedName
    /// <summary>
    ///   <para>swemls:provenance_support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of input/output data provenance collection: yes, no</para>
    /// labels<para>provenance support</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#provenance_support">https://w3id.org/semsys/ns/swemls#provenance_support</seealso>
    let provenance_support = Prefixed_Name(swemls, "provenance_support") |> PrefixedName
    /// <summary>
    ///   <para>swemls:venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The venue where the paper is published</para>
    /// labels<para>venue</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#venue">https://w3id.org/semsys/ns/swemls#venue</seealso>
    let venue = Prefixed_Name(swemls, "venue") |> PrefixedName
    /// <summary>
    ///   <para>swemls:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Year in which the paper is published</para>
    /// labels<para>year</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#year">https://w3id.org/semsys/ns/swemls#year</seealso>
    let year = Prefixed_Name(swemls, "year") |> PrefixedName
    /// <summary>
    ///   <para>swemls:isOfType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the paper type to the paper</para>
    /// labels<para>is of type</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#isOfType">https://w3id.org/semsys/ns/swemls#isOfType</seealso>
    let isOfType = Prefixed_Name(swemls, "isOfType") |> PrefixedName
    /// <summary>
    ///   <para>swemls:reports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking the system reported in the paper</para>
    /// labels<para>reports</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#reports">https://w3id.org/semsys/ns/swemls#reports</seealso>
    let reports = Prefixed_Name(swemls, "reports") |> PrefixedName
    /// <summary>
    ///   <para>swemls:software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Presence of documentation on used software and libraries: yes, no</para>
    /// labels<para>software</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#software">https://w3id.org/semsys/ns/swemls#software</seealso>
    let software = Prefixed_Name(swemls, "software") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepKR1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has KR step 1</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepKR1">https://w3id.org/semsys/ns/swemls#hasStepKR1</seealso>
    let hasStepKR1 = Prefixed_Name(swemls, "hasStepKR1") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepML2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ML step 2</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML2">https://w3id.org/semsys/ns/swemls#hasStepML2</seealso>
    let hasStepML2 = Prefixed_Name(swemls, "hasStepML2") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepML5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ML step 5</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML5">https://w3id.org/semsys/ns/swemls#hasStepML5</seealso>
    let hasStepML5 = Prefixed_Name(swemls, "hasStepML5") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasSystemMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>System has a certain maturity according to different characteristics (stability, UI)</para>
    /// labels<para>has system maturity</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSystemMaturity">https://w3id.org/semsys/ns/swemls#hasSystemMaturity</seealso>
    let hasSystemMaturity = Prefixed_Name(swemls, "hasSystemMaturity") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Positioning of the Paper in relation to research araeas e.g. Explainable AI or Semantic Web Mining</para>
    /// labels<para>Area</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Area">https://w3id.org/semsys/ns/swemls#Area</seealso>
    let Area = Prefixed_Name(swemls, "Area") |> PrefixedName
    /// <summary>
    ///   <para>swemls:ApplicationDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The application domain in which the SWeML systems solve tasks (e.g. Chemistry, Legal)</para>
    /// labels<para>Application Domain</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#ApplicationDomain">https://w3id.org/semsys/ns/swemls#ApplicationDomain</seealso>
    let ApplicationDomain = Prefixed_Name(swemls, "ApplicationDomain") |> PrefixedName
    /// <summary>
    ///   <para>swemls:SystemMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maturity of the overall SWeML system</para>
    /// labels<para>System Maturity</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SystemMaturity">https://w3id.org/semsys/ns/swemls#SystemMaturity</seealso>
    let SystemMaturity = Prefixed_Name(swemls, "SystemMaturity") |> PrefixedName
    /// <summary>
    ///   <para>swemls:PaperType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Paper type, e.g. Workshop or Conference paper</para>
    /// labels<para>Paper Type</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#PaperType">https://w3id.org/semsys/ns/swemls#PaperType</seealso>
    let PaperType = Prefixed_Name(swemls, "PaperType") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Atomic-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Basic pattern type: a single algorithmic module consumes a single input</para>
    /// labels<para>Atomic Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Atomic-Pattern">https://w3id.org/semsys/ns/swemls#Atomic-Pattern</seealso>
    let Atomic_Pattern = Prefixed_Name(swemls, "Atomic-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:I-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Advanced pattern type: a chain of Atomic Patterns</para>
    /// labels<para>I-Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#I-Pattern">https://w3id.org/semsys/ns/swemls#I-Pattern</seealso>
    let I_Pattern = Prefixed_Name(swemls, "I-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Task that the SWeML system supposed to solve</para>
    /// labels<para>Task</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Task">https://w3id.org/semsys/ns/swemls#Task</seealso>
    let Task = Prefixed_Name(swemls, "Task") |> PrefixedName
    /// <summary>
    ///   <para>swemls:TrainingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Training type of the ML model(s)</para>
    /// labels<para>Training Type</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#TrainingType">https://w3id.org/semsys/ns/swemls#TrainingType</seealso>
    let TrainingType = Prefixed_Name(swemls, "TrainingType") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasStepML1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has ML step 1</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasStepML1">https://w3id.org/semsys/ns/swemls#hasStepML1</seealso>
    let hasStepML1 = Prefixed_Name(swemls, "hasStepML1") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasSymbolIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Symbol as in- output(s) in the workflow</para>
    /// labels<para>has symbol I/O</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasSymbolIO">https://w3id.org/semsys/ns/swemls#hasSymbolIO</seealso>
    let hasSymbolIO = Prefixed_Name(swemls, "hasSymbolIO") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 1</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData1">https://w3id.org/semsys/ns/swemls#hasVariableData1</seealso>
    let hasVariableData1 = Prefixed_Name(swemls, "hasVariableData1") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 4</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData4">https://w3id.org/semsys/ns/swemls#hasVariableData4</seealso>
    let hasVariableData4 = Prefixed_Name(swemls, "hasVariableData4") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 7</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData7">https://w3id.org/semsys/ns/swemls#hasVariableData7</seealso>
    let hasVariableData7 = Prefixed_Name(swemls, "hasVariableData7") |> PrefixedName
    /// <summary>
    ///   <para>swemls:hasVariableData8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable data 8</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#hasVariableData8">https://w3id.org/semsys/ns/swemls#hasVariableData8</seealso>
    let hasVariableData8 = Prefixed_Name(swemls, "hasVariableData8") |> PrefixedName
    /// <summary>
    ///   <para>swemls:has_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ID of the SWeML system</para>
    /// labels<para>has id</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#has_ID">https://w3id.org/semsys/ns/swemls#has_ID</seealso>
    let has_ID = Prefixed_Name(swemls, "has_ID") |> PrefixedName
    /// <summary>
    ///   <para>swemls:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Short summary of the paper</para>
    /// labels<para>summary</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#summary">https://w3id.org/semsys/ns/swemls#summary</seealso>
    let summary = Prefixed_Name(swemls, "summary") |> PrefixedName
    /// <summary>
    ///   <para>swemls:SymbolUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of usage of the semantic web resource</para>
    /// labels<para>Symbol Usage</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SymbolUsage">https://w3id.org/semsys/ns/swemls#SymbolUsage</seealso>
    let SymbolUsage = Prefixed_Name(swemls, "SymbolUsage") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Morocco</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Morocco</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Morocco">https://w3id.org/semsys/ns/swemls#Morocco</seealso>
    let Morocco = Prefixed_Name(swemls, "Morocco") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Brazil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Brazil</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Brazil">https://w3id.org/semsys/ns/swemls#Brazil</seealso>
    let Brazil = Prefixed_Name(swemls, "Brazil") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Bulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Bulgaria</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Bulgaria">https://w3id.org/semsys/ns/swemls#Bulgaria</seealso>
    let Bulgaria = Prefixed_Name(swemls, "Bulgaria") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Instance</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Instance">https://w3id.org/semsys/ns/swemls#Instance</seealso>
    let Instance = Prefixed_Name(swemls, "Instance") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Denmark</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Denmark">https://w3id.org/semsys/ns/swemls#Denmark</seealso>
    let Denmark = Prefixed_Name(swemls, "Denmark") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Documenation characteristics e.g. used dataset, training parameters, evaluation metrics</para>
    /// labels<para>Documentation</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Documentation">https://w3id.org/semsys/ns/swemls#Documentation</seealso>
    let Documentation = Prefixed_Name(swemls, "Documentation") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Germany</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Germany">https://w3id.org/semsys/ns/swemls#Germany</seealso>
    let Germany = Prefixed_Name(swemls, "Germany") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Greece</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Greece">https://w3id.org/semsys/ns/swemls#Greece</seealso>
    let Greece = Prefixed_Name(swemls, "Greece") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Hong_Kong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Hong Kong</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Hong_Kong">https://w3id.org/semsys/ns/swemls#Hong_Kong</seealso>
    let Hong_Kong = Prefixed_Name(swemls, "Hong_Kong") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Indonesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Indonesia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Indonesia">https://w3id.org/semsys/ns/swemls#Indonesia</seealso>
    let Indonesia = Prefixed_Name(swemls, "Indonesia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Iran</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Iran</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Iran">https://w3id.org/semsys/ns/swemls#Iran</seealso>
    let Iran = Prefixed_Name(swemls, "Iran") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ireland</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Ireland">https://w3id.org/semsys/ns/swemls#Ireland</seealso>
    let Ireland = Prefixed_Name(swemls, "Ireland") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Jamaica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Jamaica</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Jamaica">https://w3id.org/semsys/ns/swemls#Jamaica</seealso>
    let Jamaica = Prefixed_Name(swemls, "Jamaica") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Japan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Japan</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Japan">https://w3id.org/semsys/ns/swemls#Japan</seealso>
    let Japan = Prefixed_Name(swemls, "Japan") |> PrefixedName

    /// <summary>
    ///   <para>swemls:KnowledgeRepresentationComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Knowledge Representation component</para>
    /// labels<para>KR Component</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent">https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent</seealso>
    let KnowledgeRepresentationComponent =
        Prefixed_Name(swemls, "KnowledgeRepresentationComponent") |> PrefixedName

    /// <summary>
    ///   <para>swemls:SystemComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One component of the system</para>
    /// labels<para>System Component</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#SystemComponent">https://w3id.org/semsys/ns/swemls#SystemComponent</seealso>
    let SystemComponent = Prefixed_Name(swemls, "SystemComponent") |> PrefixedName

    /// <summary>
    ///   <para>swemls:MachineLearningComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Machine Learning component</para>
    /// labels<para>ML Component</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#MachineLearningComponent">https://w3id.org/semsys/ns/swemls#MachineLearningComponent</seealso>
    let MachineLearningComponent =
        Prefixed_Name(swemls, "MachineLearningComponent") |> PrefixedName

    /// <summary>
    ///   <para>swemls:Mexico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Mexico</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Mexico">https://w3id.org/semsys/ns/swemls#Mexico</seealso>
    let Mexico = Prefixed_Name(swemls, "Mexico") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Missing_Info</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Missing_Info</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Missing_Info">https://w3id.org/semsys/ns/swemls#Missing_Info</seealso>
    let Missing_Info = Prefixed_Name(swemls, "Missing_Info") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models used in the SWeML systems</para>
    /// labels<para>Model</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Model">https://w3id.org/semsys/ns/swemls#Model</seealso>
    let Model = Prefixed_Name(swemls, "Model") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Netherlands</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Netherlands">https://w3id.org/semsys/ns/swemls#Netherlands</seealso>
    let Netherlands = Prefixed_Name(swemls, "Netherlands") |> PrefixedName
    /// <summary>
    ///   <para>swemls:New_Zealand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>New Zealand</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#New_Zealand">https://w3id.org/semsys/ns/swemls#New_Zealand</seealso>
    let New_Zealand = Prefixed_Name(swemls, "New_Zealand") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Norway</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Norway">https://w3id.org/semsys/ns/swemls#Norway</seealso>
    let Norway = Prefixed_Name(swemls, "Norway") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Australia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Australia">https://w3id.org/semsys/ns/swemls#Australia</seealso>
    let Australia = Prefixed_Name(swemls, "Australia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Country to which authors describing the SWeML systems in their paper are affiliated to</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Country">https://w3id.org/semsys/ns/swemls#Country</seealso>
    let Country = Prefixed_Name(swemls, "Country") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Austria</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Austria">https://w3id.org/semsys/ns/swemls#Austria</seealso>
    let Austria = Prefixed_Name(swemls, "Austria") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Belgium</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Belgium">https://w3id.org/semsys/ns/swemls#Belgium</seealso>
    let Belgium = Prefixed_Name(swemls, "Belgium") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Canada</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Canada">https://w3id.org/semsys/ns/swemls#Canada</seealso>
    let Canada = Prefixed_Name(swemls, "Canada") |> PrefixedName
    /// <summary>
    ///   <para>swemls:China</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>China</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#China">https://w3id.org/semsys/ns/swemls#China</seealso>
    let China = Prefixed_Name(swemls, "China") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Colombia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Colombia</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Colombia">https://w3id.org/semsys/ns/swemls#Colombia</seealso>
    let Colombia = Prefixed_Name(swemls, "Colombia") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Facts and statistics collected together and used as a basis for reasoning, discussion or calculation.</para>
    /// labels<para>Data</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Data">https://w3id.org/semsys/ns/swemls#Data</seealso>
    let Data = Prefixed_Name(swemls, "Data") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Egypt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Egypt</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Egypt">https://w3id.org/semsys/ns/swemls#Egypt</seealso>
    let Egypt = Prefixed_Name(swemls, "Egypt") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Finland</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Finland">https://w3id.org/semsys/ns/swemls#Finland</seealso>
    let Finland = Prefixed_Name(swemls, "Finland") |> PrefixedName
    /// <summary>
    ///   <para>swemls:France</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>France</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#France">https://w3id.org/semsys/ns/swemls#France</seealso>
    let France = Prefixed_Name(swemls, "France") |> PrefixedName
    /// <summary>
    ///   <para>swemls:India</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>India</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#India">https://w3id.org/semsys/ns/swemls#India</seealso>
    let India = Prefixed_Name(swemls, "India") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Italy</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Italy">https://w3id.org/semsys/ns/swemls#Italy</seealso>
    let Italy = Prefixed_Name(swemls, "Italy") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Italy_and_UK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Italy and UK</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Italy_and_UK">https://w3id.org/semsys/ns/swemls#Italy_and_UK</seealso>
    let Italy_and_UK = Prefixed_Name(swemls, "Italy_and_UK") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///
    /// labels<para>Korea</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Korea">https://w3id.org/semsys/ns/swemls#Korea</seealso>
    let Korea = Prefixed_Name(swemls, "Korea") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Kosovo</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Kosovo</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Kosovo">https://w3id.org/semsys/ns/swemls#Kosovo</seealso>
    let Kosovo = Prefixed_Name(swemls, "Kosovo") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Patterns describing the SWeMLs flow</para>
    /// labels<para>Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Pattern">https://w3id.org/semsys/ns/swemls#Pattern</seealso>
    let Pattern = Prefixed_Name(swemls, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:X-Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>X-Pattern</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#X-Pattern">https://w3id.org/semsys/ns/swemls#X-Pattern</seealso>
    let X_Pattern = Prefixed_Name(swemls, "X-Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swemls:United_Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>United Kingdom</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#United_Kingdom">https://w3id.org/semsys/ns/swemls#United_Kingdom</seealso>
    let United_Kingdom = Prefixed_Name(swemls, "United_Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Vietnam</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Vietnam</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Vietnam">https://w3id.org/semsys/ns/swemls#Vietnam</seealso>
    let Vietnam = Prefixed_Name(swemls, "Vietnam") |> PrefixedName
    /// <summary>
    ///   <para>swemls:Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:semsys/ns/swemls#Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Wales</para></remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls#Wales">https://w3id.org/semsys/ns/swemls#Wales</seealso>
    let Wales = Prefixed_Name(swemls, "Wales") |> PrefixedName

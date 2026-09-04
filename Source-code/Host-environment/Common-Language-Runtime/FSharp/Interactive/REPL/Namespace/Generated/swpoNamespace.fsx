#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swpo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://sw-portal.deri.org/ontologies/swportal#" "swpo"

    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : This class represents administrative staff.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Administrative Staff</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents administrative staff.^^xsd:string</para>
    ///   <para>rdfs:label : Administrative Staff</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#AdministrativeStaff">swpo:AdministrativeStaff</a>
    /// </summary>
    let AdministrativeStaff = _prefixId.prefix "AdministrativeStaff"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : This is an adhoc solution for creating and ordered group of Agents, e.g. an authorlist.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : This is an adhoc solution for creating and ordered group of Agents, e.g. an authorlist.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#AgentSequence">swpo:AgentSequence</a>
    /// </summary>
    let AgentSequence = _prefixId.prefix "AgentSequence"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Article</para>
    ///   <para>dce:description : An article from a journal or magazine.</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Article</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : An article from a journal or magazine.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Article">swpo:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : A book with an explicit publisher. NOTES: - Either &lt;link&gt;authors&lt;/link&gt; or &lt;link&gt;editedBy&lt;/link&gt; must be given - Either &lt;link&gt;volume&lt;/link&gt; or &lt;link&gt;number&lt;/link&gt; may be given.</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:title : Book</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Book</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : A book with an explicit publisher. NOTES: - Either &lt;link&gt;authors&lt;/link&gt; or &lt;link&gt;editedBy&lt;/link&gt; must be given - Either &lt;link&gt;volume&lt;/link&gt; or &lt;link&gt;number&lt;/link&gt; may be given.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Book">swpo:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>dce:description : A work that is printed and bound, but without a named publisher or sponsoring institution.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : A work that is printed and bound, but without a named publisher or sponsoring institution.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Booklet</para>
    ///   <para>rdfs:label : Booklet</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Booklet">swpo:Booklet</a>
    /// </summary>
    let Booklet = _prefixId.prefix "Booklet"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that are cities.^^xsd:string</para>
    ///   <para>dce:description : This class defines geopraphical bodies that are cities.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : City</para>
    ///   <para>rdfs:label : City</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#City">swpo:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : </para>
    ///   <para>dce:description : This class represents all kinds of administrative staff that is related to clerical support. Examples are secretaries, accountants, etc.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : </para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of administrative staff that is related to clerical support. Examples are secretaries, accountants, etc.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#ClericalStaff">swpo:ClericalStaff</a>
    /// </summary>
    let ClericalStaff = _prefixId.prefix "ClericalStaff"
    /// <summary>
    ///   <para>rdfs:label : Cluster</para>
    ///   <para>dce:title : Cluster</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : A Cluster is a kind of group which focuses on a research area and typically is part of a research institute or university.^^xsd:string</para>
    ///   <para>dce:description : A Cluster is a kind of group which focuses on a research area and typically is part of a research institute or university.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Cluster">swpo:Cluster</a>
    /// </summary>
    let Cluster = _prefixId.prefix "Cluster"
    /// <summary>
    ///   <para>dce:title : Company</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : This class represents all kinds of companies. Currently only publishers and software developers are modelled.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:label : Company</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of companies. Currently only publishers and software developers are modelled.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Company">swpo:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : Conference</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : This class represents all kinds of conferences in the academic domain.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of conferences in the academic domain.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Conference</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Conference">swpo:Conference</a>
    /// </summary>
    let Conference = _prefixId.prefix "Conference"
    /// <summary>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that are continents.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : This class defines geopraphical bodies that are continents.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Continent</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Continent</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Continent">swpo:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : This class defines geopraphical bodies that are countries.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Country</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:title : Country</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that are countries.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Country">swpo:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Deliverable</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : A document which is produced as part of a project. Deliverables are not formally published. NOTE: This concept was not derived from any of the BibTex types, but considered useful anyway.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : A document which is produced as part of a project. Deliverables are not formally published. NOTE: This concept was not derived from any of the BibTex types, but considered useful anyway.^^xsd:string</para>
    ///   <para>dce:title : Deliverable</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Deliverable">swpo:Deliverable</a>
    /// </summary>
    let Deliverable = _prefixId.prefix "Deliverable"
    /// <summary>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:label : Event</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Event</para>
    ///   <para>rdfs:comment : This class represents events relevant for the area of teaching, research, business, i.e. conferences, presentations, tutorials, workshops and lectures.^^xsd:string</para>
    ///   <para>dce:description : This class represents events relevant for the area of teaching, research, business, i.e. conferences, presentations, tutorials, workshops and lectures.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Event">swpo:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Inbook</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : A part of a Book, which may be a chapter (or section or whatever) and/or a range of pages. Because the BibTex types inCollection and inBook are very similiar, we decided to keep the ontology as simple as possible and merge them both into &lt;link&gt;Inbook&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : A part of a Book, which may be a chapter (or section or whatever) and/or a range of pages. Because the BibTex types inCollection and inBook are very similiar, we decided to keep the ontology as simple as possible and merge them both into &lt;link&gt;Inbook&lt;/link&gt;.</para>
    ///   <para>rdfs:label : Inbook</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Inbook">swpo:Inbook</a>
    /// </summary>
    let Inbook = _prefixId.prefix "Inbook"
    /// <summary>
    ///   <para>dce:title : Dated Publication</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Dated Publication</para>
    ///   <para>rdfs:comment : The instances of this class comprise all publications which have a specific publication date. If a publication P is contained within an &lt;link&gt;PublicationContainer&lt;/link&gt;, and this container has a publication date, than P is not an &lt;link&gt;IndividualPublication&lt;/link&gt;. Example: an &lt;link&gt;Inbook&lt;/link&gt; publication is not an &lt;link&gt;IndividualPublication&lt;/link&gt;, because its publication date can be inferred from the &lt;link&gt;Book&lt;/link&gt; which contains it.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : The instances of this class comprise all publications which have a specific publication date. If a publication P is contained within an &lt;link&gt;PublicationContainer&lt;/link&gt;, and this container has a publication date, than P is not an &lt;link&gt;IndividualPublication&lt;/link&gt;. Example: an &lt;link&gt;Inbook&lt;/link&gt; publication is not an &lt;link&gt;IndividualPublication&lt;/link&gt;, because its publication date can be inferred from the &lt;link&gt;Book&lt;/link&gt; which contains it.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#IndividualPublication">swpo:IndividualPublication</a>
    /// </summary>
    let IndividualPublication = _prefixId.prefix "IndividualPublication"
    /// <summary>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Initiative</para>
    ///   <para>dce:description : An initiative is a group which has specific aims. It differs from &lt;link&gt;foaf:Project&lt;/link&gt; in that it normally doesn’t have any funding. Often, its duration is longer.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : An initiative is a group which has specific aims. It differs from &lt;link&gt;foaf:Project&lt;/link&gt; in that it normally doesn’t have any funding. Often, its duration is longer.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:title : Initiative</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Initiative">swpo:Initiative</a>
    /// </summary>
    let Initiative = _prefixId.prefix "Initiative"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:title : Inproceedings</para>
    ///   <para>dce:description : An article in a conference proceedings (i.e. Proceedings).</para>
    ///   <para>rdfs:label : Inproceedings</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : An article in a conference proceedings (i.e. Proceedings).^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Inproceedings">swpo:Inproceedings</a>
    /// </summary>
    let Inproceedings = _prefixId.prefix "Inproceedings"
    /// <summary>
    ///   <para>rdfs:comment : A scientific journal or magazine. The instances of this class are not individual issues or voulumes of a journal, but the journal as such.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Journal</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:title : Journal</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : A scientific journal or magazine. The instances of this class are not individual issues or voulumes of a journal, but the journal as such.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Journal">swpo:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : This class represents lectures with an educational purpose, e.g within a university.</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Lecture</para>
    ///   <para>rdfs:comment : This class represents lectures with an educational purpose, e.g within a university.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : Lecture</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Lecture">swpo:Lecture</a>
    /// </summary>
    let Lecture = _prefixId.prefix "Lecture"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : Location</para>
    ///   <para>dce:description : This class is the superclass for all classes defining geographical locations. The approach for this subontology is to have a hierarchy of location classes, such that instances of the classes further down in the hierarchy can be contained in instances of the classes higher up in the hierarchy. On each level, there exist two sister classes: class L defines a certain type of location, while class SubL defines locations which can be contained in instances of L. SubL then defines a property inL, to express which instance of L an instance of SubL is contained in. E.g. for a class Continent, there exists a class SubContinent. All children of SubContinent (either direct or transitive) define locations that can be contained in a continent, such as countries, regions, cities, etc. By virtue of inheritance, all these location classes then have a property inContinent, to express that they are contained in some continent. In a simpler, flat structure, inContinent would have to be defined explicitly for all kinds of locations that can be contained in a continent.
    /// The intepretation of the inL predicates should be as follows: if, for a particular instance K, inL has a value, this value is valid. If inL has no value, the value of inL in the next location K is contained in valid, and so forth. E.g. an instance "Hawaii" has the value "Oceania" defined for &lt;link&gt;inContinent&lt;/link&gt; and "USA" for &lt;link&gt;inCountry&lt;/link&gt;. "Delaware" has no value for inContinent. "USA" has the value "North America" for &lt;link&gt;inContinent&lt;/link&gt;. The interpretation would be that "Hawaii" is located in "Oceania", while "Delaware" is located in "North America".
    /// We are aware of the fact that this approach is idealized and can therefore conflict with reality in some situations. E.g., the exact borders of continents are not always defined (there are contradicting opinions on where exactly Europe begins or ends). Countries could be contained in more than one continent (Turkey belongs to both Europe and Asia). However, we think that these situations are marginal and have little or no impact on the intended use of this ontology.
    /// We think that this recursive modelling of locations is at the same time simple and powerful enough to capture all necessary aspects of the concept of location for a domain such as an SWPortal. While the SubL classes might appear to be somewhat artificial, they are actually not. They are just an abstraction for geographical entities that are (under normal circumstances) smaller than entities of type L. As such, they are no more abstract than, say, the concept of an agent.
    /// </para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Location</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class is the superclass for all classes defining geographical locations. The approach for this subontology is to have a hierarchy of location classes, such that instances of the classes further down in the hierarchy can be contained in instances of the classes higher up in the hierarchy. On each level, there exist two sister classes: class L defines a certain type of location, while class SubL defines locations which can be contained in instances of L. SubL then defines a property inL, to express which instance of L an instance of SubL is contained in. E.g. for a class Continent, there exists a class SubContinent. All children of SubContinent (either direct or transitive) define locations that can be contained in a continent, such as countries, regions, cities, etc. By virtue of inheritance, all these location classes then have a property inContinent, to express that they are contained in some continent. In a simpler, flat structure, inContinent would have to be defined explicitly for all kinds of locations that can be contained in a continent.
    /// The intepretation of the inL predicates should be as follows: if, for a particular instance K, inL has a value, this value is valid. If inL has no value, the value of inL in the next location K is contained in valid, and so forth. E.g. an instance "Hawaii" has the value "Oceania" defined for &lt;link&gt;inContinent&lt;/link&gt; and "USA" for &lt;link&gt;inCountry&lt;/link&gt;. "Delaware" has no value for inContinent. "USA" has the value "North America" for &lt;link&gt;inContinent&lt;/link&gt;. The interpretation would be that "Hawaii" is located in "Oceania", while "Delaware" is located in "North America".
    /// We are aware of the fact that this approach is idealized and can therefore conflict with reality in some situations. E.g., the exact borders of continents are not always defined (there are contradicting opinions on where exactly Europe begins or ends). Countries could be contained in more than one continent (Turkey belongs to both Europe and Asia). However, we think that these situations are marginal and have little or no impact on the intended use of this ontology.
    /// We think that this recursive modelling of locations is at the same time simple and powerful enough to capture all necessary aspects of the concept of location for a domain such as an SWPortal. While the SubL classes might appear to be somewhat artificial, they are actually not. They are just an abstraction for geographical entities that are (under normal circumstances) smaller than entities of type L. As such, they are no more abstract than, say, the concept of an agent.
    /// ^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Location">swpo:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>dce:title : Management Staff</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the management staff.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : Management Staff</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : This class represents the management staff.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#ManagementStaff">swpo:ManagementStaff</a>
    /// </summary>
    let ManagementStaff = _prefixId.prefix "ManagementStaff"
    /// <summary>
    ///   <para>dce:title : Master Thesis</para>
    ///   <para>rdfs:comment : A thesis written to receive a Master degree.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : A thesis written to receive a Master degree.</para>
    ///   <para>rdfs:label : Master Thesis</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#MasterThesis">swpo:MasterThesis</a>
    /// </summary>
    let MasterThesis = _prefixId.prefix "MasterThesis"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : Some sort of publication which doesn't fit into any of the other concepts.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : Some sort of publication which doesn't fit into any of the other concepts.^^xsd:string</para>
    ///   <para>dce:title : Misc</para>
    ///   <para>rdfs:label : Misc</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Misc">swpo:Misc</a>
    /// </summary>
    let Misc = _prefixId.prefix "Misc"
    /// <summary>
    ///   <para>rdfs:label : News Item</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : News Item</para>
    ///   <para>rdfs:comment : This class is the super-class for any kind of news item.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : This class is the super-class for any kind of news item.</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#NewsItem">swpo:NewsItem</a>
    /// </summary>
    let NewsItem = _prefixId.prefix "NewsItem"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an organization with a formal legal status. We introduce this class as a subclass of &lt;link&gt;foaf:Organization&lt;/link&gt; and &lt;link&gt;foaf:Group&lt;/link&gt;, because we consider an organization as a kind of group.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : This class represents an organization with a formal legal status. We introduce this class as a subclass of &lt;link&gt;foaf:Organization&lt;/link&gt; and &lt;link&gt;foaf:Group&lt;/link&gt;, because we consider an organization as a kind of group.</para>
    ///   <para>dce:title : Organization</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Organization">swpo:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : PhD Thesis</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : PhD Thesis</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : A thesis written to receive a PhD degree.</para>
    ///   <para>rdfs:comment : A thesis written to receive a PhD degree.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#PhDThesis">swpo:PhDThesis</a>
    /// </summary>
    let PhDThesis = _prefixId.prefix "PhDThesis"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : Instances of this class represent exact postal addresses. Note that either &lt;link&gt;postbox&lt;/link&gt; of &lt;link&gt;streetAddress&lt;/link&gt; should be given.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Postal Address</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Postal Address</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : Instances of this class represent exact postal addresses. Note that either &lt;link&gt;postbox&lt;/link&gt; of &lt;link&gt;streetAddress&lt;/link&gt; should be given.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#PostalAddress">swpo:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Presentation</para>
    ///   <para>dce:description : This class represents all kinds of presentations.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Presentation</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of presentations.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Presentation">swpo:Presentation</a>
    /// </summary>
    let Presentation = _prefixId.prefix "Presentation"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Proceedings</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The proceedings of a conference.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Proceedings</para>
    ///   <para>rdfs:comment : The proceedings of a conference.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Proceedings">swpo:Proceedings</a>
    /// </summary>
    let Proceedings = _prefixId.prefix "Proceedings"
    /// <summary>
    ///   <para>dce:title : Publication</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Publication</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:comment : Publications are both individual documents and collections of documents such as series, journals, etc.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : Publications are both individual documents and collections of documents such as series, journals, etc.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Publication">swpo:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>dce:description : This class comprises all kinds of publications which contain other publications, such as journal, proceedings, series, etc. An instance of PublicationContainer has an editor.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Publication Container</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises all kinds of publications which contain other publications, such as journal, proceedings, series, etc. An instance of PublicationContainer has an editor.^^xsd:string</para>
    ///   <para>rdfs:label : Publication Container</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#PublicationContainer">swpo:PublicationContainer</a>
    /// </summary>
    let PublicationContainer = _prefixId.prefix "PublicationContainer"
    /// <summary>
    ///   <para>dce:title : Publishing Company</para>
    ///   <para>rdfs:label : Publishing Company</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : This class models companies that publish documents.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : This class models companies that publish documents.</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#PublishingCompany">swpo:PublishingCompany</a>
    /// </summary>
    let PublishingCompany = _prefixId.prefix "PublishingCompany"
    /// <summary>
    ///   <para>rdfs:label : Region</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Region</para>
    ///   <para>dce:description : This class defines geopraphical bodies that are regions, with the intended meaning "sub-division of a country".</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that are regions, with the intended meaning "sub-division of a country".^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Region">swpo:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>dce:description : This class represents research institutes. These organizations have special research areas.</para>
    ///   <para>rdfs:label : Research Institute</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : Research Institute</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents research institutes. These organizations have special research areas.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#ResearchInstitute">swpo:ResearchInstitute</a>
    /// </summary>
    let ResearchInstitute = _prefixId.prefix "ResearchInstitute"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Research Staff</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of researchers who are not students.^^xsd:string</para>
    ///   <para>dce:description : This class represents all kinds of researchers who are not students.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Research Staff</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#ResearchStaff">swpo:ResearchStaff</a>
    /// </summary>
    let ResearchStaff = _prefixId.prefix "ResearchStaff"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Researcher</para>
    ///   <para>dce:description : This class represents all kinds of persons who are researchers. Each has a research area.</para>
    ///   <para>rdfs:label : Researcher^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of persons who are researchers. Each has a research area.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Researcher">swpo:Researcher</a>
    /// </summary>
    let Researcher = _prefixId.prefix "Researcher"
    /// <summary>
    ///   <para>dce:description : A series or set of books.</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : A series or set of books.^^xsd:string</para>
    ///   <para>rdfs:label : Series</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Series</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Series">swpo:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>dce:description : This class models companies that develop software and sell it.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Software Company</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class models companies that develop software and sell it.^^xsd:string</para>
    ///   <para>dce:title : Software Company</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#SoftwareCompany">swpo:SoftwareCompany</a>
    /// </summary>
    let SoftwareCompany = _prefixId.prefix "SoftwareCompany"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of researchers who are students.^^xsd:string</para>
    ///   <para>rdfs:label : Student</para>
    ///   <para>dce:description : This class represents all kinds of researchers who are students.</para>
    ///   <para>dce:title : Student</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Student">swpo:Student</a>
    /// </summary>
    let Student = _prefixId.prefix "Student"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : This class defines geopraphical bodies that can be contained in cities.</para>
    ///   <para>dce:title : Sub-City</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that can be contained in cities.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : Sub-City</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#SubCity">swpo:SubCity</a>
    /// </summary>
    let SubCity = _prefixId.prefix "SubCity"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that can be contained in continents.^^xsd:string</para>
    ///   <para>dce:title : Sub-Continent</para>
    ///   <para>dce:description : This class defines geopraphical bodies that can be contained in continents.</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Sub-Continent</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#SubContinent">swpo:SubContinent</a>
    /// </summary>
    let SubContinent = _prefixId.prefix "SubContinent"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : This class defines geopraphical bodies that can be contained in countries.</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that can be contained in countries.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Sub-Country</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Sub-Country</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#SubCountry">swpo:SubCountry</a>
    /// </summary>
    let SubCountry = _prefixId.prefix "SubCountry"
    /// <summary>
    ///   <para>rdfs:label : Sub-Region</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : This class defines geopraphical bodies that can be contained in regions.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:title : Sub-Region</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : This class defines geopraphical bodies that can be contained in regions.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#SubRegion">swpo:SubRegion</a>
    /// </summary>
    let SubRegion = _prefixId.prefix "SubRegion"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents all kinds of administrative staff that is employed for technical issues. Examples are system administrators, hardware specialists, etc.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : This class represents all kinds of administrative staff that is employed for technical issues. Examples are system administrators, hardware specialists, etc.</para>
    ///   <para>dce:title : </para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>rdfs:label : </para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#TechnicalStaff">swpo:TechnicalStaff</a>
    /// </summary>
    let TechnicalStaff = _prefixId.prefix "TechnicalStaff"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Techreport</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:title : Techreport</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : A report published by a school or other organization, usually numbered within a series (&lt;link&gt;Series&lt;/link&gt;). This concept has been merged from BibTex's techreport and manual types, since both are described very similiar.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : A report published by a school or other organization, usually numbered within a series (&lt;link&gt;Series&lt;/link&gt;). This concept has been merged from BibTex's techreport and manual types, since both are described very similiar.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Techreport">swpo:Techreport</a>
    /// </summary>
    let Techreport = _prefixId.prefix "Techreport"
    /// <summary>
    ///   <para>dce:title : Temporary Group</para>
    ///   <para>rdfs:label : Temporary Group</para>
    ///   <para>dce:description : As &lt;link&gt;foaf:Project&lt;/link&gt;, &lt;link&gt;Initiative&lt;/link&gt; and &lt;link&gt;WorkingGroup&lt;/link&gt; differ from Cluster in having a specific duration, we comprise these there temporal groups in this class which represents all kinds of temporary groups.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : As &lt;link&gt;foaf:Project&lt;/link&gt;, &lt;link&gt;Initiative&lt;/link&gt; and &lt;link&gt;WorkingGroup&lt;/link&gt; differ from Cluster in having a specific duration, we comprise these there temporal groups in this class which represents all kinds of temporary groups.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#TemporaryGroup">swpo:TemporaryGroup</a>
    /// </summary>
    let TemporaryGroup = _prefixId.prefix "TemporaryGroup"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : Any kind of thesis produced to receive some sort of university degree.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : Any kind of thesis produced to receive some sort of university degree.</para>
    ///   <para>dce:title : Thesis</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Thesis^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Thesis">swpo:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Tool</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : Tool</para>
    ///   <para>rdfs:comment : This class represents any kind of software tool. At the moment, this class is clearly underspecified.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : This class represents any kind of software tool. At the moment, this class is clearly underspecified.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Tool">swpo:Tool</a>
    /// </summary>
    let Tool = _prefixId.prefix "Tool"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Topic</para>
    ///   <para>rdfs:comment : All research topics inherit from this concept. This should serve as a plugin point for the research topic ontology.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : All research topics inherit from this concept. This should serve as a plugin point for the research topic ontology.</para>
    ///   <para>rdfs:label : Topic</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Topic">swpo:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>dce:description : This class represents all kinds of tutorials.</para>
    ///   <para>rdfs:comment : This class represents all kinds of tutorials.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Tutorial</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Tutorial</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Tutorial">swpo:Tutorial</a>
    /// </summary>
    let Tutorial = _prefixId.prefix "Tutorial"
    /// <summary>
    ///   <para>dce:description : This class represents universities. We decided to introduce two different classes to distinguish between universities and independent research institutes. The main difference is actually the different kinds of independence. In contrast to a university, a research institute is independent from the rigorous bureaucracy of the mainly state-run universities. On the other hand, a university is independent from the economy and the financial support of companies. Thus, the kind of research an independent research institute practises is generally more application-oriented.</para>
    ///   <para>dce:title : University</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>rdfs:label : University</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents universities. We decided to introduce two different classes to distinguish between universities and independent research institutes. The main difference is actually the different kinds of independence. In contrast to a university, a research institute is independent from the rigorous bureaucracy of the mainly state-run universities. On the other hand, a university is independent from the economy and the financial support of companies. Thus, the kind of research an independent research institute practises is generally more application-oriented.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#University">swpo:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : A document which does have an author and title, but hasn't been formally published.^^xsd:string</para>
    ///   <para>dce:description : A document which does have an author and title, but hasn't been formally published.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : Unpublished</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Unpublished</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Unpublished">swpo:Unpublished</a>
    /// </summary>
    let Unpublished = _prefixId.prefix "Unpublished"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : An individual volume of some &lt;link&gt;Journal&lt;/link&gt;.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : An individual volume of some &lt;link&gt;Journal&lt;/link&gt;.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Volume">swpo:Volume</a>
    /// </summary>
    let Volume = _prefixId.prefix "Volume"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2000/01/rdf-schema#Class^^xsd:string</para>
    ///   <para>dce:description : A work package is a subdivision of a project. It stands in a part-of relationship to &lt;link&gt;foaf:Project&lt;/link&gt;.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : A work package is a subdivision of a project. It stands in a part-of relationship to &lt;link&gt;foaf:Project&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:title : Work Package</para>
    ///   <para>rdfs:label : Work Package</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#WorkPackage">swpo:WorkPackage</a>
    /// </summary>
    let WorkPackage = _prefixId.prefix "WorkPackage"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : A working group is similar to &lt;link&gt;Initiative&lt;/link&gt;. We might unify two classes into one in the future.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Working Group</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : A working group is similar to &lt;link&gt;Initiative&lt;/link&gt;. We might unify two classes into one in the future.^^xsd:string</para>
    ///   <para>rdfs:label : Working Group</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#WorkingGroup">swpo:WorkingGroup</a>
    /// </summary>
    let WorkingGroup = _prefixId.prefix "WorkingGroup"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : This class represents all kinds of workshops</para>
    ///   <para>rdfs:comment : This class represents all kinds of workshops^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#Class^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Workshop</para>
    ///   <para>dce:title : Workshop</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#Workshop">swpo:Workshop</a>
    /// </summary>
    let Workshop = _prefixId.prefix "Workshop"
    /// <summary>
    ///   <para>rdfs:comment : The first &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:label : First^^xsd:string</para>
    ///   <para>dce:description : The first &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>dce:title : First</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_1">swpo:agent_1</a>
    /// </summary>
    let agent_1 = _prefixId.prefix "agent_1"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Tenth</para>
    ///   <para>dce:description : The tenth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>rdfs:label : Tenth^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : The tenth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_10">swpo:agent_10</a>
    /// </summary>
    let agent_10 = _prefixId.prefix "agent_10"
    /// <summary>
    ///   <para>dce:title : Second</para>
    ///   <para>rdfs:label : Second^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : The second &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The second &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_2">swpo:agent_2</a>
    /// </summary>
    let agent_2 = _prefixId.prefix "agent_2"
    /// <summary>
    ///   <para>dce:title : Third</para>
    ///   <para>dce:description : The third &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>rdfs:comment : The third &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:label : Third^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_3">swpo:agent_3</a>
    /// </summary>
    let agent_3 = _prefixId.prefix "agent_3"
    /// <summary>
    ///   <para>rdfs:label : Fourth^^xsd:string</para>
    ///   <para>dce:title : Fourth</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The fourth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>rdfs:comment : The fourth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_4">swpo:agent_4</a>
    /// </summary>
    let agent_4 = _prefixId.prefix "agent_4"
    /// <summary>
    ///   <para>dce:description : The fifth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : The fifth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Fifth</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Fifth^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_5">swpo:agent_5</a>
    /// </summary>
    let agent_5 = _prefixId.prefix "agent_5"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : Sixth^^xsd:string</para>
    ///   <para>dce:description : The sixth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>dce:title : Sixth</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The sixth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_6">swpo:agent_6</a>
    /// </summary>
    let agent_6 = _prefixId.prefix "agent_6"
    /// <summary>
    ///   <para>rdfs:label : Seventh^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : The seventh &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : Seventh</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : The seventh &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_7">swpo:agent_7</a>
    /// </summary>
    let agent_7 = _prefixId.prefix "agent_7"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Eigth^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The eigth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:title : Eigth</para>
    ///   <para>dce:description : The eigth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_8">swpo:agent_8</a>
    /// </summary>
    let agent_8 = _prefixId.prefix "agent_8"
    /// <summary>
    ///   <para>rdfs:label : Ninth^^xsd:string</para>
    ///   <para>rdfs:comment : The ninth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:description : The ninth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : Ninth</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#agent_9">swpo:agent_9</a>
    /// </summary>
    let agent_9 = _prefixId.prefix "agent_9"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : The school where a thesis was written.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:description : The school where a thesis was written.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:title : At School</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : At School</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#atSchool">swpo:atSchool</a>
    /// </summary>
    let atSchool = _prefixId.prefix "atSchool"
    /// <summary>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Belongs to Project</para>
    ///   <para>rdfs:comment : Defines what project a workpackage belongs to.^^xsd:string</para>
    ///   <para>dce:description : Defines what project a workpackage belongs to.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Belongs to Project</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#belongsToProject">swpo:belongsToProject</a>
    /// </summary>
    let belongsToProject = _prefixId.prefix "belongsToProject"
    /// <summary>
    ///   <para>dce:title : Contained in Book</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Contained in Book</para>
    ///   <para>dce:description : The &lt;link&gt;Book&lt;/link&gt; in which an Inbook is contained.</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Book&lt;/link&gt; in which an Inbook is contained.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#containedInBook">swpo:containedInBook</a>
    /// </summary>
    let containedInBook = _prefixId.prefix "containedInBook"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:description : The journal or magazine which contains this article.</para>
    ///   <para>dce:title : Contained in Journal</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : Contained in Journal</para>
    ///   <para>rdfs:comment : The journal or magazine which contains this article.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#containedInJournal">swpo:containedInJournal</a>
    /// </summary>
    let containedInJournal = _prefixId.prefix "containedInJournal"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Contained in Proceedings</para>
    ///   <para>dce:title : Contained in Proceedings</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : The proceedings some paper or similar is contained in.</para>
    ///   <para>rdfs:comment : The proceedings some paper or similar is contained in.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#containedInProceedings">swpo:containedInProceedings</a>
    /// </summary>
    let containedInProceedings = _prefixId.prefix "containedInProceedings"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:label : Contains Articles</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : The articles or papers which a journal containes.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : Contains Articles</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The articles or papers which a journal containes.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#containsArticles">swpo:containsArticles</a>
    /// </summary>
    let containsArticles = _prefixId.prefix "containsArticles"
    /// <summary>
    ///   <para>rdfs:comment : The chapters or similar which a book contains.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#InverseFunctionalProperty^^xsd:string</para>
    ///   <para>dce:description : The chapters or similar which a book contains.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Contains Chapters</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Contains Chapters</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#containsChapters">swpo:containsChapters</a>
    /// </summary>
    let containsChapters = _prefixId.prefix "containsChapters"
    /// <summary>
    ///   <para>dce:title : Contains Papers</para>
    ///   <para>dce:description : The papers or similar which a proceedings contains.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The papers or similar which a proceedings contains.^^xsd:string</para>
    ///   <para>rdfs:label : Contains Papers</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#containsPapers">swpo:containsPapers</a>
    /// </summary>
    let containsPapers = _prefixId.prefix "containsPapers"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : The deliverables for this project. The inverse is &lt;link&gt;forProject&lt;/link&gt;.</para>
    ///   <para>dce:title : Deliverables</para>
    ///   <para>rdfs:label : Deliverables</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : The deliverables for this project. The inverse is &lt;link&gt;forProject&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#deliverables">swpo:deliverables</a>
    /// </summary>
    let deliverables = _prefixId.prefix "deliverables"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Driven by</para>
    ///   <para>dce:description : The &lt;link&gt;foaf:Agent&lt;/link&gt; this project is driven by. This is inverse to &lt;link&gt;foaf:currentProject&lt;/link&gt;. NOTE: How do we deal with the relation between drivenBy and &lt;link&gt;foaf:pastProject&lt;/link&gt;?</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Driven by</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;link&gt;foaf:Agent&lt;/link&gt; this project is driven by. This is inverse to &lt;link&gt;foaf:currentProject&lt;/link&gt;. NOTE: How do we deal with the relation between drivenBy and &lt;link&gt;foaf:pastProject&lt;/link&gt;?^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#drivenBy">swpo:drivenBy</a>
    /// </summary>
    let drivenBy = _prefixId.prefix "drivenBy"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Edited by</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:title : Edited by</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#editedBy">swpo:editedBy</a>
    /// </summary>
    let editedBy = _prefixId.prefix "editedBy"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The project for which this deliverable is produced. The inverse is &lt;link&gt;deliverables&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : For Project</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : The project for which this deliverable is produced. The inverse is &lt;link&gt;deliverables&lt;/link&gt;.</para>
    ///   <para>rdfs:label : For Project</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#forProject">swpo:forProject</a>
    /// </summary>
    let forProject = _prefixId.prefix "forProject"
    /// <summary>
    ///   <para>dce:title : From Organization</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The organization that sponsors a conference or that publishes a manual or techreport.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:label : From Organization</para>
    ///   <para>rdfs:comment : The organization that sponsors a conference or that publishes a manual or techreport.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#fromOrganization">swpo:fromOrganization</a>
    /// </summary>
    let fromOrganization = _prefixId.prefix "fromOrganization"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:title : Gives Presentations</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an agent to the presentations it gives. The inverse property is &lt;link&gt;presenter&lt;/link&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Gives Presentations</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : This property relates an agent to the presentations it gives. The inverse property is &lt;link&gt;presenter&lt;/link&gt;.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#givesPresentations">swpo:givesPresentations</a>
    /// </summary>
    let givesPresentations = _prefixId.prefix "givesPresentations"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Gives Tutorials</para>
    ///   <para>rdfs:label : Gives Tutorials</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : This property relates an agent to the tutorials it gives. The inverse property is &lt;link&gt;tutoredBy&lt;/link&gt;.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an agent to the tutorials it gives. The inverse property is &lt;link&gt;tutoredBy&lt;/link&gt;.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#givesTutorials">swpo:givesTutorials</a>
    /// </summary>
    let givesTutorials = _prefixId.prefix "givesTutorials"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Address</para>
    ///   <para>dce:title : Address</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : This property relates an agent to its address.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an agent to its address.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasAddress">swpo:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>dce:description : The author or authors of a document. For multiple authors, use either an instance of &lt;link&gt;foaf:Group&lt;/link&gt;, or multiple values.</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Authors</para>
    ///   <para>rdfs:label : Authors</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The author or authors of a document. For multiple authors, use either an instance of &lt;link&gt;foaf:Group&lt;/link&gt;, or multiple values.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasAuthors">swpo:hasAuthors</a>
    /// </summary>
    let hasAuthors = _prefixId.prefix "hasAuthors"
    /// <summary>
    ///   <para>dce:title : Duration</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The duration of a temporary group.</para>
    ///   <para>rdfs:label : Duration</para>
    ///   <para>rdfs:comment : The duration of a temporary group.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasDuration">swpo:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>dce:title : Enddate</para>
    ///   <para>dce:description : The ending date some event. </para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The ending date some event. ^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Enddate</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasEnddate">swpo:hasEnddate</a>
    /// </summary>
    let hasEnddate = _prefixId.prefix "hasEnddate"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Endtime</para>
    ///   <para>dce:description : The time when some event ends. </para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Endtime</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The time when some event ends. ^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasEndtime">swpo:hasEndtime</a>
    /// </summary>
    let hasEndtime = _prefixId.prefix "hasEndtime"
    /// <summary>
    ///   <para>dce:description : The faxnumber of some &lt;link&gt;foaf:Agent&lt;/link&gt;.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Fax</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Fax</para>
    ///   <para>rdfs:comment : The faxnumber of some &lt;link&gt;foaf:Agent&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasFax">swpo:hasFax</a>
    /// </summary>
    let hasFax = _prefixId.prefix "hasFax"
    /// <summary>
    ///   <para>rdfs:label : Goal</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Goal</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:description : The goal a group aims at. NOTE: &lt;link&gt;foaf:theme&lt;/link&gt; provides a similar functionality.</para>
    ///   <para>rdfs:comment : The goal a group aims at. NOTE: &lt;link&gt;foaf:theme&lt;/link&gt; provides a similar functionality.^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasGoal">swpo:hasGoal</a>
    /// </summary>
    let hasGoal = _prefixId.prefix "hasGoal"
    /// <summary>
    ///   <para>rdfs:label : Interests</para>
    ///   <para>rdfs:comment : The fields of interest of a person. ^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasInterests">swpo:hasInterests</a>
    /// </summary>
    let hasInterests = _prefixId.prefix "hasInterests"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : This property defines the leader of an organization, i.e. its director, chairman, etc.</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Leader</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:title : Leader</para>
    ///   <para>rdfs:comment : This property defines the leader of an organization, i.e. its director, chairman, etc.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasLeader">swpo:hasLeader</a>
    /// </summary>
    let hasLeader = _prefixId.prefix "hasLeader"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:title : Lecturer</para>
    ///   <para>rdfs:label : Lecturer</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The agent who is giving the lecture.</para>
    ///   <para>rdfs:comment : The agent who is giving the lecture.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasLecturer">swpo:hasLecturer</a>
    /// </summary>
    let hasLecturer = _prefixId.prefix "hasLecturer"
    /// <summary>
    ///   <para>dce:title : Location</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : The &lt;link&gt;Location&lt;/link&gt; of an &lt;link&gt;Event&lt;/link&gt;.</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Location&lt;/link&gt; of an &lt;link&gt;Event&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasLocation">swpo:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : Note</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:title : Note</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasNote">swpo:hasNote</a>
    /// </summary>
    let hasNote = _prefixId.prefix "hasNote"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Number</para>
    ///   <para>rdfs:label : Number</para>
    ///   <para>rdfs:comment : The number of a journal, magazine, techreport, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a numbered series. Deliverables for a project may also be given numbers.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : The number of a journal, magazine, techreport, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a numbered series. Deliverables for a project may also be given numbers.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasNumber">swpo:hasNumber</a>
    /// </summary>
    let hasNumber = _prefixId.prefix "hasNumber"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : The PO-Box of some &lt;link&gt;PostalAddress&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : POBox</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:title : POBox</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : The PO-Box of some &lt;link&gt;PostalAddress&lt;/link&gt;.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasPostbox">swpo:hasPostbox</a>
    /// </summary>
    let hasPostbox = _prefixId.prefix "hasPostbox"
    /// <summary>
    ///   <para>rdfs:comment : The presentations that are offered during the course of an event.^^xsd:string</para>
    ///   <para>dce:title : Presentations</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Presentations</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:description : The presentations that are offered during the course of an event.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasPresenations">swpo:hasPresenations</a>
    /// </summary>
    let hasPresenations = _prefixId.prefix "hasPresenations"
    /// <summary>
    ///   <para>rdfs:comment : The presenter of a presentation.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Presenter</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The presenter of a presentation.</para>
    ///   <para>dce:title : Presenter</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasPresenter">swpo:hasPresenter</a>
    /// </summary>
    let hasPresenter = _prefixId.prefix "hasPresenter"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The date of publication of some publication or software. Bibtex defines year and month. These are here combined to publicationDate.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : Publication Date</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : The date of publication of some publication or software. Bibtex defines year and month. These are here combined to publicationDate.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Publication Date</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasPublicationDate">swpo:hasPublicationDate</a>
    /// </summary>
    let hasPublicationDate = _prefixId.prefix "hasPublicationDate"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The areas of research some research institute is involved in. ^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:title : Research Areas</para>
    ///   <para>dce:description : The areas of research some research institute is involved in. </para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Research Areas</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasResearchAreas">swpo:hasResearchAreas</a>
    /// </summary>
    let hasResearchAreas = _prefixId.prefix "hasResearchAreas"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The starting date some event.</para>
    ///   <para>rdfs:comment : The starting date some event.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:label : Starting Date</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Starting Date</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasStartdate">swpo:hasStartdate</a>
    /// </summary>
    let hasStartdate = _prefixId.prefix "hasStartdate"
    /// <summary>
    ///   <para>dce:title : Starting Time</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : The time when some event starts.</para>
    ///   <para>rdfs:label : Starting Time</para>
    ///   <para>rdfs:comment : The time when some event starts.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasStarttime">swpo:hasStarttime</a>
    /// </summary>
    let hasStarttime = _prefixId.prefix "hasStarttime"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Street</para>
    ///   <para>dce:description : The street address part of an &lt;link&gt;PostalAddress&lt;/link&gt;. Can have multiple lines.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Street</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : The street address part of an &lt;link&gt;PostalAddress&lt;/link&gt;. Can have multiple lines.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasStreetAddress">swpo:hasStreetAddress</a>
    /// </summary>
    let hasStreetAddress = _prefixId.prefix "hasStreetAddress"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The tasks of a member of the administrative staff.^^xsd:string</para>
    ///   <para>dce:description : The tasks of a member of the administrative staff.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Tasks</para>
    ///   <para>dce:title : Tasks</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasTasks">swpo:hasTasks</a>
    /// </summary>
    let hasTasks = _prefixId.prefix "hasTasks"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:title : Title</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The title of the publication (book, article, ...) or publication container (series, journal).</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The title of the publication (book, article, ...) or publication container (series, journal).^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Title</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasTitle">swpo:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:comment : The tutors of a tutorial.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : The tutors of a tutorial.</para>
    ///   <para>dce:title : Tutor</para>
    ///   <para>rdfs:label : Tutor</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasTutor">swpo:hasTutor</a>
    /// </summary>
    let hasTutor = _prefixId.prefix "hasTutor"
    /// <summary>
    ///   <para>dce:title : Tutorials</para>
    ///   <para>rdfs:label : Tutorials</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The tutorials that are offered during the course of an event.^^xsd:string</para>
    ///   <para>dce:description : The tutorials that are offered during the course of an event.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasTutorials">swpo:hasTutorials</a>
    /// </summary>
    let hasTutorials = _prefixId.prefix "hasTutorials"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Volume&lt;/link&gt;s of this journal.^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : The &lt;link&gt;Volume&lt;/link&gt;s of this journal.</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasVolumes">swpo:hasVolumes</a>
    /// </summary>
    let hasVolumes = _prefixId.prefix "hasVolumes"
    /// <summary>
    ///   <para>rdfs:label : Workpackages</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:title : Workpackages</para>
    ///   <para>rdfs:comment : The work packages of a project.^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The work packages of a project.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasWorkpackages">swpo:hasWorkpackages</a>
    /// </summary>
    let hasWorkpackages = _prefixId.prefix "hasWorkpackages"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:description : The zipcode of some &lt;link&gt;PostalAddress&lt;/link&gt; (if applicable). This is simply a string with no prescribed syntax.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : The zipcode of some &lt;link&gt;PostalAddress&lt;/link&gt; (if applicable). This is simply a string with no prescribed syntax.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#hasZipcode">swpo:hasZipcode</a>
    /// </summary>
    let hasZipcode = _prefixId.prefix "hasZipcode"
    /// <summary>
    ///   <para>rdfs:label : How Published</para>
    ///   <para>dce:title : How Published</para>
    ///   <para>rdfs:comment : How something strange has been published.^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : How something strange has been published.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#howPublished">swpo:howPublished</a>
    /// </summary>
    let howPublished = _prefixId.prefix "howPublished"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The &lt;link&gt;City&lt;/link&gt; in which some &lt;link&gt;SubCity&lt;/link&gt; is contained.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;link&gt;City&lt;/link&gt; in which some &lt;link&gt;SubCity&lt;/link&gt; is contained.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : In City</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : In City</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#inCity">swpo:inCity</a>
    /// </summary>
    let inCity = _prefixId.prefix "inCity"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:label : In Continent</para>
    ///   <para>dce:title : In Continent</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : The &lt;link&gt;Continent&lt;/link&gt; in which some &lt;link&gt;SubContinent&lt;/link&gt; is contained.</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Continent&lt;/link&gt; in which some &lt;link&gt;SubContinent&lt;/link&gt; is contained.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#inContinent">swpo:inContinent</a>
    /// </summary>
    let inContinent = _prefixId.prefix "inContinent"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : In Country</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Country&lt;/link&gt; in which some &lt;link&gt;SubCountry&lt;/link&gt; is contained.^^xsd:string</para>
    ///   <para>rdfs:label : In Country</para>
    ///   <para>dce:description : The &lt;link&gt;Country&lt;/link&gt; in which some &lt;link&gt;SubCountry&lt;/link&gt; is contained.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#inCountry">swpo:inCountry</a>
    /// </summary>
    let inCountry = _prefixId.prefix "inCountry"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:title : In Region</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : In Region</para>
    ///   <para>dce:description : The &lt;link&gt;Region&lt;/link&gt; in which some &lt;link&gt;SubRegion&lt;/link&gt; is contained.</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Region&lt;/link&gt; in which some &lt;link&gt;SubRegion&lt;/link&gt; is contained.^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#inRegion">swpo:inRegion</a>
    /// </summary>
    let inRegion = _prefixId.prefix "inRegion"
    /// <summary>
    ///   <para>dce:description : The instance of &lt;link&gt;Series&lt;/link&gt; in which this document was published.</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : In Series</para>
    ///   <para>rdfs:comment : The instance of &lt;link&gt;Series&lt;/link&gt; in which this document was published.^^xsd:string</para>
    ///   <para>dce:title : In Series</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#inSeries">swpo:inSeries</a>
    /// </summary>
    let inSeries = _prefixId.prefix "inSeries"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Chapter</para>
    ///   <para>rdfs:comment : The chapter (or section or whatever) number which this &lt;link&gt;Inbook&lt;/link&gt; represents.^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:label : Chapter</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:description : The chapter (or section or whatever) number which this &lt;link&gt;Inbook&lt;/link&gt; represents.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#isChapter">swpo:isChapter</a>
    /// </summary>
    let isChapter = _prefixId.prefix "isChapter"
    /// <summary>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:comment : The edition of a book---for example, ``Second''. This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.^^xsd:string</para>
    ///   <para>dce:description : The edition of a book---for example, ``Second''. This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:label : Edition</para>
    ///   <para>dce:title : Edition</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#isEdition">swpo:isEdition</a>
    /// </summary>
    let isEdition = _prefixId.prefix "isEdition"
    /// <summary>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The version number of a document or tool.^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:description : The version number of a document or tool.</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Version</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>rdfs:label : Version</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#isVersion">swpo:isVersion</a>
    /// </summary>
    let isVersion = _prefixId.prefix "isVersion"
    /// <summary>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The volume of a journal or a multi-volume book.</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:title : Volume</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>rdfs:label : Volume</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>rdfs:comment : The volume of a journal or a multi-volume book.^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#isVolume">swpo:isVolume</a>
    /// </summary>
    let isVolume = _prefixId.prefix "isVolume"
    /// <summary>
    ///   <para>dce:description : This property defines the products of a company.</para>
    ///   <para>rdfs:label : Products</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the products of a company.^^xsd:string</para>
    ///   <para>dce:title : Products</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#makesProducts">swpo:makesProducts</a>
    /// </summary>
    let makesProducts = _prefixId.prefix "makesProducts"
    /// <summary>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The &lt;link&gt;Journal&lt;/link&gt; this volume belongs to.</para>
    ///   <para>rdfs:comment : The &lt;link&gt;Journal&lt;/link&gt; this volume belongs to.^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#ofJournal">swpo:ofJournal</a>
    /// </summary>
    let ofJournal = _prefixId.prefix "ofJournal"
    /// <summary>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:description : One or more page numbers or range of numbers, such as 42--111 or 7,41,73--97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7--33).</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#DatatypeProperty^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>rdfs:comment : One or more page numbers or range of numbers, such as 42--111 or 7,41,73--97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7--33).^^xsd:string</para>
    ///   <para>dce:title : Pages</para>
    ///   <para>rdfs:label : Pages</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#onPages">swpo:onPages</a>
    /// </summary>
    let onPages = _prefixId.prefix "onPages"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:description : The organizers of an event. At least one agent has to organize an event. The inverse property is &lt;link&gt;organizes&lt;/link&gt;.</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:title : Organized by</para>
    ///   <para>rdfs:label : Organized by</para>
    ///   <para>rdfs:comment : The organizers of an event. At least one agent has to organize an event. The inverse property is &lt;link&gt;organizes&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#organizedby">swpo:organizedby</a>
    /// </summary>
    let organizedby = _prefixId.prefix "organizedby"
    /// <summary>
    ///   <para>dce:title : Organizes</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:label : Organizes</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#ObjectProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an agent to the events it organizes. The inverse property is &lt;link&gt;organizedBy&lt;/link&gt;.^^xsd:string</para>
    ///   <para>dce:description : This property relates an agent to the events it organizes. The inverse property is &lt;link&gt;organizedBy&lt;/link&gt;.</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#organizes">swpo:organizes</a>
    /// </summary>
    let organizes = _prefixId.prefix "organizes"
    /// <summary>
    ///   <para>dce:format : application/rdf+xml^^xsd:string</para>
    ///   <para>dce:publisher : DERI International^^xsd:string</para>
    ///   <para>dce:description : The instance of &lt;link&gt;Publisher&lt;/link&gt; which published this document.</para>
    ///   <para>dce:date : 2004-10-20^^xsd:string</para>
    ///   <para>rdfs:comment : The instance of &lt;link&gt;Publisher&lt;/link&gt; which published this document.^^xsd:string</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <para>dce:type : http://www.w3.org/2002/07/owl#FunctionalProperty^^xsd:string</para>
    ///   <para>dce:creator : DERI International^^xsd:string</para>
    ///   <para>dce:coverage : world^^xsd:string</para>
    ///   <para>dce:rights : http://www.deri.org/privacy.html^^xsd:string</para>
    ///   <para>dce:title : Publisher</para>
    ///   <a href="http://sw-portal.deri.org/ontologies/swportal#publishedBy">swpo:publishedBy</a>
    /// </summary>
    let publishedBy = _prefixId.prefix "publishedBy"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pav =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/pav/" "pav"
    let _namespaceIri = _prefixId.prefix ""
    let ``_2.1`` = _prefixId.prefix "2.1"
    let ``_2.2`` = _prefixId.prefix "2.2"
    let ``_2.3`` = _prefixId.prefix "2.3"
    /// <summary>
    ///   <para>rdfs:label : Authored by</para>
    ///   <para>rdfs:comment : An agent that originated or gave existence to the work that is expressed by the digital resource.
    ///
    /// The author of the content of a resource may be different from the creator of the resource representation (although they are often the same). See pav:createdBy for a discussion.
    ///
    /// pav:authoredBy is more specific than its superproperty dct:creator - which might or might not be interpreted to also cover the creation of the representation of the artifact.
    ///
    /// The author is usually not a software agent (which would be indicated with pav:createdWith, pav:createdBy or pav:importedBy), unless the software actually authored the content itself; for instance an artificial intelligence algorithm which authored a piece of music or a machine learning algorithm that authored a classification of a tumor sample.
    ///
    /// The date of authoring can be expressed using pav:authoredOn - note however in the case of multiple authors that there is no relationship in PAV identifying which agent contributed when or what. If capturing such lineage is desired, it should be additionally expressed using PROV relationships like prov:qualifiedAttribution or prov:wasGeneratedBy.</para>
    ///   <a href="http://purl.org/pav/authoredBy">pav:authoredBy</a>
    /// </summary>
    let authoredBy = _prefixId.prefix "authoredBy"
    /// <summary>
    ///   <para>rdfs:label : Authored on</para>
    ///   <para>rdfs:comment : The date this resource was authored.
    ///
    /// pav:authoredBy gives the authoring agent.
    ///
    /// Note that pav:authoredOn is different from pav:createdOn, although they are often the same. See pav:createdBy for a discussion.
    ///
    /// This property is normally used in a functional way, indicating the last time of authoring, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/authoredOn">pav:authoredOn</a>
    /// </summary>
    let authoredOn = _prefixId.prefix "authoredOn"
    /// <summary>
    ///   <para>rdfs:label : Contributed by</para>
    ///   <para>rdfs:comment : The resource was contributed to by the given agent.
    ///
    /// Specifies an agent that provided any sort of help in conceiving the work that is expressed by the digital artifact.
    ///
    /// Contributions can take many forms, of which PAV define the subproperties pav:authoredBy and pav:curatedBy; however other specific roles could also be specified by pav:contributedBy or custom subproperties, such as illustrating, investigating or managing the underlying data source. Contributions can additionally be expressed in detail using prov:qualifiedAttribution and prov:hadRole.
    ///
    /// Note that pav:contributedBy identifies only agents that contributed to the work, knowledge or intellectual property, and not agents that made the digital artifact or representation (pav:createdBy), thus the considerations for software agents is similar to for pav:authoredBy and pav:curatedBy.
    ///
    /// pav:contributedBy is more specific than its superproperty dct:contributor - which might or might not be interpreted to also cover contributions to making the representation of the artifact.
    ///
    ///
    /// The date of contribution can be expressed using pav:contributedOn - note however in the case of multiple contributors that there is no relationship in PAV identifying which agent contributed when or what. If capturing such lineage is desired, it should be additionally expressed using PROV relationships like prov:qualifiedAttribution or prov:wasGeneratedBy.</para>
    ///   <a href="http://purl.org/pav/contributedBy">pav:contributedBy</a>
    /// </summary>
    let contributedBy = _prefixId.prefix "contributedBy"
    /// <summary>
    ///   <para>rdfs:label : Contributed on</para>
    ///   <para>rdfs:comment : The date this resource was contributed to.
    ///
    /// pav:contributedBy provides the agent(s) that contributed.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/contributedOn">pav:contributedOn</a>
    /// </summary>
    let contributedOn = _prefixId.prefix "contributedOn"
    /// <summary>
    ///   <para>rdfs:label : Created at</para>
    ///   <para>rdfs:comment : The geo-location of the agents when creating the resource (pav:createdBy). For instance  a photographer takes a picture of the Eiffel Tower while standing in front of it.</para>
    ///   <a href="http://purl.org/pav/createdAt">pav:createdAt</a>
    /// </summary>
    let createdAt = _prefixId.prefix "createdAt"
    /// <summary>
    ///   <para>rdfs:comment : An agent primary responsible for making the digital artifact or resource representation.
    ///
    /// This property is distinct from forming the content, which is indicated with pav:contributedBy or its subproperties; pav:authoredBy, which identifies who authored the knowledge expressed by this resource; and pav:curatedBy, which identifies who curated the knowledge into its current form.
    ///
    /// pav:createdBy is more specific than its superproperty dct:creator - which might or might not be interpreted to cover this creator.
    ///
    /// For instance, the author wrote 'this species has bigger wings than normal' in his log book. The curator, going through the log book and identifying important knowledge, formalizes this as 'locus perculus has wingspan &gt; 0.5m'. The creator enters this knowledge as a digital resource in the knowledge system, thus creating the digital artifact (say as JSON, RDF, XML or HTML).
    ///
    /// A different example is a news article. pav:authoredBy indicates the journalist who wrote the article. pav:contributedBy can indicate the artist who added an illustration. pav:curatedBy can indicate the editor who made the article conform to the news paper's style. pav:createdBy can indicate who put the article on the web site.
    ///
    /// The software tool used by the creator to make the digital resource (say Protege, Wordpress or OpenOffice) can be indicated with pav:createdWith.
    ///
    /// The date the digital resource was created can be indicated with pav:createdOn.
    ///
    /// The location the agent was at when creating the digital resource can be made using pav:createdAt.</para>
    ///   <para>rdfs:label : Created by</para>
    ///   <a href="http://purl.org/pav/createdBy">pav:createdBy</a>
    /// </summary>
    let createdBy = _prefixId.prefix "createdBy"
    /// <summary>
    ///   <para>rdfs:label : Created on</para>
    ///   <para>rdfs:comment : The date of creation of the resource representation.
    ///
    /// The agents responsible can be indicated with pav:createdBy.
    ///
    /// This property is normally used in a functional way, indicating the time of creation, although PAV does not formally restrict this. pav:lastUpdateOn can be used to indicate minor updates that did not affect the creating date.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/createdOn">pav:createdOn</a>
    /// </summary>
    let createdOn = _prefixId.prefix "createdOn"
    /// <summary>
    ///   <para>rdfs:label : Created with</para>
    ///   <para>rdfs:comment : The software/tool used by the creator (pav:createdBy) when making the digital resource, for instance a word processor or an annotation tool. A more independent software agent that creates the resource without direct interaction by a human creator should instead should instead by indicated using pav:createdBy.
    /// </para>
    ///   <a href="http://purl.org/pav/createdWith">pav:createdWith</a>
    /// </summary>
    let createdWith = _prefixId.prefix "createdWith"
    /// <summary>
    ///   <para>rdfs:label : Curated by</para>
    ///   <para>rdfs:comment : Specifies an agent specialist responsible for shaping the expression in an appropriate format. Often the primary agent responsible for ensuring the quality of the representation.
    ///
    /// The curator may be different from the author (pav:authoredBy) and creator of the digital resource (pav:createdBy).
    ///
    /// The curator may in some cases be a software agent, for instance text mining software which adds hyperlinks for recognized genome names.
    ///
    /// The date of curating can be expressed using pav:curatedOn - note however in the case of multiple curators that there is no relationship in PAV identifying which agent contributed when or what. If capturing such lineage is desired, it should be additionally expressed using PROV relationships like prov:qualifiedAttribution or prov:wasGeneratedBy.</para>
    ///   <a href="http://purl.org/pav/curatedBy">pav:curatedBy</a>
    /// </summary>
    let curatedBy = _prefixId.prefix "curatedBy"
    /// <summary>
    ///   <para>rdfs:label : Curated on</para>
    ///   <para>rdfs:comment : The date this resource was curated.
    ///
    /// pav:curatedBy gives the agent(s) that performed the curation.
    ///
    /// This property is normally used in a functional way, indicating the last curation date, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/curatedOn">pav:curatedOn</a>
    /// </summary>
    let curatedOn = _prefixId.prefix "curatedOn"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Curates</para>
    ///   <para>rdfs:comment : Provided for backwards compatibility. Use instead the inverse pav:curatedBy.</para>
    ///   <a href="http://purl.org/pav/curates">pav:curates</a>
    /// </summary>
    let curates = _prefixId.prefix "curates"
    /// <summary>
    ///   <para>rdfs:label : Derived from</para>
    ///   <para>rdfs:comment : Derived from a different resource.
    ///
    /// Derivation conserns itself with derived knowledge. If this resource has the same content as the other resource, but has simply been transcribed to fit a different model (like XML -&gt; RDF or SQL -&gt; CVS), use pav:importedFrom. If a resource was simply retrieved, use pav:retrievedFrom. If the content has however been further refined or modified, pav:derivedFrom should be used.
    ///
    /// Details about who performed the derivation (e.g. who did the refining or modifications) may be indicated with pav:contributedBy and its subproperties.
    /// </para>
    ///   <a href="http://purl.org/pav/derivedFrom">pav:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    let doc = _prefixId.prefix "doc"
    /// <summary>
    ///   <para>rdfs:label : Has current version</para>
    ///   <para>rdfs:comment : This resource has a more specific, versioned resource with equivalent content.
    ///
    /// This property is intended for relating a non-versioned or abstract resource to a single snapshot that can be used as a permalink to indicate the current version of the content.
    ///
    /// For instance, if today is 2013-12-25, then a News page can indicate a corresponding snapshot resource which will refer to the news as they were of 2013-12-25.
    ///
    ///     &lt;http://news.example.com/&gt; pav:hasCurrentVersion &lt;http://news.example.com/2013-12-25/&gt; .
    ///
    /// "Equivalent content" is a loose definition, for instance the snapshot resource might include additional information to indicate it is a snapshot, and is not required to be immutable.
    ///
    /// Other versioned resources indicating the content at earlier times MAY be indicated with the superproperty pav:hasVersion, one of which MAY be related to the current version using pav:hasCurrentVersion:
    ///
    ///     &lt;http://news.example.com/2013-12-25/&gt; pav:previousVersion &lt;http://news.example.com/2013-12-24/&gt; .
    ///     &lt;http://news.example.com/&gt; pav:hasVersion &lt;http://news.example.com/2013-12-23/&gt; .
    ///
    /// Note that it might be confusing to also indicate pav:previousVersion from a resource that has hasCurrentVersion relations, as such a resource is intended to be a long-living "unversioned" resource. The PAV ontology does however not formally restrict this, to cater for more complex scenarios with multiple abstraction levels.
    ///
    /// Similarly, it would normally be incorrect to indicate a pav:hasCurrentVersion from an older version; instead the current version would be found by finding the non-versioned resource that the particular resource is a version of, and then its current version.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.</para>
    ///   <a href="http://purl.org/pav/hasCurrentVersion">pav:hasCurrentVersion</a>
    /// </summary>
    let hasCurrentVersion = _prefixId.prefix "hasCurrentVersion"
    /// <summary>
    ///   <para>rdfs:label : Has earlier version</para>
    ///   <para>rdfs:comment : This versioned resource has an earlier version.
    ///
    /// Any earlier version of this resource can be indicated with pav:hasEarlierVersion, e.g.:
    ///
    /// &lt;http://example.com/v4&gt; pav:hasEarlierVersion &lt;http://example.com/v2&gt; ;
    ///     pav:hasEarlierVersion &lt;http://example.com/v1&gt; .
    ///
    ///
    /// The subproperty pav:previousVersion SHOULD be used if the earlier version is the direct ancestor of this version.
    ///
    /// &lt;http://example.com/v4&gt; pav:previousVersion &lt;http://example.com/v3&gt; .
    ///
    ///
    /// This property is transitive, so it should not be necessary to repeat the earlier versions of an earlier version. A chain of previous versions can be declared using the subproperty pav:previousVersion, implying that the previous previous version is also an earlier version. It might however still be useful to declare an earlier version explicitly, for instance because it is an earlier version of high relevance or because the complete chain of pav:previousVersion is not available.
    ///
    ///
    /// To indicate that this version is a snapshot of a more general, non-versioned resource, e.g. "Weather Today" vs. "Weather Today on 2013-12-07", see pav:hasVersion.^^xsd:string</para>
    ///   <a href="http://purl.org/pav/hasEarlierVersion">pav:hasEarlierVersion</a>
    /// </summary>
    let hasEarlierVersion = _prefixId.prefix "hasEarlierVersion"
    /// <summary>
    ///   <para>rdfs:label : Has version</para>
    ///   <para>rdfs:comment : This resource has a more specific, versioned resource.
    ///
    /// This property is intended for relating a non-versioned or abstract resource to several versioned resources, e.g. snapshots. For instance, if there are two snapshots of the News page, made on 23rd and 24th of December, then:
    ///
    ///     &lt;http://news.example.com/&gt; pav:hasVersion &lt;http://news.example.com/2013-12-23/&gt; ;
    ///         pav:hasVersion &lt;http://news.example.com/2013-12-24/&gt; .
    ///
    /// If one of the versions has somewhat the equivalent content to this resource (e.g. can be used as a permalink for this resource), then it should instead be indicated with the subproperty pav:hasCurrentVersion:
    ///
    ///     &lt;http://news.example.com/&gt; pav:hasCurrentVersion &lt;http://news.example.com/2013-12-25/&gt; .
    ///
    /// To order the versions, use pav:previousVersion:
    ///
    ///     &lt;http://news.example.com/2013-12-25/&gt; pav:previousVersion &lt;http://news.example.com/2013-12-24/&gt; .
    ///     &lt;http://news.example.com/2013-12-24/&gt; pav:previousVersion &lt;http://news.example.com/2013-12-23/&gt; .
    ///
    /// Note that it might be confusing to also indicate pav:previousVersion from a resource that has pav:hasVersion relations, as such a resource is intended to be a long-living "unversioned" resource. The PAV ontology does however not formally restrict this, to cater for more complex scenarios with multiple abstraction levels.
    ///
    /// pav:hasVersion is a subproperty of dcterms:hasVersion to more strongly define this hierarchical pattern. It is therefore also a subproperty of pav:generalizationOf (inverse of prov:specializationOf).
    ///
    /// To indicate the existence of other, non-hierarchical kind of editions and adaptations of this resource that are not versioned snapshots (e.g. Powerpoint slides has a video recording version), use instead dcterms:hasVersion or prov:alternateOf.</para>
    ///   <a href="http://purl.org/pav/hasVersion">pav:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    let home = _prefixId.prefix "home"
    /// <summary>
    ///   <para>rdfs:label : Imported by</para>
    ///   <para>rdfs:comment : An entity responsible for importing the data.
    ///
    /// The importer is usually a software entity which has done the transcription from the original source.
    ///
    /// Note that pav:importedBy may overlap with pav:createdWith.
    ///
    /// The source for the import should be given with pav:importedFrom. The time of the import should be given with pav:importedOn.
    ///
    /// See pav:importedFrom for a discussion of import vs. retrieve vs. derived.</para>
    ///   <a href="http://purl.org/pav/importedBy">pav:importedBy</a>
    /// </summary>
    let importedBy = _prefixId.prefix "importedBy"
    /// <summary>
    ///   <para>rdfs:comment : The original source of imported information.
    ///
    /// Import means that the content has been preserved, but transcribed somehow, for instance to fit a different representation model by converting formats. Examples of import are when the original was JSON and the current resource is RDF, or where the original was an document scan, and this resource is the plain text found through OCR.
    ///
    /// The imported resource does not have to be complete, but should be consistent with the knowledge conveyed by the original resource.
    ///
    /// If additional knowledge has been contributed, pav:derivedFrom would be more appropriate.
    ///
    /// If the resource has been copied verbatim from the original representation (e.g. downloaded), use pav:retrievedFrom.
    ///
    /// To indicate which agent(s) performed the import, use pav:importedBy. Use pav:importedOn to indicate when it happened. </para>
    ///   <para>rdfs:label : Imported from</para>
    ///   <a href="http://purl.org/pav/importedFrom">pav:importedFrom</a>
    /// </summary>
    let importedFrom = _prefixId.prefix "importedFrom"
    /// <summary>
    ///   <para>rdfs:label : Imported on</para>
    ///   <para>rdfs:comment : The date this resource was imported from a source (pav:importedFrom).
    ///
    /// Note that pav:importedOn may overlap with pav:createdOn, but in cases where they differ, the import time indicates the time of the retrieval and transcription of the original source, while the creation time indicates when the final resource was made, for instance after user approval.
    ///
    /// This property is normally used in a functional way, indicating the first import date, although PAV does not formally restrict this. If the resource is later reimported, this should instead be indicated with pav:lastRefreshedOn.
    ///
    /// The source of the import should be given with pav:importedFrom. The agent that performed the import should be given with pav:importedBy.
    ///
    /// See pav:importedFrom for a discussion about import vs. retrieval.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/importedOn">pav:importedOn</a>
    /// </summary>
    let importedOn = _prefixId.prefix "importedOn"
    /// <summary>
    ///   <para>rdfs:label : Last refreshed on</para>
    ///   <para>rdfs:comment : The date of the last re-import of the resource. This property is used in addition to pav:importedOn if this version has been updated due to a re-import. If the re-import created a new resource rather than refreshing an existing resource, then instead use pav:importedOn together with pav:previousVersion.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/lastRefreshedOn">pav:lastRefreshedOn</a>
    /// </summary>
    let lastRefreshedOn = _prefixId.prefix "lastRefreshedOn"
    /// <summary>
    ///   <para>rdfs:label : Last updated on</para>
    ///   <para>rdfs:comment : The date of the last update of the resource. An update is a change which did not warrant making a new resource related using pav:previousVersion, for instance correcting a spelling mistake.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/lastUpdateOn">pav:lastUpdateOn</a>
    /// </summary>
    let lastUpdateOn = _prefixId.prefix "lastUpdateOn"
    /// <summary>
    ///   <para>rdfs:comment : The previous version of a resource in a lineage. For instance a news article updated to correct factual information would point to the previous version of the article with pav:previousVersion. If however the content has significantly changed so that the two resources no longer share lineage (say a new article that talks about the same facts), they can instead be related using pav:derivedFrom.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this. Earlier versions which are not direct ancestors of this resource may instead be provided using the superproperty pav:hasEarlierVersion.
    ///
    /// A version number of this resource can be provided using the data property pav:version.
    ///
    /// To indicate that this version is a snapshot of a more general, non-versioned resource, e.g. "Weather Today" vs. "Weather Today on 2013-12-07", see pav:hasVersion.
    ///
    /// Note that it might be confusing to indicate pav:previousVersion from a resource that also has pav:hasVersion or pav:hasCurrentVersion relations, as such resources are intended to be a long-living and "unversioned", while pav:previousVersion is intended for use between permalink-like "snapshots" arranged in a linear history.  </para>
    ///   <para>rdfs:label : Previous version</para>
    ///   <a href="http://purl.org/pav/previousVersion">pav:previousVersion</a>
    /// </summary>
    let previousVersion = _prefixId.prefix "previousVersion"
    let ``provenance.ttl`` = _prefixId.prefix "provenance.ttl"
    /// <summary>
    ///   <para>rdfs:label : Provided by</para>
    ///   <para>rdfs:comment : The original provider of the encoded information (e.g. PubMed, UniProt, Science Commons).
    ///
    /// The provider might not coincide with the dct:publisher, which would describe the current publisher of the resource. For instance if the resource was retrieved, imported or derived from a source, that source was published by the original provider. pav:providedBy provides a shortcut to indicate that original provider on the new resource.  </para>
    ///   <a href="http://purl.org/pav/providedBy">pav:providedBy</a>
    /// </summary>
    let providedBy = _prefixId.prefix "providedBy"
    /// <summary>
    ///   <para>rdfs:label : Retrieved by</para>
    ///   <para>rdfs:comment : An entity responsible for retrieving the data from an external source.
    ///
    /// The retrieving agent is usually a software entity, which has done the retrieval from the original source without performing any transcription.
    ///
    /// The source that was retrieved should be given with pav:retrievedFrom. The time of the retrieval should be indicated using pav:retrievedOn.
    ///
    /// See pav:importedFrom for a discussion of import vs. retrieve vs. derived.</para>
    ///   <a href="http://purl.org/pav/retrievedBy">pav:retrievedBy</a>
    /// </summary>
    let retrievedBy = _prefixId.prefix "retrievedBy"
    /// <summary>
    ///   <para>rdfs:label : Retrieved from</para>
    ///   <para>rdfs:comment : The URI where a resource has been retrieved from.
    ///
    /// The retrieving agent is usually a software entity, which has done the retrieval from the original source without performing any transcription.
    ///
    /// Retrieval indicates that this resource has the same representation as the original resource. If the resource has been somewhat transformed, use pav:importedFrom instead.
    ///
    /// The time of the retrieval should be indicated using pav:retrievedOn. The agent may be indicated with pav:retrievedBy.</para>
    ///   <a href="http://purl.org/pav/retrievedFrom">pav:retrievedFrom</a>
    /// </summary>
    let retrievedFrom = _prefixId.prefix "retrievedFrom"
    /// <summary>
    ///   <para>rdfs:label : Retrieved on</para>
    ///   <para>rdfs:comment : The date the source for this resource was retrieved.
    ///
    /// The source that was retrieved should be indicated with pav:retrievedFrom. The agent that performed the retrieval may be specified with pav:retrievedBy.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/retrievedOn">pav:retrievedOn</a>
    /// </summary>
    let retrievedOn = _prefixId.prefix "retrievedOn"
    /// <summary>
    ///   <para>rdfs:label : Source accessed at</para>
    ///   <para>rdfs:comment : The resource is related to a given source which was accessed or consulted (but not retrieved, imported or derived from). This access can be detailed with pav:sourceAccessedBy and pav:sourceAccessedOn.
    ///
    /// For instance, a curator (pav:curatedBy) might have consulted figures in a published paper to confirm that a dataset was correctly pav:importedFrom the paper's supplementary CSV file.
    ///
    /// Another example: I can access the page for tomorrow weather in Boston (http://www.weather.com/weather/tomorrow/Boston+MA+02143)  and I can blog ‘tomorrow is going to be nice’. The source does not make any claims about the nice weather, that is my interpretation; therefore the blog post has pav:sourceAccessedAt the weather page. </para>
    ///   <a href="http://purl.org/pav/sourceAccessedAt">pav:sourceAccessedAt</a>
    /// </summary>
    let sourceAccessedAt = _prefixId.prefix "sourceAccessedAt"
    /// <summary>
    ///   <para>rdfs:label : Source accessed by</para>
    ///   <para>rdfs:comment : The resource is related to a source which was accessed or consulted
    /// by the given agent. The source(s) should be specified using pav:sourceAccessedAt, and the time with pav:sourceAccessedOn.
    ///
    /// For instance, the given agent could be a curator (also pav:curatedBy) which consulted figures in a published paper to confirm that a dataset was correctly pav:importedFrom the paper's supplementary CSV file.</para>
    ///   <a href="http://purl.org/pav/sourceAccessedBy">pav:sourceAccessedBy</a>
    /// </summary>
    let sourceAccessedBy = _prefixId.prefix "sourceAccessedBy"
    /// <summary>
    ///   <para>rdfs:comment : The resource is related to a source which was originally accessed or consulted on the given date as part of creating or authoring the resource. The source(s) should be specified using pav:sourceAccessedAt.
    ///
    /// For instance, if the source accessed described the weather forecast for the next day, the time of source access can be crucial information.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this. If the source is subsequently checked again (say to verify validity), this should be indicated with pav:sourceLastAccessedOn.
    ///
    /// In the case multiple sources being accessed at different times or by different agents, PAV does not distinguish who accessed when what. If such details are required, they may be provided by additionally using prov:qualifiedInfluence.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <para>rdfs:label : Source accessed on</para>
    ///   <a href="http://purl.org/pav/sourceAccessedOn">pav:sourceAccessedOn</a>
    /// </summary>
    let sourceAccessedOn = _prefixId.prefix "sourceAccessedOn"
    /// <summary>
    ///   <para>rdfs:label : Source last accessed on</para>
    ///   <para>rdfs:comment : The resource is related to a source which was last accessed or consulted on the given date. The source(s) should be specified using pav:sourceAccessedAt. Usage of this property indicates that the source has been checked previously, which the initial time should be indicated with pav:sourceAccessedOn.
    ///
    /// This property can be useful together with pav:lastRefreshedOn or pav:lastUpdateOn in order to indicate a re-import or update, but could also be used alone, for instance when a source was simply verified and no further action was taken for the resource.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime.</para>
    ///   <a href="http://purl.org/pav/sourceLastAccessedOn">pav:sourceLastAccessedOn</a>
    /// </summary>
    let sourceLastAccessedOn = _prefixId.prefix "sourceLastAccessedOn"
    /// <summary>
    ///   <para>rdfs:label : Version</para>
    ///   <para>rdfs:comment : The version number of a resource. This is a freetext string, typical values are "1.5" or "21". The URI identifying the previous version can be provided using prov:previousVersion.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.^^xsd:string</para>
    ///   <a href="http://purl.org/pav/version">pav:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"

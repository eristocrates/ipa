namespace http.purl.org.pav.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pav =
    let _namespace_iri = Namespace_Iri pav |> NamespaceIRI
    /// <summary>
    ///   <para>pav:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"PAV is a lightweight ontology for tracking Provenance, Authoring and Versioning. PAV specializes the W3C provenance ontology PROV-O in order to describe authorship, curation and digital creation of online resources.
    ///
    ///           This ontology describes the defined PAV properties and their usage. Note that PAV does not define any explicit classes or domain/ranges, as every property is meant to be used directly on the described online resource.
    ///
    ///           Cite as: Paolo Ciccarese, Stian Soiland-Reyes, Khalid Belhajjame, Alasdair JG Gray, Carole Goble, Tim Clark (2013): PAV ontology: provenance, authoring and versioning. Journal of biomedical semantics 4 (1), 37. doi:10.1186/2041-1480-4-37
    ///         "</para>
    /// labels<para>"Provenance, Authoring and Versioning (PAV)"</para></remarks>
    /// <seealso href="http://purl.org/pav/">http://purl.org/pav/</seealso>
    let _prefix_iri = Prefixed_Name(pav, "") |> PrefixedName
    /// <summary>
    ///   <para>pav:2.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/2.0/">http://purl.org/pav/2.0/</seealso>
    let ``_2.0/`` = Prefixed_Name(pav, "2.0/") |> PrefixedName
    /// <summary>
    ///   <para>pav:2.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/2.1">http://purl.org/pav/2.1</seealso>
    let ``_2.1`` = Prefixed_Name(pav, "2.1") |> PrefixedName
    /// <summary>
    ///   <para>pav:2.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/2.2">http://purl.org/pav/2.2</seealso>
    let ``_2.2`` = Prefixed_Name(pav, "2.2") |> PrefixedName
    /// <summary>
    ///   <para>pav:2.3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/2.3">http://purl.org/pav/2.3</seealso>
    let ``_2.3`` = Prefixed_Name(pav, "2.3") |> PrefixedName
    /// <summary>
    ///   <para>pav:authoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent that originated or gave existence to the work that is expressed by the digital resource.
    ///
    /// The author of the content of a resource may be different from the creator of the resource representation (although they are often the same). See pav:createdBy for a discussion.
    ///
    /// pav:authoredBy is more specific than its superproperty dct:creator - which might or might not be interpreted to also cover the creation of the representation of the artifact.
    ///
    /// The author is usually not a software agent (which would be indicated with pav:createdWith, pav:createdBy or pav:importedBy), unless the software actually authored the content itself; for instance an artificial intelligence algorithm which authored a piece of music or a machine learning algorithm that authored a classification of a tumor sample.
    ///
    /// The date of authoring can be expressed using pav:authoredOn - note however in the case of multiple authors that there is no relationship in PAV identifying which agent contributed when or what. If capturing such lineage is desired, it should be additionally expressed using PROV relationships like prov:qualifiedAttribution or prov:wasGeneratedBy."</para>
    ///   <para>"An agent that originated or gave existence to the work that is expressed by the digital resource."</para>
    /// labels<para>"Authored by"</para><para>"authored by"</para></remarks>
    /// <seealso href="http://purl.org/pav/authoredBy">http://purl.org/pav/authoredBy</seealso>
    let authoredBy = Prefixed_Name(pav, "authoredBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:authoredOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date this resource was authored.
    ///
    /// pav:authoredBy gives the authoring agent.
    ///
    /// Note that pav:authoredOn is different from pav:createdOn, although they are often the same. See pav:createdBy for a discussion.
    ///
    /// This property is normally used in a functional way, indicating the last time of authoring, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    ///   <para>"The date this resource was authored."</para>
    /// labels<para>"authored on"</para><para>"Authored on"</para></remarks>
    /// <seealso href="http://purl.org/pav/authoredOn">http://purl.org/pav/authoredOn</seealso>
    let authoredOn = Prefixed_Name(pav, "authoredOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:authoring/2.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/authoring/2.0/">http://purl.org/pav/authoring/2.0/</seealso>
    let ``authoring/2.0/`` = Prefixed_Name(pav, "authoring/2.0/") |> PrefixedName
    /// <summary>
    ///   <para>pav:contributedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The resource was contributed to by the given agent."</para>
    ///   <para>"The resource was contributed to by the given agent.
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
    /// The date of contribution can be expressed using pav:contributedOn - note however in the case of multiple contributors that there is no relationship in PAV identifying which agent contributed when or what. If capturing such lineage is desired, it should be additionally expressed using PROV relationships like prov:qualifiedAttribution or prov:wasGeneratedBy."</para>
    /// labels<para>"Contributed by"</para><para>"contributed by"</para></remarks>
    /// <seealso href="http://purl.org/pav/contributedBy">http://purl.org/pav/contributedBy</seealso>
    let contributedBy = Prefixed_Name(pav, "contributedBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:contributedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date this resource was contributed to.
    ///
    /// pav:contributedBy provides the agent(s) that contributed.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    ///   <para>"The date this resource was contributed to."</para>
    /// labels<para>"Contributed on"</para><para>"contributed on"</para></remarks>
    /// <seealso href="http://purl.org/pav/contributedOn">http://purl.org/pav/contributedOn</seealso>
    let contributedOn = Prefixed_Name(pav, "contributedOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:createdAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The geo-location of the agents when creating the resource (pav:createdBy). For instance  a photographer takes a picture of the Eiffel Tower while standing in front of it."</para>
    /// labels<para>"Created at"</para></remarks>
    /// <seealso href="http://purl.org/pav/createdAt">http://purl.org/pav/createdAt</seealso>
    let createdAt = Prefixed_Name(pav, "createdAt") |> PrefixedName
    /// <summary>
    ///   <para>pav:createdBY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent primary responsible for making the digital artifact or resource representation."</para>
    /// labels<para>"created bY"</para></remarks>
    /// <seealso href="http://purl.org/pav/createdBY">http://purl.org/pav/createdBY</seealso>
    let createdBY = Prefixed_Name(pav, "createdBY") |> PrefixedName
    /// <summary>
    ///   <para>pav:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An agent primary responsible for making the digital artifact or resource representation.
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
    /// The location the agent was at when creating the digital resource can be made using pav:createdAt."</para>
    /// labels<para>"Created by"</para></remarks>
    /// <seealso href="http://purl.org/pav/createdBy">http://purl.org/pav/createdBy</seealso>
    let createdBy = Prefixed_Name(pav, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:createdOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date of creation of the resource representation."</para>
    ///   <para>"The date of creation of the resource representation.
    ///
    /// The agents responsible can be indicated with pav:createdBy.
    ///
    /// This property is normally used in a functional way, indicating the time of creation, although PAV does not formally restrict this. pav:lastUpdateOn can be used to indicate minor updates that did not affect the creating date.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Created on"</para><para>"created on"</para></remarks>
    /// <seealso href="http://purl.org/pav/createdOn">http://purl.org/pav/createdOn</seealso>
    let createdOn = Prefixed_Name(pav, "createdOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:createdWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The software/tool used by the creator (pav:createdBy) when making the digital resource, for instance a word processor or an annotation tool. A more independent software agent that creates the resource without direct interaction by a human creator should instead be indicated using pav:createdBy."</para>
    ///   <para>"The software/tool used by the creator (pav:createdBy) when making the digital resource, for instance a word processor or an annotation tool. A more independent software agent that creates the resource without direct interaction by a human creator should instead should instead by indicated using pav:createdBy.
    /// "</para>
    /// labels<para>"created with"</para><para>"Created with"</para></remarks>
    /// <seealso href="http://purl.org/pav/createdWith">http://purl.org/pav/createdWith</seealso>
    let createdWith = Prefixed_Name(pav, "createdWith") |> PrefixedName
    /// <summary>
    ///   <para>pav:curatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies an agent specialist responsible for shaping the expression in an appropriate format. Often the primary agent responsible for ensuring the quality of the representation.
    ///
    /// The curator may be different from the author (pav:authoredBy) and creator of the digital resource (pav:createdBy).
    ///
    /// The curator may in some cases be a software agent, for instance text mining software which adds hyperlinks for recognized genome names.
    ///
    /// The date of curating can be expressed using pav:curatedOn - note however in the case of multiple curators that there is no relationship in PAV identifying which agent contributed when or what. If capturing such lineage is desired, it should be additionally expressed using PROV relationships like prov:qualifiedAttribution or prov:wasGeneratedBy."</para>
    ///   <para>"Specifies an agent specialist responsible for shaping the expression in an appropriate format. Often the primary agent responsible for ensuring the quality of the representation."</para>
    /// labels<para>"curated by"</para><para>"Curated by"</para></remarks>
    /// <seealso href="http://purl.org/pav/curatedBy">http://purl.org/pav/curatedBy</seealso>
    let curatedBy = Prefixed_Name(pav, "curatedBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:curatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date this resource was curated."</para>
    ///   <para>"The date this resource was curated.
    ///
    /// pav:curatedBy gives the agent(s) that performed the curation.
    ///
    /// This property is normally used in a functional way, indicating the last curation date, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Curated on"</para><para>"curated on"</para></remarks>
    /// <seealso href="http://purl.org/pav/curatedOn">http://purl.org/pav/curatedOn</seealso>
    let curatedOn = Prefixed_Name(pav, "curatedOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:curates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provided for backwards compatibility. Use instead the inverse pav:curatedBy."</para>
    /// labels<para>"Curates"</para><para>"curates"</para></remarks>
    /// <seealso href="http://purl.org/pav/curates">http://purl.org/pav/curates</seealso>
    let curates = Prefixed_Name(pav, "curates") |> PrefixedName
    /// <summary>
    ///   <para>pav:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Derived from a different resource."</para>
    ///   <para>"Derived from a different resource.
    ///
    /// Derivation conserns itself with derived knowledge. If this resource has the same content as the other resource, but has simply been transcribed to fit a different model (like XML -&gt; RDF or SQL -&gt; CVS), use pav:importedFrom. If a resource was simply retrieved, use pav:retrievedFrom. If the content has however been further refined or modified, pav:derivedFrom should be used.
    ///
    /// Details about who performed the derivation (e.g. who did the refining or modifications) may be indicated with pav:contributedBy and its subproperties.
    /// "</para>
    /// labels<para>"derived from"</para><para>"Derived from"</para></remarks>
    /// <seealso href="http://purl.org/pav/derivedFrom">http://purl.org/pav/derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(pav, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>pav:doc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/doc">http://purl.org/pav/doc</seealso>
    let doc = Prefixed_Name(pav, "doc") |> PrefixedName
    /// <summary>
    ///   <para>pav:hasCurrentVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This resource has a more specific, versioned resource with equivalent content."</para>
    ///   <para>"This resource has a more specific, versioned resource with equivalent content.
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
    /// This property is normally used in a functional way, although PAV does not formally restrict this."</para>
    /// labels<para>"has current version"</para><para>"Has current version"</para></remarks>
    /// <seealso href="http://purl.org/pav/hasCurrentVersion">http://purl.org/pav/hasCurrentVersion</seealso>
    let hasCurrentVersion = Prefixed_Name(pav, "hasCurrentVersion") |> PrefixedName
    /// <summary>
    ///   <para>pav:hasEarlierVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"This versioned resource has an earlier version.
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
    /// To indicate that this version is a snapshot of a more general, non-versioned resource, e.g. "Weather Today" vs. "Weather Today on 2013-12-07", see pav:hasVersion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has earlier version"</para></remarks>
    /// <seealso href="http://purl.org/pav/hasEarlierVersion">http://purl.org/pav/hasEarlierVersion</seealso>
    let hasEarlierVersion = Prefixed_Name(pav, "hasEarlierVersion") |> PrefixedName
    /// <summary>
    ///   <para>pav:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This resource has a more specific, versioned resource.
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
    /// To indicate the existence of other, non-hierarchical kind of editions and adaptations of this resource that are not versioned snapshots (e.g. Powerpoint slides has a video recording version), use instead dcterms:hasVersion or prov:alternateOf."</para>
    ///   <para>"This resource has a more specific, versioned resource. This property is intended for relating a non-versioned or abstract resource to several versioned resources, e.g. snapshots. For instance, if there are two snapshots of the News page, made on 23rd and 24th of December, then: &lt;http://news.example.com/&gt; pav:hasVersion &lt;http://news.example.com/2013-12-23/&gt; ; pav:hasVersion &lt;http://news.example.com/2013-12-24/&gt; . If one of the versions has somewhat the equivalent content to this resource (e.g. can be used as a permalink for this resource), then it should instead be indicated with the subproperty pav:hasCurrentVersion: &lt;http://news.example.com/&gt; pav:hasCurrentVersion &lt;http://news.example.com/2013-12-25 &gt; . To order the versions, use pav:previousVersion: &lt;http://news.example.com/2013-12-25/&gt; pav:previousVersion &lt;http://news.example.com 2013-12-24/&gt; . &lt;http://news.example.com/2013-12-24/&gt; pav:previousVersion &lt;http://news.example.com/2013-12-23/&gt; . Note that it might be confusing to also indicate pav:previousVersion from a resource that has pav:hasVersion relations, as such a resource is intended to be a long-living 'unversioned' resource. The PAV ontology does however not formally restrict this, to cater for more complex scenarios with multiple abstraction levels. pav:hasVersion is a subproperty of dcterms:hasVersion to more strongly define this hierarchical pattern. It is therefore also a subproperty of pav:generalizationOf (inverse of prov:specializationOf). To indicate the existence of other, non-hierarchical kind of editions and adaptations of this resource that are not versioned snapshots (e.g. Powerpoint slides has a video recording version), use instead dcterms:hasVersion or prov:alternateOf."</para>
    ///   <para>"This resource has a more specific, versioned resource."</para>
    /// labels<para>"has version"</para><para>"pav:hasVersion"</para><para>"Has version"</para></remarks>
    /// <seealso href="http://purl.org/pav/hasVersion">http://purl.org/pav/hasVersion</seealso>
    let hasVersion = Prefixed_Name(pav, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>pav:home</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/home">http://purl.org/pav/home</seealso>
    let home = Prefixed_Name(pav, "home") |> PrefixedName
    /// <summary>
    ///   <para>pav:importedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An entity responsible for importing the data.
    ///
    /// The importer is usually a software entity which has done the transcription from the original source.
    ///
    /// Note that pav:importedBy may overlap with pav:createdWith.
    ///
    /// The source for the import should be given with pav:importedFrom. The time of the import should be given with pav:importedOn.
    ///
    /// See pav:importedFrom for a discussion of import vs. retrieve vs. derived."</para>
    /// labels<para>"Imported by"</para></remarks>
    /// <seealso href="http://purl.org/pav/importedBy">http://purl.org/pav/importedBy</seealso>
    let importedBy = Prefixed_Name(pav, "importedBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:importedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The original source of imported information.
    ///
    /// Import means that the content has been preserved, but transcribed somehow, for instance to fit a different representation model by converting formats. Examples of import are when the original was JSON and the current resource is RDF, or where the original was an document scan, and this resource is the plain text found through OCR.
    ///
    /// The imported resource does not have to be complete, but should be consistent with the knowledge conveyed by the original resource.
    ///
    /// If additional knowledge has been contributed, pav:derivedFrom would be more appropriate.
    ///
    /// If the resource has been copied verbatim from the original representation (e.g. downloaded), use pav:retrievedFrom.
    ///
    /// To indicate which agent(s) performed the import, use pav:importedBy. Use pav:importedOn to indicate when it happened. "</para>
    /// labels<para>"Imported from"</para></remarks>
    /// <seealso href="http://purl.org/pav/importedFrom">http://purl.org/pav/importedFrom</seealso>
    let importedFrom = Prefixed_Name(pav, "importedFrom") |> PrefixedName
    /// <summary>
    ///   <para>pav:importedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date this resource was imported from a source (pav:importedFrom).
    ///
    /// Note that pav:importedOn may overlap with pav:createdOn, but in cases where they differ, the import time indicates the time of the retrieval and transcription of the original source, while the creation time indicates when the final resource was made, for instance after user approval.
    ///
    /// This property is normally used in a functional way, indicating the first import date, although PAV does not formally restrict this. If the resource is later reimported, this should instead be indicated with pav:lastRefreshedOn.
    ///
    /// The source of the import should be given with pav:importedFrom. The agent that performed the import should be given with pav:importedBy.
    ///
    /// See pav:importedFrom for a discussion about import vs. retrieval.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Imported on"</para></remarks>
    /// <seealso href="http://purl.org/pav/importedOn">http://purl.org/pav/importedOn</seealso>
    let importedOn = Prefixed_Name(pav, "importedOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:lastRefreshedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of the last re-import of the resource. This property is used in addition to pav:importedOn if this version has been updated due to a re-import. If the re-import created a new resource rather than refreshing an existing resource, then instead use pav:importedOn together with pav:previousVersion.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Last refreshed on"</para></remarks>
    /// <seealso href="http://purl.org/pav/lastRefreshedOn">http://purl.org/pav/lastRefreshedOn</seealso>
    let lastRefreshedOn = Prefixed_Name(pav, "lastRefreshedOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:lastUpdateOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of the last update of the resource. An update is a change which did not warrant making a new resource related using pav:previousVersion, for instance correcting a spelling mistake.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    ///   <para>"The date of the last update of the resource. An update is a change which did not warrant making a new resource related using pav:previousVersion, for instance correcting a spelling mistake."</para>
    /// labels<para>"last update on"</para><para>"Last updated on"</para></remarks>
    /// <seealso href="http://purl.org/pav/lastUpdateOn">http://purl.org/pav/lastUpdateOn</seealso>
    let lastUpdateOn = Prefixed_Name(pav, "lastUpdateOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:lastUpdatedOn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/lastUpdatedOn">http://purl.org/pav/lastUpdatedOn</seealso>
    let lastUpdatedOn = Prefixed_Name(pav, "lastUpdatedOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:previousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The previous version of a resource in a lineage. For instance a news article updated to correct factual information would point to the previous version of the article with pav:previousVersion. If however the content has significantly changed so that the two resources no longer share lineage (say a new article that talks about the same facts), they can instead be related using pav:derivedFrom. This property is normally used in a functional way, although PAV does not formally restrict this. Earlier versions which are not direct ancestors of this resource may instead be provided using the superproperty pav:hasEarlierVersion. A version number of this resource can be provided using the data property pav:version. To indicate that this version is a snapshot of a more general, non-versioned resource, e.g. 'Weather Today' vs. 'Weather Today on 2013-12-07', see pav:hasVersion. Note that it might be confusing to indicate pav:previousVersion from a resource that also has pav:hasVersion or pav:hasCurrentVersion relations, as such resources are intended to be a long-living and 'unversioned', while pav:previousVersion is intended for use between permalink-like 'snapshots' arranged in a linear history."</para>
    ///   <para>"The previous version of a resource in a lineage. For instance a news article updated to correct factual information would point to the previous version of the article with pav:previousVersion. If however the content has significantly changed so that the two resources no longer share lineage (say a new article that talks about the same facts), they can instead be related using pav:derivedFrom.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this. Earlier versions which are not direct ancestors of this resource may instead be provided using the superproperty pav:hasEarlierVersion.
    ///
    /// A version number of this resource can be provided using the data property pav:version.
    ///
    /// To indicate that this version is a snapshot of a more general, non-versioned resource, e.g. "Weather Today" vs. "Weather Today on 2013-12-07", see pav:hasVersion.
    ///
    /// Note that it might be confusing to indicate pav:previousVersion from a resource that also has pav:hasVersion or pav:hasCurrentVersion relations, as such resources are intended to be a long-living and "unversioned", while pav:previousVersion is intended for use between permalink-like "snapshots" arranged in a linear history.  "</para>
    /// labels<para>"Previous version"</para><para>"pav:previousVersion"</para></remarks>
    /// <seealso href="http://purl.org/pav/previousVersion">http://purl.org/pav/previousVersion</seealso>
    let previousVersion = Prefixed_Name(pav, "previousVersion") |> PrefixedName
    /// <summary>
    ///   <para>pav:provenance.ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/provenance.ttl">http://purl.org/pav/provenance.ttl</seealso>
    let ``provenance.ttl`` = Prefixed_Name(pav, "provenance.ttl") |> PrefixedName
    /// <summary>
    ///   <para>pav:provenance/2.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/provenance/2.0/">http://purl.org/pav/provenance/2.0/</seealso>
    let ``provenance/2.0/`` = Prefixed_Name(pav, "provenance/2.0/") |> PrefixedName
    /// <summary>
    ///   <para>pav:providedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The original provider of the encoded information (e.g. PubMed, UniProt, Science Commons).
    ///
    /// The provider might not coincide with the dct:publisher, which would describe the current publisher of the resource. For instance if the resource was retrieved, imported or derived from a source, that source was published by the original provider. pav:providedBy provides a shortcut to indicate that original provider on the new resource.  "</para>
    /// labels<para>"Provided by"</para></remarks>
    /// <seealso href="http://purl.org/pav/providedBy">http://purl.org/pav/providedBy</seealso>
    let providedBy = Prefixed_Name(pav, "providedBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:retrievedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An entity responsible for retrieving the data from an external source.
    ///
    /// The retrieving agent is usually a software entity, which has done the retrieval from the original source without performing any transcription.
    ///
    /// The source that was retrieved should be given with pav:retrievedFrom. The time of the retrieval should be indicated using pav:retrievedOn.
    ///
    /// See pav:importedFrom for a discussion of import vs. retrieve vs. derived."</para>
    /// labels<para>"Retrieved by"</para></remarks>
    /// <seealso href="http://purl.org/pav/retrievedBy">http://purl.org/pav/retrievedBy</seealso>
    let retrievedBy = Prefixed_Name(pav, "retrievedBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:retrievedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The URI where a resource has been retrieved from.
    ///
    /// The retrieving agent is usually a software entity, which has done the retrieval from the original source without performing any transcription.
    ///
    /// Retrieval indicates that this resource has the same representation as the original resource. If the resource has been somewhat transformed, use pav:importedFrom instead.
    ///
    /// The time of the retrieval should be indicated using pav:retrievedOn. The agent may be indicated with pav:retrievedBy."</para>
    /// labels<para>"Retrieved from"</para></remarks>
    /// <seealso href="http://purl.org/pav/retrievedFrom">http://purl.org/pav/retrievedFrom</seealso>
    let retrievedFrom = Prefixed_Name(pav, "retrievedFrom") |> PrefixedName
    /// <summary>
    ///   <para>pav:retrievedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date the source for this resource was retrieved.
    ///
    /// The source that was retrieved should be indicated with pav:retrievedFrom. The agent that performed the retrieval may be specified with pav:retrievedBy.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Retrieved on"</para></remarks>
    /// <seealso href="http://purl.org/pav/retrievedOn">http://purl.org/pav/retrievedOn</seealso>
    let retrievedOn = Prefixed_Name(pav, "retrievedOn") |> PrefixedName
    /// <summary>
    ///   <para>pav:sourceAccessedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The resource is related to a given source which was accessed or consulted (but not retrieved, imported or derived from). This access can be detailed with pav:sourceAccessedBy and pav:sourceAccessedOn.
    ///
    /// For instance, a curator (pav:curatedBy) might have consulted figures in a published paper to confirm that a dataset was correctly pav:importedFrom the paper's supplementary CSV file.
    ///
    /// Another example: I can access the page for tomorrow weather in Boston (http://www.weather.com/weather/tomorrow/Boston+MA+02143)  and I can blog ‘tomorrow is going to be nice’. The source does not make any claims about the nice weather, that is my interpretation; therefore the blog post has pav:sourceAccessedAt the weather page. "</para>
    /// labels<para>"Source accessed at"</para></remarks>
    /// <seealso href="http://purl.org/pav/sourceAccessedAt">http://purl.org/pav/sourceAccessedAt</seealso>
    let sourceAccessedAt = Prefixed_Name(pav, "sourceAccessedAt") |> PrefixedName
    /// <summary>
    ///   <para>pav:sourceAccessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The resource is related to a source which was accessed or consulted
    /// by the given agent. The source(s) should be specified using pav:sourceAccessedAt, and the time with pav:sourceAccessedOn.
    ///
    /// For instance, the given agent could be a curator (also pav:curatedBy) which consulted figures in a published paper to confirm that a dataset was correctly pav:importedFrom the paper's supplementary CSV file."</para>
    /// labels<para>"Source accessed by"</para></remarks>
    /// <seealso href="http://purl.org/pav/sourceAccessedBy">http://purl.org/pav/sourceAccessedBy</seealso>
    let sourceAccessedBy = Prefixed_Name(pav, "sourceAccessedBy") |> PrefixedName
    /// <summary>
    ///   <para>pav:sourceAccessedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The resource is related to a source which was originally accessed or consulted on the given date as part of creating or authoring the resource. The source(s) should be specified using pav:sourceAccessedAt.
    ///
    /// For instance, if the source accessed described the weather forecast for the next day, the time of source access can be crucial information.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this. If the source is subsequently checked again (say to verify validity), this should be indicated with pav:sourceLastAccessedOn.
    ///
    /// In the case multiple sources being accessed at different times or by different agents, PAV does not distinguish who accessed when what. If such details are required, they may be provided by additionally using prov:qualifiedInfluence.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Source accessed on"</para></remarks>
    /// <seealso href="http://purl.org/pav/sourceAccessedOn">http://purl.org/pav/sourceAccessedOn</seealso>
    let sourceAccessedOn = Prefixed_Name(pav, "sourceAccessedOn") |> PrefixedName

    /// <summary>
    ///   <para>pav:sourceLastAccessedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The resource is related to a source which was last accessed or consulted on the given date. The source(s) should be specified using pav:sourceAccessedAt. Usage of this property indicates that the source has been checked previously, which the initial time should be indicated with pav:sourceAccessedOn.
    ///
    /// This property can be useful together with pav:lastRefreshedOn or pav:lastUpdateOn in order to indicate a re-import or update, but could also be used alone, for instance when a source was simply verified and no further action was taken for the resource.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this.
    ///
    /// The value is of type xsd:dateTime, for instance "2013-03-26T14:49:00+01:00"^^xsd:dateTime. The timezone information (Z for UTC, +01:00 for UTC+1, etc) SHOULD be included unless unknown. If the time (or parts of time) is unknown, use 00:00:00Z. If the day/month is unknown, use 01-01, for instance, if we only know September 1983, then use "1983-09-01T00:00:00Z"^^xsd:dateTime."</para>
    /// labels<para>"Source last accessed on"</para></remarks>
    /// <seealso href="http://purl.org/pav/sourceLastAccessedOn">http://purl.org/pav/sourceLastAccessedOn</seealso>
    let sourceLastAccessedOn =
        Prefixed_Name(pav, "sourceLastAccessedOn") |> PrefixedName

    /// <summary>
    ///   <para>pav:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The version number of a resource. This is a freetext string, typical values are "1.5" or "21". The URI identifying the previous version can be provided using prov:previousVersion.
    ///
    /// This property is normally used in a functional way, although PAV does not formally restrict this."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The version number of a resource. This is a freetext string, typical values are "1.5" or "21". The URI identifying the previous version can be provided using prov:previousVersion."</para>
    /// labels<para>"version"</para><para>"Version"</para></remarks>
    /// <seealso href="http://purl.org/pav/version">http://purl.org/pav/version</seealso>
    let version = Prefixed_Name(pav, "version") |> PrefixedName
    /// <summary>
    ///   <para>pav:versioning/2.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/pav/versioning/2.0/">http://purl.org/pav/versioning/2.0/</seealso>
    let ``versioning/2.0/`` = Prefixed_Name(pav, "versioning/2.0/") |> PrefixedName

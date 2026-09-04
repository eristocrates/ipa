#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module fel =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/vcb/fel#" "fel"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the adjective mentions. For instance, the mention 'red' in the phrase 'red car' can be linked to wiki:Red; other examples include 'French', 'Democratic', 'his', etc.^^xsd:string</para>
    ///   <para>rdfs:label : Adjective</para>
    ///   <a href="http://w3id.org/vcb/fel#AdjectivePoS">fel:AdjectivePoS</a>
    /// </summary>
    let AdjectivePoS = _prefixId.prefix "AdjectivePoS"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the Adverb mentions. For instance, 'comercially' could be associated to wiki:Commerce^^xsd:string</para>
    ///   <para>rdfs:label : Adverb</para>
    ///   <a href="http://w3id.org/vcb/fel#AdverbPoS">fel:AdverbPoS</a>
    /// </summary>
    let AdverbPoS = _prefixId.prefix "AdverbPoS"
    /// <summary>
    ///   <para>dcterms:description : This class is concerned with all the proper-noun mentions with a different morpheme than the primary label of the knowledge base entity to which if refers (though it may be a known alias). For instance, the mention 'King of Pop' targeting wiki:Michael_Jackson is considered an AliasProperForm.</para>
    ///   <para>rdfs:label : Alias Proper Form</para>
    ///   <a href="http://w3id.org/vcb/fel#AliasProperForm">fel:AliasProperForm</a>
    /// </summary>
    let AliasProperForm = _prefixId.prefix "AliasProperForm"
    /// <summary>
    ///   <para>dcterms:description : This class gathers mentions that are pro-forms referring to an antecedent or postcedent in the text. For instance, in the sentence 'His son was widfely regarded ...' the mention 'His' may be an anaphoric reference to wiki:Joe_Jackson_(manager). (Note that noun phrases such as 'His son' referring to wiki:Michael_Jackson' should rather be marked as descriptive references.)</para>
    ///   <para>rdfs:label : Anaphoric Reference</para>
    ///   <a href="http://w3id.org/vcb/fel#AnaphoricReference">fel:AnaphoricReference</a>
    /// </summary>
    let AnaphoricReference = _prefixId.prefix "AnaphoricReference"
    /// <summary>
    ///   <para>dcterms:description : This meta-class gathers classes that divide annotations by the base-form of their mention, recognizing not only proper nouns as entities, but also other more flexible definitions, such as those that allow pronouns, numbers, temporal expressions, etc. Current instances of this meta-class include: ProperForm, NumericTemporalForm, CommonForm, and ProForm.</para>
    ///   <para>rdfs:label : Base Form Class</para>
    ///   <a href="http://w3id.org/vcb/fel#BaseFormClass">fel:BaseFormClass</a>
    /// </summary>
    let BaseFormClass = _prefixId.prefix "BaseFormClass"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the mentions with a corresponding entity in the knowledgebase, but that does not correspond to a Proper Form, Pro-Form or Numeric/Temporal Form. For instance, the mention 'bfelt' referring to wiki:Bfelt_(clothing) is considered CommonForm.</para>
    ///   <para>rdfs:label : Common Form</para>
    ///   <a href="http://w3id.org/vcb/fel#CommonForm">fel:CommonForm</a>
    /// </summary>
    let CommonForm = _prefixId.prefix "CommonForm"
    /// <summary>
    ///   <para>dcterms:description : This class gathers mentions based on describing the entities they refer to. For instance, the mention 'the capital of Peru' refers descriptively to wiki:Lima, or in the sentence 'Michael Jackson and his father', the mention 'his father' refers to wiki:Joe_Jackson_(manager). Note that simple proforms ('he', 'her', etc.) should rather be marked as anaphoric reference.</para>
    ///   <para>rdfs:label : Desciptive Reference</para>
    ///   <a href="http://w3id.org/vcb/fel#DescriptiveReference">fel:DescriptiveReference</a>
    /// </summary>
    let DescriptiveReference = _prefixId.prefix "DescriptiveReference"
    /// <summary>
    ///   <para>dcterms:description : This class gathers mentions with references based on the direct, literal meaning of the words and names. For instance, the reference 'Michael Jackson' referring to wiki:Michael_Jackson, or the reference 'talent manager' referring to wiki:Talent_manager, are considered direct references</para>
    ///   <para>rdfs:label : Direct Reference</para>
    ///   <a href="http://w3id.org/vcb/fel#DirectReference">fel:DirectReference</a>
    /// </summary>
    let DirectReference = _prefixId.prefix "DirectReference"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all proper-name mentions longer than the label of the knowledgebase entity but containing the label. For example, the mention 'Michael Joseph Jackson' targeting wiki:Michael_Jackson is considered an ExtendedProperForm.</para>
    ///   <para>rdfs:label : Extended Proper Form</para>
    ///   <a href="http://w3id.org/vcb/fel#ExtendedProperForm">fel:ExtendedProperForm</a>
    /// </summary>
    let ExtendedProperForm = _prefixId.prefix "ExtendedProperForm"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all proper-form mentions that (almost) exactly match with the label of the knowledgebase entity. For example, the mention 'Michael Jackson' targeting wiki:Michael_Jackson is considered Full. This class also includes mentions that are syntactically close to the knowlegebase entity (specifically, the lemmas should be the same and in the same order), for instance 'German' pointing to wiki:Germany is also considered a FullProperForm.</para>
    ///   <para>rdfs:label : Full Proper Form</para>
    ///   <a href="http://w3id.org/vcb/fel#FullProperForm">fel:FullProperForm</a>
    /// </summary>
    let FullProperForm = _prefixId.prefix "FullProperForm"
    /// <summary>
    ///   <para>dcterms:description : This class describes all the mentions that overlap with others and that, more specifically, both contain and are contained in other mentions. For instance, in the mention 'New York Police Department Museum', the mention 'New York Police Department' has intermediate overlap because it is contained in the overall mention and contains the mention 'New York'.^^xsd:string</para>
    ///   <para>rdfs:label : Intermediate Overlap</para>
    ///   <a href="http://w3id.org/vcb/fel#IntermediateOverlap">fel:IntermediateOverlap</a>
    /// </summary>
    let IntermediateOverlap = _prefixId.prefix "IntermediateOverlap"
    /// <summary>
    ///   <para>dcterms:description : This class describes all the mentions that overlap with others and that, more specifically, contain other mentions entirfely inside them but are not contained in other mentions. For instance, 'Living with Michael Jackson' is considered as maximal overlap assuming 'Michael Jackson' is also annotated and it is not contained inside another mention.^^xsd:string</para>
    ///   <para>rdfs:label : Maximal Overlap</para>
    ///   <a href="http://w3id.org/vcb/fel#MaximalOverlap">fel:MaximalOverlap</a>
    /// </summary>
    let MaximalOverlap = _prefixId.prefix "MaximalOverlap"
    /// <summary>
    ///   <para>dcterms:description : This class gathers mentions that make reference based on a figurative rather than literal meaning of the words. For example, in the phrase 'the King of Pop', the mention 'King' can be considered a metaphoric reference to wiki:King; in the sentence 'they added spice to their rfelationship', the mention 'spice' (wiki:Spice) is again a metaphoric reference.</para>
    ///   <para>rdfs:label : Metaphoric Reference</para>
    ///   <a href="http://w3id.org/vcb/fel#MetaphoricReference">fel:MetaphoricReference</a>
    /// </summary>
    let MetaphoricReference = _prefixId.prefix "MetaphoricReference"
    /// <summary>
    ///   <para>dcterms:description : This class gathers mentions that refer to something specific by reference to a broader related entity (often, but not always, countries). For example, in the phrase 'Russia announced today', the mention 'Russia' is a metonymic reference to wiki:Government_of_Russia; in the phrase 'Poland won 3-2 on penalties', 'Poland' may be a metonymic reference to wiki:Poland_national_football_team, etc.</para>
    ///   <para>rdfs:label : Metonymic Reference</para>
    ///   <a href="http://w3id.org/vcb/fel#MetonymicReference">fel:MetonymicReference</a>
    /// </summary>
    let MetonymicReference = _prefixId.prefix "MetonymicReference"
    /// <summary>
    ///   <para>dcterms:description : This class describes all the mentions that overlap with others and that, more specifically, are contained in but do not contain other mentions. For instance, in the annotation 'Living with Michael Jackson', the mention 'Michael Jackson' is considered to have minimal overlap.^^xsd:string</para>
    ///   <para>rdfs:label : Minimal Overlap</para>
    ///   <a href="http://w3id.org/vcb/fel#MinimalOverlap">fel:MinimalOverlap</a>
    /// </summary>
    let MinimalOverlap = _prefixId.prefix "MinimalOverlap"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the mentions without overlap.^^xsd:string</para>
    ///   <para>rdfs:label : No Overlap</para>
    ///   <a href="http://w3id.org/vcb/fel#NoOverlap">fel:NoOverlap</a>
    /// </summary>
    let NoOverlap = _prefixId.prefix "NoOverlap"
    let NounPhrase = _prefixId.prefix "NounPhrase"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the noun-phrase mentions. It is further divided into singular and plural noun-phrase mentions.^^xsd:string</para>
    ///   <para>rdfs:label : Noun Phrase PoS</para>
    ///   <a href="http://w3id.org/vcb/fel#NounPhrasePoS">fel:NounPhrasePoS</a>
    /// </summary>
    let NounPhrasePoS = _prefixId.prefix "NounPhrasePoS"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all mentions based on numeric and temporal expressions, such as: '1', 'one', '12/23/2019', etc. (as were included in MUC-6).</para>
    ///   <para>rdfs:label : Numeric and Temporal Form</para>
    ///   <a href="http://w3id.org/vcb/fel#NumericTemporalForm">fel:NumericTemporalForm</a>
    /// </summary>
    let NumericTemporalForm = _prefixId.prefix "NumericTemporalForm"
    /// <summary>
    ///   <para>dcterms:description : This meta-class gathers classes that divide annotations based on whether or not their mention overlaps with others. For example, in the sentence 'Living with Michael Jackson is a tfelevision documentary' the mention 'documentary' does not overlap with another mention; for this reason it is considered non-overlapping. On the other hand, the mentions 'Living with Michael Jackson' and 'Michael Jackson' have overlap.</para>
    ///   <para>rdfs:label : Overlap Class</para>
    ///   <a href="http://w3id.org/vcb/fel#OverlapClass">fel:OverlapClass</a>
    /// </summary>
    let OverlapClass = _prefixId.prefix "OverlapClass"
    /// <summary>
    ///   <para>dcterms:description : This meta-class gathers classes that divide annotations according to the part-of-speech of their mention.</para>
    ///   <para>rdfs:label : Part Of Speech Class</para>
    ///   <a href="http://w3id.org/vcb/fel#PartOfSpeechClass">fel:PartOfSpeechClass</a>
    /// </summary>
    let PartOfSpeechClass = _prefixId.prefix "PartOfSpeechClass"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the plural noun-phrase mentions. For instance, 'political parties' may refer to wiki:Political_party.</para>
    ///   <para>rdfs:label : Plural Noun Phrase PoS</para>
    ///   <a href="http://w3id.org/vcb/fel#PluralNounPhrasePoS">fel:PluralNounPhrasePoS</a>
    /// </summary>
    let PluralNounPhrasePoS = _prefixId.prefix "PluralNounPhrasePoS"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all mentions based on pronouns, pro-adjective, etc. For example, the mentions 'he', 'theirs', etc., are considered ProForm (assuming they link to a knowledgebase entity).</para>
    ///   <para>rdfs:label : Pro-Form</para>
    ///   <a href="http://w3id.org/vcb/fel#ProForm">fel:ProForm</a>
    /// </summary>
    let ProForm = _prefixId.prefix "ProForm"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all mentions based on names (proper nouns), e.g., 'Michael Jackson', 'USA', 'King of the Pop', 'B. Obama', etc. Such mentions do not have to be nouns if they are based on proper nouns, as in the case of 'French, 'Orwellian', etc. Such mentions may use abbreviated or extended forms of names; we add a new level in the class hierarchy to separate them: Full, Extended, Short or Alias.</para>
    ///   <para>rdfs:label : Proper Form</para>
    ///   <a href="http://w3id.org/vcb/fel#ProperForm">fel:ProperForm</a>
    /// </summary>
    let ProperForm = _prefixId.prefix "ProperForm"
    /// <summary>
    ///   <para>dcterms:description : This meta-class gathers classes that divide annotations based on how the mention references its entity. Examples of types of reference include Anaphoric, Direct, Descriptive, Metaphoric, Metonymic and Related.</para>
    ///   <para>rdfs:label : Reference Class</para>
    ///   <a href="http://w3id.org/vcb/fel#ReferenceClass">fel:ReferenceClass</a>
    /// </summary>
    let ReferenceClass = _prefixId.prefix "ReferenceClass"
    /// <summary>
    ///   <para>dcterms:description : This class gathers mentions that refer to something for which there is (only) something closely related in the knowledgebase. For instance, in the phrase 'The Russian daily RBK', the mention 'daily' refers to a daily newpaper, but in Wikipedia we only have wiki:Newspaper, so 'daily' can be seen as a reference to the closely related wiki:Newspaper. (Such references are sometimes reflected, for example, with redirects in Wikipedia, or pointers to a subsection of an entity's article.)</para>
    ///   <para>rdfs:label : Related Reference</para>
    ///   <a href="http://w3id.org/vcb/fel#RelatedReference">fel:RelatedReference</a>
    /// </summary>
    let RelatedReference = _prefixId.prefix "RelatedReference"
    /// <summary>
    ///   <para>dcterms:description : This class is concerned with all the proper-name mentions that are shorter than the label of the knowledgebase entity while still being based on the label. For instance, the mentions 'Jackson' or 'M. Jackson' targeting wiki:Michael_Jackson are considered ShortProperForm.</para>
    ///   <para>rdfs:label : Short Proper Form</para>
    ///   <a href="http://w3id.org/vcb/fel#ShortProperForm">fel:ShortProperForm</a>
    /// </summary>
    let ShortProperForm = _prefixId.prefix "ShortProperForm"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the singular noun-phrase mentions, including 'documentary', 'Germany', etc.</para>
    ///   <para>rdfs:label : Singular Noun Phrase PoS</para>
    ///   <a href="http://w3id.org/vcb/fel#SingularNounPhrasePoS">fel:SingularNounPhrasePoS</a>
    /// </summary>
    let SingularNounPhrasePoS = _prefixId.prefix "SingularNounPhrasePoS"
    /// <summary>
    ///   <para>dcterms:description : This class gathers all the verb mentions. For instance the verb mention 'assassinated' may link to wiki:Assassination.</para>
    ///   <para>rdfs:label : Verb PoS</para>
    ///   <a href="http://w3id.org/vcb/fel#VerbPoS">fel:VerbPoS</a>
    /// </summary>
    let VerbPoS = _prefixId.prefix "VerbPoS"
    /// <summary>
    ///   <para>dcterms:description : Specifies the entity type of a mention. The domain of the property are mentions, and the range is classes (from the KB), e.g., Organization, Place, Person, etc.</para>
    ///   <para>rdfs:label : Entity Type</para>
    ///   <a href="http://w3id.org/vcb/fel#entityType">fel:entityType</a>
    /// </summary>
    let entityType = _prefixId.prefix "entityType"

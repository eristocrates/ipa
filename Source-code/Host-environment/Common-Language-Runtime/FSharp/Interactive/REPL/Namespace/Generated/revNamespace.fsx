#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rev =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/stuff/rev#" "rev"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : A comment on a review^^xsd:string</para>
    ///   <para>rdfs:label : Comment^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#Comment">rev:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>rdfs:label : Feedback^^xsd:string</para>
    ///   <para>rdfs:comment : Feedback on the review. Expresses whether the review was useful or not^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:stringvs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#Feedback">rev:Feedback</a>
    /// </summary>
    let Feedback = _prefixId.prefix "Feedback"
    /// <summary>
    ///   <para>vs:moreinfo : core term^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A review of an work</para>
    ///   <para>rdfs:label : Review</para>
    ///   <a href="http://purl.org/stuff/rev#Review">rev:Review</a>
    /// </summary>
    let Review = _prefixId.prefix "Review"
    /// <summary>
    ///   <para>rdfs:comment : The commenter on the review^^xsd:string</para>
    ///   <para>rdfs:label : commenter^^xsd:string</para>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#commenter">rev:commenter</a>
    /// </summary>
    let commenter = _prefixId.prefix "commenter"
    /// <summary>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : Used to associate a review with a comment on the review^^xsd:string</para>
    ///   <para>rdfs:label : hasComment^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#hasComment">rev:hasComment</a>
    /// </summary>
    let hasComment = _prefixId.prefix "hasComment"
    /// <summary>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a review with a feedback on the review^^xsd:string</para>
    ///   <para>rdfs:label : hasFeedback^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#hasFeedback">rev:hasFeedback</a>
    /// </summary>
    let hasFeedback = _prefixId.prefix "hasFeedback"
    /// <summary>
    ///   <para>vs:moreinfo : core term^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a work with a a review</para>
    ///   <para>rdfs:label : has Review</para>
    ///   <a href="http://purl.org/stuff/rev#hasReview">rev:hasReview</a>
    /// </summary>
    let hasReview = _prefixId.prefix "hasReview"
    /// <summary>
    ///   <para>vs:moreinfo : Introduced by request of Revyu.com^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dce:description : Maximum value for rating property</para>
    ///   <para>rdfs:comment : A numeric value</para>
    ///   <para>rdfs:label : max Rating</para>
    ///   <a href="http://purl.org/stuff/rev#maxRating">rev:maxRating</a>
    /// </summary>
    let maxRating = _prefixId.prefix "maxRating"
    /// <summary>
    ///   <para>vs:moreinfo : Introduced by request of Revyu.com^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dce:description : Minimum value for rating property</para>
    ///   <para>rdfs:comment : A numeric value</para>
    ///   <para>rdfs:label : min Rating</para>
    ///   <a href="http://purl.org/stuff/rev#minRating">rev:minRating</a>
    /// </summary>
    let minRating = _prefixId.prefix "minRating"
    /// <summary>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : Number of positive usefulness votes (integer)^^xsd:string</para>
    ///   <para>rdfs:label : positiveVotes^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#positiveVotes">rev:positiveVotes</a>
    /// </summary>
    let positiveVotes = _prefixId.prefix "positiveVotes"
    /// <summary>
    ///   <para>vs:moreinfo : core term^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A numeric value</para>
    ///   <para>rdfs:label : rating</para>
    ///   <a href="http://purl.org/stuff/rev#rating">rev:rating</a>
    /// </summary>
    let rating = _prefixId.prefix "rating"
    /// <summary>
    ///   <para>vs:moreinfo : core term^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The person that has written the review</para>
    ///   <para>rdfs:label : reviewer</para>
    ///   <a href="http://purl.org/stuff/rev#reviewer">rev:reviewer</a>
    /// </summary>
    let reviewer = _prefixId.prefix "reviewer"
    /// <summary>
    ///   <para>vs:moreinfo : core term^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The text of the review</para>
    ///   <para>rdfs:label : text</para>
    ///   <a href="http://purl.org/stuff/rev#text">rev:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : The title of the review^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#title">rev:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>vs:moreinfo : proposed by iterating.com^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : Number of usefulness votes (integer)^^xsd:string</para>
    ///   <para>rdfs:label : totalVotes^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#totalVotes">rev:totalVotes</a>
    /// </summary>
    let totalVotes = _prefixId.prefix "totalVotes"
    /// <summary>
    ///   <para>vs:moreinfo : core term^^xsd:string</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : The type of media of a work under review^^xsd:string</para>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <a href="http://purl.org/stuff/rev#type">rev:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"

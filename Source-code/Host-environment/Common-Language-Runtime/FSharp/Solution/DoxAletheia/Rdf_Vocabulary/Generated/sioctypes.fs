namespace http.rdfs.org.sioc.types.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sioctypes =
    let _namespace_iri = Namespace_Iri sioctypes |> NamespaceIRI
    /// <summary>
    ///   <para>sioctypes:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://rdfs.org/sioc/types#">http://rdfs.org/sioc/types#</seealso>
    let _prefix_iri = Prefixed_Name(sioctypes, "") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:AddressBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a collection of personal or organisational addresses."</para>
    /// labels<para>"Address Book"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#AddressBook">http://rdfs.org/sioc/types#AddressBook</seealso>
    let AddressBook = Prefixed_Name(sioctypes, "AddressBook") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:AnnotationSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a set of annotations, for example, those created by a particular user or related to a particular topic."</para>
    /// labels<para>"Annotation Set"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#AnnotationSet">http://rdfs.org/sioc/types#AnnotationSet</seealso>
    let AnnotationSet = Prefixed_Name(sioctypes, "AnnotationSet") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Post that provides an answer in reply to a Question."</para>
    /// labels<para>"Answer"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Answer">http://rdfs.org/sioc/types#Answer</seealso>
    let Answer = Prefixed_Name(sioctypes, "Answer") |> PrefixedName

    /// <summary>
    ///   <para>sioctypes:ArgumentativeDiscussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a discussion area where logical arguments can take place."</para>
    /// labels<para>"Argumentative Discussion"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ArgumentativeDiscussion">http://rdfs.org/sioc/types#ArgumentativeDiscussion</seealso>
    let ArgumentativeDiscussion =
        Prefixed_Name(sioctypes, "ArgumentativeDiscussion") |> PrefixedName

    /// <summary>
    ///   <para>sioctypes:AudioChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a channel for distributing audio or sound files, for example, a podcast."</para>
    /// labels<para>"Audio Channel"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#AudioChannel">http://rdfs.org/sioc/types#AudioChannel</seealso>
    let AudioChannel = Prefixed_Name(sioctypes, "AudioChannel") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:BestAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Post that is the best answer to a Question, as chosen by the UserAccount who asked the Question or as voted by a Community of UserAccounts."</para>
    /// labels<para>"Best Answer"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#BestAnswer">http://rdfs.org/sioc/types#BestAnswer</seealso>
    let BestAnswer = Prefixed_Name(sioctypes, "BestAnswer") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:BlogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a post that is specifically made on a weblog."</para>
    /// labels<para>"Blog Post"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#BlogPost">http://rdfs.org/sioc/types#BlogPost</seealso>
    let BlogPost = Prefixed_Name(sioctypes, "BlogPost") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:BoardPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a post that is specifically made on a message board."</para>
    /// labels<para>"Board Post"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#BoardPost">http://rdfs.org/sioc/types#BoardPost</seealso>
    let BoardPost = Prefixed_Name(sioctypes, "BoardPost") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:BookmarkFolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a shared collection of bookmarks."</para>
    /// labels<para>"Bookmark Folder"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#BookmarkFolder">http://rdfs.org/sioc/types#BookmarkFolder</seealso>
    let BookmarkFolder = Prefixed_Name(sioctypes, "BookmarkFolder") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Briefcase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a briefcase or file service."</para>
    /// labels<para>"Briefcase"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Briefcase">http://rdfs.org/sioc/types#Briefcase</seealso>
    let Briefcase = Prefixed_Name(sioctypes, "Briefcase") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Category is used on the object of sioc:topic to indicate that this resource is a category on a site."</para>
    /// labels<para>"Category"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Category">http://rdfs.org/sioc/types#Category</seealso>
    let Category = Prefixed_Name(sioctypes, "Category") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:ChatChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a channel for chat or instant messages, for example, via IRC or IM."</para>
    /// labels<para>"Chat Channel"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ChatChannel">http://rdfs.org/sioc/types#ChatChannel</seealso>
    let ChatChannel = Prefixed_Name(sioctypes, "ChatChannel") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Comment is a subtype of sioc:Post and allows one to explicitly indicate that this SIOC post is a comment.  Note that comments have a narrower scope than sioc:Post and may not apply to all types of community site."</para>
    /// labels<para>"Comment"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Comment">http://rdfs.org/sioc/types#Comment</seealso>
    let Comment = Prefixed_Name(sioctypes, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:EventCalendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a calendar of events."</para>
    /// labels<para>"Event Calendar"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#EventCalendar">http://rdfs.org/sioc/types#EventCalendar</seealso>
    let EventCalendar = Prefixed_Name(sioctypes, "EventCalendar") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:FavouriteThings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a list or a collection of one's favourite things."</para>
    /// labels<para>"Favourite Things"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#FavouriteThings">http://rdfs.org/sioc/types#FavouriteThings</seealso>
    let FavouriteThings = Prefixed_Name(sioctypes, "FavouriteThings") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Forum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Forum">http://rdfs.org/sioc/types#Forum</seealso>
    let Forum = Prefixed_Name(sioctypes, "Forum") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:ImageGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an image gallery, for example, a photo album."</para>
    /// labels<para>"Image Gallery"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ImageGallery">http://rdfs.org/sioc/types#ImageGallery</seealso>
    let ImageGallery = Prefixed_Name(sioctypes, "ImageGallery") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:InstantMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an instant message, e.g. sent via Jabber."</para>
    /// labels<para>"Instant Message"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#InstantMessage">http://rdfs.org/sioc/types#InstantMessage</seealso>
    let InstantMessage = Prefixed_Name(sioctypes, "InstantMessage") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:MailMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an electronic mail message, e.g. a post sent to a mailing list."</para>
    /// labels<para>"Mail Message"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#MailMessage">http://rdfs.org/sioc/types#MailMessage</seealso>
    let MailMessage = Prefixed_Name(sioctypes, "MailMessage") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:MailingList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an electronic mailing list."</para>
    /// labels<para>"Mailing List"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#MailingList">http://rdfs.org/sioc/types#MailingList</seealso>
    let MailingList = Prefixed_Name(sioctypes, "MailingList") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:MessageBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a message board, also known as an online bulletin board or discussion forum."</para>
    /// labels<para>"Message Board"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#MessageBoard">http://rdfs.org/sioc/types#MessageBoard</seealso>
    let MessageBoard = Prefixed_Name(sioctypes, "MessageBoard") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Microblog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a microblog, i.e. a blog consisting of short text messages."</para>
    /// labels<para>"Microblog"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Microblog">http://rdfs.org/sioc/types#Microblog</seealso>
    let Microblog = Prefixed_Name(sioctypes, "Microblog") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:MicroblogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a post that is specifically made on a microblog."</para>
    /// labels<para>"Microblog Post"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#MicroblogPost">http://rdfs.org/sioc/types#MicroblogPost</seealso>
    let MicroblogPost = Prefixed_Name(sioctypes, "MicroblogPost") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:OfferList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a list of the items someone has available to offer."</para>
    /// labels<para>"Offer List"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#OfferList">http://rdfs.org/sioc/types#OfferList</seealso>
    let OfferList = Prefixed_Name(sioctypes, "OfferList") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a list of media items that have been played or can be played."</para>
    /// labels<para>"Playlist"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Playlist">http://rdfs.org/sioc/types#Playlist</seealso>
    let Playlist = Prefixed_Name(sioctypes, "Playlist") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Poll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a posted item that contains a poll or survey content."</para>
    /// labels<para>"Poll"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Poll">http://rdfs.org/sioc/types#Poll</seealso>
    let Poll = Prefixed_Name(sioctypes, "Poll") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:ProjectDirectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a project directory."</para>
    /// labels<para>"Project Directory"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ProjectDirectory">http://rdfs.org/sioc/types#ProjectDirectory</seealso>
    let ProjectDirectory = Prefixed_Name(sioctypes, "ProjectDirectory") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Post that asks a Question."</para>
    /// labels<para>"Question"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Question">http://rdfs.org/sioc/types#Question</seealso>
    let Question = Prefixed_Name(sioctypes, "Question") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:ReadingList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a list of books or other materials that have been read or are suggested for reading."</para>
    /// labels<para>"Reading List"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ReadingList">http://rdfs.org/sioc/types#ReadingList</seealso>
    let ReadingList = Prefixed_Name(sioctypes, "ReadingList") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:ResumeBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a collection of resumes."</para>
    /// labels<para>"Resume Bank"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ResumeBank">http://rdfs.org/sioc/types#ResumeBank</seealso>
    let ResumeBank = Prefixed_Name(sioctypes, "ResumeBank") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:ReviewArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an area where reviews are posted."</para>
    /// labels<para>"Review Area"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#ReviewArea">http://rdfs.org/sioc/types#ReviewArea</seealso>
    let ReviewArea = Prefixed_Name(sioctypes, "ReviewArea") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:SubscriptionList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a shared set of feed subscriptions."</para>
    /// labels<para>"Subscription List"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#SubscriptionList">http://rdfs.org/sioc/types#SubscriptionList</seealso>
    let SubscriptionList = Prefixed_Name(sioctypes, "SubscriptionList") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:SurveyCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an area where survey data can be collected, e.g. from polls."</para>
    /// labels<para>"Survey Collection"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#SurveyCollection">http://rdfs.org/sioc/types#SurveyCollection</seealso>
    let SurveyCollection = Prefixed_Name(sioctypes, "SurveyCollection") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tag is used on the object of sioc:topic to indicate that this resource is a tag on a site."</para>
    /// labels<para>"Tag"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Tag">http://rdfs.org/sioc/types#Tag</seealso>
    let Tag = Prefixed_Name(sioctypes, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:VideoChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a channel for distributing videos (moving image) files, for example, a video podcast."</para>
    /// labels<para>"Video Channel"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#VideoChannel">http://rdfs.org/sioc/types#VideoChannel</seealso>
    let VideoChannel = Prefixed_Name(sioctypes, "VideoChannel") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Weblog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a weblog (blog), i.e. an online journal."</para>
    /// labels<para>"Weblog"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Weblog">http://rdfs.org/sioc/types#Weblog</seealso>
    let Weblog = Prefixed_Name(sioctypes, "Weblog") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:Wiki</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a wiki space."</para>
    /// labels<para>"Wiki"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#Wiki">http://rdfs.org/sioc/types#Wiki</seealso>
    let Wiki = Prefixed_Name(sioctypes, "Wiki") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:WikiArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a wiki article."</para>
    /// labels<para>"Wiki Article"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#WikiArticle">http://rdfs.org/sioc/types#WikiArticle</seealso>
    let WikiArticle = Prefixed_Name(sioctypes, "WikiArticle") |> PrefixedName
    /// <summary>
    ///   <para>sioctypes:WishList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a list of the items someone wishes to get."</para>
    /// labels<para>"Wish List"</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/types#WishList">http://rdfs.org/sioc/types#WishList</seealso>
    let WishList = Prefixed_Name(sioctypes, "WishList") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tsioc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.org/sioc/types#" "tsioc"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Describes a collection of personal or organisational addresses.</para>
    ///   <para>rdfs:label : Address Book</para>
    ///   <a href="http://rdfs.org/sioc/types#AddressBook">tsioc:AddressBook</a>
    /// </summary>
    let AddressBook = _prefixId.prefix "AddressBook"
    /// <summary>
    ///   <para>rdfs:comment : Describes a set of annotations, for example, those created by a particular user or related to a particular topic.</para>
    ///   <para>rdfs:label : Annotation Set</para>
    ///   <a href="http://rdfs.org/sioc/types#AnnotationSet">tsioc:AnnotationSet</a>
    /// </summary>
    let AnnotationSet = _prefixId.prefix "AnnotationSet"
    /// <summary>
    ///   <para>rdfs:comment : A Post that provides an answer in reply to a Question.</para>
    ///   <para>rdfs:label : Answer</para>
    ///   <a href="http://rdfs.org/sioc/types#Answer">tsioc:Answer</a>
    /// </summary>
    let Answer = _prefixId.prefix "Answer"
    /// <summary>
    ///   <para>rdfs:comment : Describes a discussion area where logical arguments can take place.</para>
    ///   <para>rdfs:label : Argumentative Discussion</para>
    ///   <a href="http://rdfs.org/sioc/types#ArgumentativeDiscussion">tsioc:ArgumentativeDiscussion</a>
    /// </summary>
    let ArgumentativeDiscussion = _prefixId.prefix "ArgumentativeDiscussion"
    /// <summary>
    ///   <para>rdfs:comment : Describes a channel for distributing audio or sound files, for example, a podcast.</para>
    ///   <para>rdfs:label : Audio Channel</para>
    ///   <a href="http://rdfs.org/sioc/types#AudioChannel">tsioc:AudioChannel</a>
    /// </summary>
    let AudioChannel = _prefixId.prefix "AudioChannel"
    /// <summary>
    ///   <para>rdfs:comment : A Post that is the best answer to a Question, as chosen by the UserAccount who asked the Question or as voted by a Community of UserAccounts.</para>
    ///   <para>rdfs:label : Best Answer</para>
    ///   <a href="http://rdfs.org/sioc/types#BestAnswer">tsioc:BestAnswer</a>
    /// </summary>
    let BestAnswer = _prefixId.prefix "BestAnswer"
    /// <summary>
    ///   <para>rdfs:comment : Describes a post that is specifically made on a weblog.</para>
    ///   <para>rdfs:label : Blog Post</para>
    ///   <a href="http://rdfs.org/sioc/types#BlogPost">tsioc:BlogPost</a>
    /// </summary>
    let BlogPost = _prefixId.prefix "BlogPost"
    /// <summary>
    ///   <para>rdfs:comment : Describes a post that is specifically made on a message board.</para>
    ///   <para>rdfs:label : Board Post</para>
    ///   <a href="http://rdfs.org/sioc/types#BoardPost">tsioc:BoardPost</a>
    /// </summary>
    let BoardPost = _prefixId.prefix "BoardPost"
    /// <summary>
    ///   <para>rdfs:comment : Describes a shared collection of bookmarks.</para>
    ///   <para>rdfs:label : Bookmark Folder</para>
    ///   <a href="http://rdfs.org/sioc/types#BookmarkFolder">tsioc:BookmarkFolder</a>
    /// </summary>
    let BookmarkFolder = _prefixId.prefix "BookmarkFolder"
    /// <summary>
    ///   <para>rdfs:comment : Describes a briefcase or file service.</para>
    ///   <para>rdfs:label : Briefcase</para>
    ///   <a href="http://rdfs.org/sioc/types#Briefcase">tsioc:Briefcase</a>
    /// </summary>
    let Briefcase = _prefixId.prefix "Briefcase"
    /// <summary>
    ///   <para>rdfs:comment : Category is used on the object of sioc:topic to indicate that this resource is a category on a site.</para>
    ///   <para>rdfs:label : Category</para>
    ///   <a href="http://rdfs.org/sioc/types#Category">tsioc:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:comment : Describes a channel for chat or instant messages, for example, via IRC or IM.</para>
    ///   <para>rdfs:label : Chat Channel</para>
    ///   <a href="http://rdfs.org/sioc/types#ChatChannel">tsioc:ChatChannel</a>
    /// </summary>
    let ChatChannel = _prefixId.prefix "ChatChannel"
    /// <summary>
    ///   <para>rdfs:comment : Comment is a subtype of sioc:Post and allows one to explicitly indicate that this SIOC post is a comment.  Note that comments have a narrower scope than sioc:Post and may not apply to all types of community site.</para>
    ///   <para>rdfs:label : Comment</para>
    ///   <a href="http://rdfs.org/sioc/types#Comment">tsioc:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:comment : Describes a calendar of events.</para>
    ///   <para>rdfs:label : Event Calendar</para>
    ///   <a href="http://rdfs.org/sioc/types#EventCalendar">tsioc:EventCalendar</a>
    /// </summary>
    let EventCalendar = _prefixId.prefix "EventCalendar"
    /// <summary>
    ///   <para>rdfs:comment : Describes a list or a collection of one's favourite things.</para>
    ///   <para>rdfs:label : Favourite Things</para>
    ///   <a href="http://rdfs.org/sioc/types#FavouriteThings">tsioc:FavouriteThings</a>
    /// </summary>
    let FavouriteThings = _prefixId.prefix "FavouriteThings"
    let Forum = _prefixId.prefix "Forum"
    /// <summary>
    ///   <para>rdfs:comment : Describes an image gallery, for example, a photo album.</para>
    ///   <para>rdfs:label : Image Gallery</para>
    ///   <a href="http://rdfs.org/sioc/types#ImageGallery">tsioc:ImageGallery</a>
    /// </summary>
    let ImageGallery = _prefixId.prefix "ImageGallery"
    /// <summary>
    ///   <para>rdfs:comment : Describes an instant message, e.g. sent via Jabber.</para>
    ///   <para>rdfs:label : Instant Message</para>
    ///   <a href="http://rdfs.org/sioc/types#InstantMessage">tsioc:InstantMessage</a>
    /// </summary>
    let InstantMessage = _prefixId.prefix "InstantMessage"
    /// <summary>
    ///   <para>rdfs:comment : Describes an electronic mail message, e.g. a post sent to a mailing list.</para>
    ///   <para>rdfs:label : Mail Message</para>
    ///   <a href="http://rdfs.org/sioc/types#MailMessage">tsioc:MailMessage</a>
    /// </summary>
    let MailMessage = _prefixId.prefix "MailMessage"
    /// <summary>
    ///   <para>rdfs:comment : Describes an electronic mailing list.</para>
    ///   <para>rdfs:label : Mailing List</para>
    ///   <a href="http://rdfs.org/sioc/types#MailingList">tsioc:MailingList</a>
    /// </summary>
    let MailingList = _prefixId.prefix "MailingList"
    /// <summary>
    ///   <para>rdfs:comment : Describes a message board, also known as an online bulletin board or discussion forum.</para>
    ///   <para>rdfs:label : Message Board</para>
    ///   <a href="http://rdfs.org/sioc/types#MessageBoard">tsioc:MessageBoard</a>
    /// </summary>
    let MessageBoard = _prefixId.prefix "MessageBoard"
    /// <summary>
    ///   <para>rdfs:comment : Describes a microblog, i.e. a blog consisting of short text messages.</para>
    ///   <para>rdfs:label : Microblog</para>
    ///   <a href="http://rdfs.org/sioc/types#Microblog">tsioc:Microblog</a>
    /// </summary>
    let Microblog = _prefixId.prefix "Microblog"
    /// <summary>
    ///   <para>rdfs:comment : Describes a post that is specifically made on a microblog.</para>
    ///   <para>rdfs:label : Microblog Post</para>
    ///   <a href="http://rdfs.org/sioc/types#MicroblogPost">tsioc:MicroblogPost</a>
    /// </summary>
    let MicroblogPost = _prefixId.prefix "MicroblogPost"
    /// <summary>
    ///   <para>rdfs:comment : Describes a list of the items someone has available to offer.</para>
    ///   <para>rdfs:label : Offer List</para>
    ///   <a href="http://rdfs.org/sioc/types#OfferList">tsioc:OfferList</a>
    /// </summary>
    let OfferList = _prefixId.prefix "OfferList"
    /// <summary>
    ///   <para>rdfs:comment : Describes a list of media items that have been played or can be played.</para>
    ///   <para>rdfs:label : Playlist</para>
    ///   <a href="http://rdfs.org/sioc/types#Playlist">tsioc:Playlist</a>
    /// </summary>
    let Playlist = _prefixId.prefix "Playlist"
    /// <summary>
    ///   <para>rdfs:comment : Describes a posted item that contains a poll or survey content.</para>
    ///   <para>rdfs:label : Poll</para>
    ///   <a href="http://rdfs.org/sioc/types#Poll">tsioc:Poll</a>
    /// </summary>
    let Poll = _prefixId.prefix "Poll"
    /// <summary>
    ///   <para>rdfs:comment : Describes a project directory.</para>
    ///   <para>rdfs:label : Project Directory</para>
    ///   <a href="http://rdfs.org/sioc/types#ProjectDirectory">tsioc:ProjectDirectory</a>
    /// </summary>
    let ProjectDirectory = _prefixId.prefix "ProjectDirectory"
    /// <summary>
    ///   <para>rdfs:comment : A Post that asks a Question.</para>
    ///   <para>rdfs:label : Question</para>
    ///   <a href="http://rdfs.org/sioc/types#Question">tsioc:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>rdfs:comment : Describes a list of books or other materials that have been read or are suggested for reading.</para>
    ///   <para>rdfs:label : Reading List</para>
    ///   <a href="http://rdfs.org/sioc/types#ReadingList">tsioc:ReadingList</a>
    /// </summary>
    let ReadingList = _prefixId.prefix "ReadingList"
    /// <summary>
    ///   <para>rdfs:comment : Describes a collection of resumes.</para>
    ///   <para>rdfs:label : Resume Bank</para>
    ///   <a href="http://rdfs.org/sioc/types#ResumeBank">tsioc:ResumeBank</a>
    /// </summary>
    let ResumeBank = _prefixId.prefix "ResumeBank"
    /// <summary>
    ///   <para>rdfs:comment : Describes an area where reviews are posted.</para>
    ///   <para>rdfs:label : Review Area</para>
    ///   <a href="http://rdfs.org/sioc/types#ReviewArea">tsioc:ReviewArea</a>
    /// </summary>
    let ReviewArea = _prefixId.prefix "ReviewArea"
    /// <summary>
    ///   <para>rdfs:comment : Describes a shared set of feed subscriptions.</para>
    ///   <para>rdfs:label : Subscription List</para>
    ///   <a href="http://rdfs.org/sioc/types#SubscriptionList">tsioc:SubscriptionList</a>
    /// </summary>
    let SubscriptionList = _prefixId.prefix "SubscriptionList"
    /// <summary>
    ///   <para>rdfs:comment : Describes an area where survey data can be collected, e.g. from polls.</para>
    ///   <para>rdfs:label : Survey Collection</para>
    ///   <a href="http://rdfs.org/sioc/types#SurveyCollection">tsioc:SurveyCollection</a>
    /// </summary>
    let SurveyCollection = _prefixId.prefix "SurveyCollection"
    /// <summary>
    ///   <para>rdfs:comment : Tag is used on the object of sioc:topic to indicate that this resource is a tag on a site.</para>
    ///   <para>rdfs:label : Tag</para>
    ///   <a href="http://rdfs.org/sioc/types#Tag">tsioc:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:comment : Describes a channel for distributing videos (moving image) files, for example, a video podcast.</para>
    ///   <para>rdfs:label : Video Channel</para>
    ///   <a href="http://rdfs.org/sioc/types#VideoChannel">tsioc:VideoChannel</a>
    /// </summary>
    let VideoChannel = _prefixId.prefix "VideoChannel"
    /// <summary>
    ///   <para>rdfs:comment : Describes a weblog (blog), i.e. an online journal.</para>
    ///   <para>rdfs:label : Weblog</para>
    ///   <a href="http://rdfs.org/sioc/types#Weblog">tsioc:Weblog</a>
    /// </summary>
    let Weblog = _prefixId.prefix "Weblog"
    /// <summary>
    ///   <para>rdfs:comment : Describes a wiki space.</para>
    ///   <para>rdfs:label : Wiki</para>
    ///   <a href="http://rdfs.org/sioc/types#Wiki">tsioc:Wiki</a>
    /// </summary>
    let Wiki = _prefixId.prefix "Wiki"
    /// <summary>
    ///   <para>rdfs:comment : Describes a wiki article.</para>
    ///   <para>rdfs:label : Wiki Article</para>
    ///   <a href="http://rdfs.org/sioc/types#WikiArticle">tsioc:WikiArticle</a>
    /// </summary>
    let WikiArticle = _prefixId.prefix "WikiArticle"
    /// <summary>
    ///   <para>rdfs:comment : Describes a list of the items someone wishes to get.</para>
    ///   <para>rdfs:label : Wish List</para>
    ///   <a href="http://rdfs.org/sioc/types#WishList">tsioc:WishList</a>
    /// </summary>
    let WishList = _prefixId.prefix "WishList"

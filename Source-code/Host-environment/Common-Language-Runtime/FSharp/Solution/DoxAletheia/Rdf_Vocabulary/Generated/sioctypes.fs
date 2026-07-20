namespace http.rdfs.org.sioc.types.hash

open DoxAletheia

module sioctypes =
    let _namespace_name = "http://rdfs.org/sioc/types#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Describes a collection of personal or organisational addresses.
    /// <see href="http://rdfs.org/sioc/types#AddressBook"></see></summary>
    let AddressBook = _prefix "AddressBook"
    /// <summary>
    /// Describes a set of annotations, for example, those created by a particular user or related to a particular topic.
    /// <see href="http://rdfs.org/sioc/types#AnnotationSet"></see></summary>
    let AnnotationSet = _prefix "AnnotationSet"
    /// <summary>
    /// A Post that provides an answer in reply to a Question.
    /// <see href="http://rdfs.org/sioc/types#Answer"></see></summary>
    let Answer = _prefix "Answer"
    /// <summary>
    /// Describes a discussion area where logical arguments can take place.
    /// <see href="http://rdfs.org/sioc/types#ArgumentativeDiscussion"></see></summary>
    let ArgumentativeDiscussion = _prefix "ArgumentativeDiscussion"
    /// <summary>
    /// Describes a channel for distributing audio or sound files, for example, a podcast.
    /// <see href="http://rdfs.org/sioc/types#AudioChannel"></see></summary>
    let AudioChannel = _prefix "AudioChannel"
    /// <summary>
    /// A Post that is the best answer to a Question, as chosen by the UserAccount who asked the Question or as voted by a Community of UserAccounts.
    /// <see href="http://rdfs.org/sioc/types#BestAnswer"></see></summary>
    let BestAnswer = _prefix "BestAnswer"
    /// <summary>
    /// Describes a post that is specifically made on a weblog.
    /// <see href="http://rdfs.org/sioc/types#BlogPost"></see></summary>
    let BlogPost = _prefix "BlogPost"
    /// <summary>
    /// Describes a weblog (blog), i.e. an online journal.
    /// <see href="http://rdfs.org/sioc/types#Weblog"></see></summary>
    let Weblog = _prefix "Weblog"
    /// <summary>
    /// Describes a post that is specifically made on a message board.
    /// <see href="http://rdfs.org/sioc/types#BoardPost"></see></summary>
    let BoardPost = _prefix "BoardPost"
    /// <summary>
    /// Describes a message board, also known as an online bulletin board or discussion forum.
    /// <see href="http://rdfs.org/sioc/types#MessageBoard"></see></summary>
    let MessageBoard = _prefix "MessageBoard"
    /// <summary>
    /// Describes a shared collection of bookmarks.
    /// <see href="http://rdfs.org/sioc/types#BookmarkFolder"></see></summary>
    let BookmarkFolder = _prefix "BookmarkFolder"
    /// <summary>
    /// Describes a briefcase or file service.
    /// <see href="http://rdfs.org/sioc/types#Briefcase"></see></summary>
    let Briefcase = _prefix "Briefcase"
    /// <summary>
    /// Category is used on the object of sioc:topic to indicate that this resource is a category on a site.
    /// <see href="http://rdfs.org/sioc/types#Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// Describes a channel for chat or instant messages, for example, via IRC or IM.
    /// <see href="http://rdfs.org/sioc/types#ChatChannel"></see></summary>
    let ChatChannel = _prefix "ChatChannel"
    /// <summary>
    /// Describes an instant message, e.g. sent via Jabber.
    /// <see href="http://rdfs.org/sioc/types#InstantMessage"></see></summary>
    let InstantMessage = _prefix "InstantMessage"
    /// <summary>
    /// Comment is a subtype of sioc:Post and allows one to explicitly indicate that this SIOC post is a comment.  Note that comments have a narrower scope than sioc:Post and may not apply to all types of community site.
    /// <see href="http://rdfs.org/sioc/types#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    ///   <see href="http://rdfs.org/sioc/types#Forum"></see>
    /// </summary>
    let Forum = _prefix "Forum"
    /// <summary>
    /// Describes a calendar of events.
    /// <see href="http://rdfs.org/sioc/types#EventCalendar"></see></summary>
    let EventCalendar = _prefix "EventCalendar"
    /// <summary>
    /// Describes a list or a collection of one's favourite things.
    /// <see href="http://rdfs.org/sioc/types#FavouriteThings"></see></summary>
    let FavouriteThings = _prefix "FavouriteThings"
    /// <summary>
    /// Describes an image gallery, for example, a photo album.
    /// <see href="http://rdfs.org/sioc/types#ImageGallery"></see></summary>
    let ImageGallery = _prefix "ImageGallery"
    /// <summary>
    /// Describes an electronic mail message, e.g. a post sent to a mailing list.
    /// <see href="http://rdfs.org/sioc/types#MailMessage"></see></summary>
    let MailMessage = _prefix "MailMessage"
    /// <summary>
    /// Describes an electronic mailing list.
    /// <see href="http://rdfs.org/sioc/types#MailingList"></see></summary>
    let MailingList = _prefix "MailingList"
    /// <summary>
    /// Describes a microblog, i.e. a blog consisting of short text messages.
    /// <see href="http://rdfs.org/sioc/types#Microblog"></see></summary>
    let Microblog = _prefix "Microblog"
    /// <summary>
    /// Describes a post that is specifically made on a microblog.
    /// <see href="http://rdfs.org/sioc/types#MicroblogPost"></see></summary>
    let MicroblogPost = _prefix "MicroblogPost"
    /// <summary>
    /// Describes a list of the items someone has available to offer.
    /// <see href="http://rdfs.org/sioc/types#OfferList"></see></summary>
    let OfferList = _prefix "OfferList"
    /// <summary>
    /// Describes a list of media items that have been played or can be played.
    /// <see href="http://rdfs.org/sioc/types#Playlist"></see></summary>
    let Playlist = _prefix "Playlist"
    /// <summary>
    /// Describes a posted item that contains a poll or survey content.
    /// <see href="http://rdfs.org/sioc/types#Poll"></see></summary>
    let Poll = _prefix "Poll"
    /// <summary>
    /// Describes an area where survey data can be collected, e.g. from polls.
    /// <see href="http://rdfs.org/sioc/types#SurveyCollection"></see></summary>
    let SurveyCollection = _prefix "SurveyCollection"
    /// <summary>
    /// Describes a project directory.
    /// <see href="http://rdfs.org/sioc/types#ProjectDirectory"></see></summary>
    let ProjectDirectory = _prefix "ProjectDirectory"
    /// <summary>
    /// A Post that asks a Question.
    /// <see href="http://rdfs.org/sioc/types#Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// Describes a list of books or other materials that have been read or are suggested for reading.
    /// <see href="http://rdfs.org/sioc/types#ReadingList"></see></summary>
    let ReadingList = _prefix "ReadingList"
    /// <summary>
    /// Describes a collection of resumes.
    /// <see href="http://rdfs.org/sioc/types#ResumeBank"></see></summary>
    let ResumeBank = _prefix "ResumeBank"
    /// <summary>
    /// Describes an area where reviews are posted.
    /// <see href="http://rdfs.org/sioc/types#ReviewArea"></see></summary>
    let ReviewArea = _prefix "ReviewArea"
    /// <summary>
    /// Describes a shared set of feed subscriptions.
    /// <see href="http://rdfs.org/sioc/types#SubscriptionList"></see></summary>
    let SubscriptionList = _prefix "SubscriptionList"
    /// <summary>
    /// Tag is used on the object of sioc:topic to indicate that this resource is a tag on a site.
    /// <see href="http://rdfs.org/sioc/types#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// Describes a channel for distributing videos (moving image) files, for example, a video podcast.
    /// <see href="http://rdfs.org/sioc/types#VideoChannel"></see></summary>
    let VideoChannel = _prefix "VideoChannel"
    /// <summary>
    /// Describes a wiki space.
    /// <see href="http://rdfs.org/sioc/types#Wiki"></see></summary>
    let Wiki = _prefix "Wiki"
    /// <summary>
    /// Describes a wiki article.
    /// <see href="http://rdfs.org/sioc/types#WikiArticle"></see></summary>
    let WikiArticle = _prefix "WikiArticle"
    /// <summary>
    /// Describes a list of the items someone wishes to get.
    /// <see href="http://rdfs.org/sioc/types#WishList"></see></summary>
    let WishList = _prefix "WishList"

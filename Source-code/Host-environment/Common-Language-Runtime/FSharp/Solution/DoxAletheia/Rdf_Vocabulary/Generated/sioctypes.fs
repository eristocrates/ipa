namespace http.rdfs.org.sioc.types.hash

open DoxAletheia.Rdf_Vocabulary

module sioctypes =
    let _namespace_name = "http://rdfs.org/sioc/types#"

    /// <summary>
    /// Describes a collection of personal or organisational addresses.
    /// <see href="http://rdfs.org/sioc/types#AddressBook"></see></summary>
    let AddressBook =
        Namespaced_IRI.parse _namespace_name "AddressBook" |> NamespacedName

    /// <summary>
    /// Describes a set of annotations, for example, those created by a particular user or related to a particular topic.
    /// <see href="http://rdfs.org/sioc/types#AnnotationSet"></see></summary>
    let AnnotationSet =
        Namespaced_IRI.parse _namespace_name "AnnotationSet" |> NamespacedName

    /// <summary>
    /// A Post that provides an answer in reply to a Question.
    /// <see href="http://rdfs.org/sioc/types#Answer"></see></summary>
    let Answer = Namespaced_IRI.parse _namespace_name "Answer" |> NamespacedName

    /// <summary>
    /// Describes a discussion area where logical arguments can take place.
    /// <see href="http://rdfs.org/sioc/types#ArgumentativeDiscussion"></see></summary>
    let ArgumentativeDiscussion =
        Namespaced_IRI.parse _namespace_name "ArgumentativeDiscussion" |> NamespacedName

    /// <summary>
    /// Describes a channel for distributing audio or sound files, for example, a podcast.
    /// <see href="http://rdfs.org/sioc/types#AudioChannel"></see></summary>
    let AudioChannel =
        Namespaced_IRI.parse _namespace_name "AudioChannel" |> NamespacedName

    /// <summary>
    /// A Post that is the best answer to a Question, as chosen by the UserAccount who asked the Question or as voted by a Community of UserAccounts.
    /// <see href="http://rdfs.org/sioc/types#BestAnswer"></see></summary>
    let BestAnswer = Namespaced_IRI.parse _namespace_name "BestAnswer" |> NamespacedName
    /// <summary>
    /// Describes a post that is specifically made on a weblog.
    /// <see href="http://rdfs.org/sioc/types#BlogPost"></see></summary>
    let BlogPost = Namespaced_IRI.parse _namespace_name "BlogPost" |> NamespacedName
    /// <summary>
    /// Describes a weblog (blog), i.e. an online journal.
    /// <see href="http://rdfs.org/sioc/types#Weblog"></see></summary>
    let Weblog = Namespaced_IRI.parse _namespace_name "Weblog" |> NamespacedName
    /// <summary>
    /// Describes a post that is specifically made on a message board.
    /// <see href="http://rdfs.org/sioc/types#BoardPost"></see></summary>
    let BoardPost = Namespaced_IRI.parse _namespace_name "BoardPost" |> NamespacedName

    /// <summary>
    /// Describes a message board, also known as an online bulletin board or discussion forum.
    /// <see href="http://rdfs.org/sioc/types#MessageBoard"></see></summary>
    let MessageBoard =
        Namespaced_IRI.parse _namespace_name "MessageBoard" |> NamespacedName

    /// <summary>
    /// Describes a shared collection of bookmarks.
    /// <see href="http://rdfs.org/sioc/types#BookmarkFolder"></see></summary>
    let BookmarkFolder =
        Namespaced_IRI.parse _namespace_name "BookmarkFolder" |> NamespacedName

    /// <summary>
    /// Describes a briefcase or file service.
    /// <see href="http://rdfs.org/sioc/types#Briefcase"></see></summary>
    let Briefcase = Namespaced_IRI.parse _namespace_name "Briefcase" |> NamespacedName
    /// <summary>
    /// Category is used on the object of sioc:topic to indicate that this resource is a category on a site.
    /// <see href="http://rdfs.org/sioc/types#Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName

    /// <summary>
    /// Describes a channel for chat or instant messages, for example, via IRC or IM.
    /// <see href="http://rdfs.org/sioc/types#ChatChannel"></see></summary>
    let ChatChannel =
        Namespaced_IRI.parse _namespace_name "ChatChannel" |> NamespacedName

    /// <summary>
    /// Describes an instant message, e.g. sent via Jabber.
    /// <see href="http://rdfs.org/sioc/types#InstantMessage"></see></summary>
    let InstantMessage =
        Namespaced_IRI.parse _namespace_name "InstantMessage" |> NamespacedName

    /// <summary>
    /// Comment is a subtype of sioc:Post and allows one to explicitly indicate that this SIOC post is a comment.  Note that comments have a narrower scope than sioc:Post and may not apply to all types of community site.
    /// <see href="http://rdfs.org/sioc/types#Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.org/sioc/types#Forum"></see>
    /// </summary>
    let Forum = Namespaced_IRI.parse _namespace_name "Forum" |> NamespacedName

    /// <summary>
    /// Describes a calendar of events.
    /// <see href="http://rdfs.org/sioc/types#EventCalendar"></see></summary>
    let EventCalendar =
        Namespaced_IRI.parse _namespace_name "EventCalendar" |> NamespacedName

    /// <summary>
    /// Describes a list or a collection of one's favourite things.
    /// <see href="http://rdfs.org/sioc/types#FavouriteThings"></see></summary>
    let FavouriteThings =
        Namespaced_IRI.parse _namespace_name "FavouriteThings" |> NamespacedName

    /// <summary>
    /// Describes an image gallery, for example, a photo album.
    /// <see href="http://rdfs.org/sioc/types#ImageGallery"></see></summary>
    let ImageGallery =
        Namespaced_IRI.parse _namespace_name "ImageGallery" |> NamespacedName

    /// <summary>
    /// Describes an electronic mail message, e.g. a post sent to a mailing list.
    /// <see href="http://rdfs.org/sioc/types#MailMessage"></see></summary>
    let MailMessage =
        Namespaced_IRI.parse _namespace_name "MailMessage" |> NamespacedName

    /// <summary>
    /// Describes an electronic mailing list.
    /// <see href="http://rdfs.org/sioc/types#MailingList"></see></summary>
    let MailingList =
        Namespaced_IRI.parse _namespace_name "MailingList" |> NamespacedName

    /// <summary>
    /// Describes a microblog, i.e. a blog consisting of short text messages.
    /// <see href="http://rdfs.org/sioc/types#Microblog"></see></summary>
    let Microblog = Namespaced_IRI.parse _namespace_name "Microblog" |> NamespacedName

    /// <summary>
    /// Describes a post that is specifically made on a microblog.
    /// <see href="http://rdfs.org/sioc/types#MicroblogPost"></see></summary>
    let MicroblogPost =
        Namespaced_IRI.parse _namespace_name "MicroblogPost" |> NamespacedName

    /// <summary>
    /// Describes a list of the items someone has available to offer.
    /// <see href="http://rdfs.org/sioc/types#OfferList"></see></summary>
    let OfferList = Namespaced_IRI.parse _namespace_name "OfferList" |> NamespacedName
    /// <summary>
    /// Describes a list of media items that have been played or can be played.
    /// <see href="http://rdfs.org/sioc/types#Playlist"></see></summary>
    let Playlist = Namespaced_IRI.parse _namespace_name "Playlist" |> NamespacedName
    /// <summary>
    /// Describes a posted item that contains a poll or survey content.
    /// <see href="http://rdfs.org/sioc/types#Poll"></see></summary>
    let Poll = Namespaced_IRI.parse _namespace_name "Poll" |> NamespacedName

    /// <summary>
    /// Describes an area where survey data can be collected, e.g. from polls.
    /// <see href="http://rdfs.org/sioc/types#SurveyCollection"></see></summary>
    let SurveyCollection =
        Namespaced_IRI.parse _namespace_name "SurveyCollection" |> NamespacedName

    /// <summary>
    /// Describes a project directory.
    /// <see href="http://rdfs.org/sioc/types#ProjectDirectory"></see></summary>
    let ProjectDirectory =
        Namespaced_IRI.parse _namespace_name "ProjectDirectory" |> NamespacedName

    /// <summary>
    /// A Post that asks a Question.
    /// <see href="http://rdfs.org/sioc/types#Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName

    /// <summary>
    /// Describes a list of books or other materials that have been read or are suggested for reading.
    /// <see href="http://rdfs.org/sioc/types#ReadingList"></see></summary>
    let ReadingList =
        Namespaced_IRI.parse _namespace_name "ReadingList" |> NamespacedName

    /// <summary>
    /// Describes a collection of resumes.
    /// <see href="http://rdfs.org/sioc/types#ResumeBank"></see></summary>
    let ResumeBank = Namespaced_IRI.parse _namespace_name "ResumeBank" |> NamespacedName
    /// <summary>
    /// Describes an area where reviews are posted.
    /// <see href="http://rdfs.org/sioc/types#ReviewArea"></see></summary>
    let ReviewArea = Namespaced_IRI.parse _namespace_name "ReviewArea" |> NamespacedName

    /// <summary>
    /// Describes a shared set of feed subscriptions.
    /// <see href="http://rdfs.org/sioc/types#SubscriptionList"></see></summary>
    let SubscriptionList =
        Namespaced_IRI.parse _namespace_name "SubscriptionList" |> NamespacedName

    /// <summary>
    /// Tag is used on the object of sioc:topic to indicate that this resource is a tag on a site.
    /// <see href="http://rdfs.org/sioc/types#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName

    /// <summary>
    /// Describes a channel for distributing videos (moving image) files, for example, a video podcast.
    /// <see href="http://rdfs.org/sioc/types#VideoChannel"></see></summary>
    let VideoChannel =
        Namespaced_IRI.parse _namespace_name "VideoChannel" |> NamespacedName

    /// <summary>
    /// Describes a wiki space.
    /// <see href="http://rdfs.org/sioc/types#Wiki"></see></summary>
    let Wiki = Namespaced_IRI.parse _namespace_name "Wiki" |> NamespacedName

    /// <summary>
    /// Describes a wiki article.
    /// <see href="http://rdfs.org/sioc/types#WikiArticle"></see></summary>
    let WikiArticle =
        Namespaced_IRI.parse _namespace_name "WikiArticle" |> NamespacedName

    /// <summary>
    /// Describes a list of the items someone wishes to get.
    /// <see href="http://rdfs.org/sioc/types#WishList"></see></summary>
    let WishList = Namespaced_IRI.parse _namespace_name "WishList" |> NamespacedName

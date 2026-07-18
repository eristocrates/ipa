namespace http.reference.data.gov.uk.def.organogram.slash

open DoxAletheia.Rdf_Vocabulary

module odv =
    let _namespace_name = "http://reference.data.gov.uk/def/organogram/"
    /// <summary>
    /// Currency in which the salary is paid, typically attached to the dataset for single currency datasets.
    /// <see href="http://reference.data.gov.uk/def/organogram/currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName
    /// <summary>
    /// The date that the observation relates to.
    /// <see href="http://reference.data.gov.uk/def/organogram/date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// The grade of the junior posts.
    /// <see href="http://reference.data.gov.uk/def/organogram/grade"></see></summary>
    let grade = Namespaced_IRI.parse _namespace_name "grade" |> NamespacedName
    /// <summary>
    /// The job performed by the junior posts.
    /// <see href="http://reference.data.gov.uk/def/organogram/job"></see></summary>
    let job = Namespaced_IRI.parse _namespace_name "job" |> NamespacedName

    /// <summary>
    /// The structure of a cube containing data about the number of junior staff of different grades that report to a particular post from within a particular unit, with a particular job and a particular profession, on a particular day.
    /// <see href="http://reference.data.gov.uk/def/organogram/junior-posts"></see></summary>
    let ``junior-posts`` =
        Namespaced_IRI.parse _namespace_name "junior-posts" |> NamespacedName

    /// <summary>
    /// The profession of the junior posts.
    /// <see href="http://reference.data.gov.uk/def/organogram/profession"></see></summary>
    let profession = Namespaced_IRI.parse _namespace_name "profession" |> NamespacedName
    /// <summary>
    /// The unit to which the junior posts belong.
    /// <see href="http://reference.data.gov.uk/def/organogram/unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/organogram/fullTimeEquivalent"></see>
    /// </summary>
    let fullTimeEquivalent =
        Namespaced_IRI.parse _namespace_name "fullTimeEquivalent" |> NamespacedName

    /// <summary>
    /// The post to which the junior posts report.
    /// <see href="http://reference.data.gov.uk/def/organogram/reportingTo"></see></summary>
    let reportingTo =
        Namespaced_IRI.parse _namespace_name "reportingTo" |> NamespacedName

    /// <summary>
    /// The number of posts with this grade that report to the given post, as a full-time equivalent.
    /// <see href="http://reference.data.gov.uk/def/organogram/numberOfPosts"></see></summary>
    let numberOfPosts =
        Namespaced_IRI.parse _namespace_name "numberOfPosts" |> NamespacedName

    /// <summary>
    /// The structure of a cube containing data about the number of posts of different grades that report to a particular post on a particular day.
    /// <see href="http://reference.data.gov.uk/def/organogram/number-of-posts"></see></summary>
    let ``number-of-posts`` =
        Namespaced_IRI.parse _namespace_name "number-of-posts" |> NamespacedName

    /// <summary>
    /// The post whose subordinates this statistic relates to.
    /// <see href="http://reference.data.gov.uk/def/organogram/post"></see></summary>
    let post = Namespaced_IRI.parse _namespace_name "post" |> NamespacedName

    /// <summary>
    /// The structure of a cube containing data about the salary costs of the reports to a particular post on a particular day.
    /// <see href="http://reference.data.gov.uk/def/organogram/salary-costs-of-reports"></see></summary>
    let ``salary-costs-of-reports`` =
        Namespaced_IRI.parse _namespace_name "salary-costs-of-reports" |> NamespacedName

    /// <summary>
    /// The total salary cost of each Deputy Director/SCS Pay Band 1 and 1A member and the non-SCS staff that report to this post. Salary costs are base pay (excluding bonuses and allowances) as at the date of the observation. To ensure that individual salaries cannot be identified from this information (for Deputy Director/SCS Pay Band 1 and 1A level and non-SCS grades), where the team is less than five people, the cost is rounded to the nearest £100,000. Where the team is one person only, the salary cost may be rounded to the nearest £100,000 or merged with the costs of another team.
    /// <see href="http://reference.data.gov.uk/def/organogram/salaryCostOfReports"></see></summary>
    let salaryCostOfReports =
        Namespaced_IRI.parse _namespace_name "salaryCostOfReports" |> NamespacedName

    /// <summary>
    /// The tenure through which pay was given.
    /// <see href="http://reference.data.gov.uk/def/organogram/tenure"></see></summary>
    let tenure = Namespaced_IRI.parse _namespace_name "tenure" |> NamespacedName

    /// <summary>
    /// The structure of a cube containing data about the total pay received for a particular tenure (a person in a post) on a particular day.
    /// <see href="http://reference.data.gov.uk/def/organogram/total-pay"></see></summary>
    let ``total-pay`` =
        Namespaced_IRI.parse _namespace_name "total-pay" |> NamespacedName

    /// <summary>
    /// The total pay received.
    /// <see href="http://reference.data.gov.uk/def/organogram/totalPay"></see></summary>
    let totalPay = Namespaced_IRI.parse _namespace_name "totalPay" |> NamespacedName

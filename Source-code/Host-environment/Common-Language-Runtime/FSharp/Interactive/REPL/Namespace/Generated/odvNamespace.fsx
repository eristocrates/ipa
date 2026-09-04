#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module odv =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/organogram/" "odv"

    let _namespaceIri = _prefixId.prefix ""
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : The date that the observation relates to.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/date">odv:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    let fullTimeEquivalent = _prefixId.prefix "fullTimeEquivalent"
    /// <summary>
    ///   <para>rdfs:label : Grade</para>
    ///   <para>rdfs:comment : The grade of the junior posts.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/grade">odv:grade</a>
    /// </summary>
    let grade = _prefixId.prefix "grade"
    /// <summary>
    ///   <para>rdfs:label : Job</para>
    ///   <para>rdfs:comment : The job performed by the junior posts.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/job">odv:job</a>
    /// </summary>
    let job = _prefixId.prefix "job"
    let junior_posts = _prefixId.prefix "junior-posts"
    let number_of_posts = _prefixId.prefix "number-of-posts"
    /// <summary>
    ///   <para>rdfs:label : Number of Posts</para>
    ///   <para>rdfs:comment : The number of posts with this grade that report to the given post, as a full-time equivalent.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/numberOfPosts">odv:numberOfPosts</a>
    /// </summary>
    let numberOfPosts = _prefixId.prefix "numberOfPosts"
    /// <summary>
    ///   <para>rdfs:label : Post</para>
    ///   <para>rdfs:comment : The post whose subordinates this statistic relates to.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/post">odv:post</a>
    /// </summary>
    let post = _prefixId.prefix "post"
    /// <summary>
    ///   <para>rdfs:label : Profession</para>
    ///   <para>rdfs:comment : The profession of the junior posts.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/profession">odv:profession</a>
    /// </summary>
    let profession = _prefixId.prefix "profession"
    /// <summary>
    ///   <para>rdfs:label : Reporting To</para>
    ///   <para>rdfs:comment : The post to which the junior posts report.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/reportingTo">odv:reportingTo</a>
    /// </summary>
    let reportingTo = _prefixId.prefix "reportingTo"
    let salary_costs_of_reports = _prefixId.prefix "salary-costs-of-reports"
    /// <summary>
    ///   <para>rdfs:label : Salary Cost of Reports</para>
    ///   <para>rdfs:comment : The total salary cost of each Deputy Director/SCS Pay Band 1 and 1A member and the non-SCS staff that report to this post. Salary costs are base pay (excluding bonuses and allowances) as at the date of the observation. To ensure that individual salaries cannot be identified from this information (for Deputy Director/SCS Pay Band 1 and 1A level and non-SCS grades), where the team is less than five people, the cost is rounded to the nearest £100,000. Where the team is one person only, the salary cost may be rounded to the nearest £100,000 or merged with the costs of another team.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/salaryCostOfReports">odv:salaryCostOfReports</a>
    /// </summary>
    let salaryCostOfReports = _prefixId.prefix "salaryCostOfReports"
    /// <summary>
    ///   <para>rdfs:label : Tenure</para>
    ///   <para>rdfs:comment : The tenure through which pay was given.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/tenure">odv:tenure</a>
    /// </summary>
    let tenure = _prefixId.prefix "tenure"
    let total_pay = _prefixId.prefix "total-pay"
    /// <summary>
    ///   <para>rdfs:label : Total Pay</para>
    ///   <para>rdfs:comment : The total pay received.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/totalPay">odv:totalPay</a>
    /// </summary>
    let totalPay = _prefixId.prefix "totalPay"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:comment : The unit to which the junior posts belong.</para>
    ///   <a href="http://reference.data.gov.uk/def/organogram/unit">odv:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"

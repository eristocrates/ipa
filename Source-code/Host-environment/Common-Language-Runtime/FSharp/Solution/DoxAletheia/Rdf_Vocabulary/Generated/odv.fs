namespace http.reference.data.gov.uk.def.organogram.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odv =
    let _namespace_iri = Namespace_Iri odv |> NamespaceIRI
    /// <summary>
    ///   <para>odv:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The date that the observation relates to.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/date">http://reference.data.gov.uk/def/organogram/date</seealso>
    let date = Prefixed_Name(odv, "date") |> PrefixedName
    /// <summary>
    ///   <para>odv:profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The profession of the junior posts.</para>
    /// labels<para>Profession</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/profession">http://reference.data.gov.uk/def/organogram/profession</seealso>
    let profession = Prefixed_Name(odv, "profession") |> PrefixedName
    /// <summary>
    ///   <para>odv:fullTimeEquivalent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/fullTimeEquivalent">http://reference.data.gov.uk/def/organogram/fullTimeEquivalent</seealso>
    let fullTimeEquivalent = Prefixed_Name(odv, "fullTimeEquivalent") |> PrefixedName
    /// <summary>
    ///   <para>odv:salaryCostOfReports</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The total salary cost of each Deputy Director/SCS Pay Band 1 and 1A member and the non-SCS staff that report to this post. Salary costs are base pay (excluding bonuses and allowances) as at the date of the observation. To ensure that individual salaries cannot be identified from this information (for Deputy Director/SCS Pay Band 1 and 1A level and non-SCS grades), where the team is less than five people, the cost is rounded to the nearest £100,000. Where the team is one person only, the salary cost may be rounded to the nearest £100,000 or merged with the costs of another team.</para>
    /// labels<para>Salary Cost of Reports</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/salaryCostOfReports">http://reference.data.gov.uk/def/organogram/salaryCostOfReports</seealso>
    let salaryCostOfReports = Prefixed_Name(odv, "salaryCostOfReports") |> PrefixedName
    /// <summary>
    ///   <para>odv:tenure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>The tenure through which pay was given.</para>
    /// labels<para>Tenure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/tenure">http://reference.data.gov.uk/def/organogram/tenure</seealso>
    let tenure = Prefixed_Name(odv, "tenure") |> PrefixedName
    /// <summary>
    ///   <para>odv:total-pay</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>rdfs:Resource</para>
    ///   <para>The structure of a cube containing data about the total pay received for a particular tenure (a person in a post) on a particular day.</para>
    /// labels<para>Total Pay Data Structure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/total-pay">http://reference.data.gov.uk/def/organogram/total-pay</seealso>
    let total_pay = Prefixed_Name(odv, "total-pay") |> PrefixedName
    /// <summary>
    ///   <para>odv:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/">http://reference.data.gov.uk/def/organogram/</seealso>
    let _prefix_iri = Prefixed_Name(odv, "") |> PrefixedName
    /// <summary>
    ///   <para>odv:job</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The job performed by the junior posts.</para>
    /// labels<para>Job</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/job">http://reference.data.gov.uk/def/organogram/job</seealso>
    let job = Prefixed_Name(odv, "job") |> PrefixedName
    /// <summary>
    ///   <para>odv:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The unit to which the junior posts belong.</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/unit">http://reference.data.gov.uk/def/organogram/unit</seealso>
    let unit = Prefixed_Name(odv, "unit") |> PrefixedName
    /// <summary>
    ///   <para>odv:numberOfPosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>The number of posts with this grade that report to the given post, as a full-time equivalent.</para>
    /// labels<para>Number of Posts</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/numberOfPosts">http://reference.data.gov.uk/def/organogram/numberOfPosts</seealso>
    let numberOfPosts = Prefixed_Name(odv, "numberOfPosts") |> PrefixedName
    /// <summary>
    ///   <para>odv:number-of-posts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>The structure of a cube containing data about the number of posts of different grades that report to a particular post on a particular day.</para>
    /// labels<para>Number of Posts Data Structure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/number-of-posts">http://reference.data.gov.uk/def/organogram/number-of-posts</seealso>
    let number_of_posts = Prefixed_Name(odv, "number-of-posts") |> PrefixedName

    /// <summary>
    ///   <para>odv:salary-costs-of-reports</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>The structure of a cube containing data about the salary costs of the reports to a particular post on a particular day.</para>
    /// labels<para>Salary Costs Data Structure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/salary-costs-of-reports">http://reference.data.gov.uk/def/organogram/salary-costs-of-reports</seealso>
    let salary_costs_of_reports =
        Prefixed_Name(odv, "salary-costs-of-reports") |> PrefixedName

    /// <summary>
    ///   <para>odv:grade</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The grade of the junior posts.</para>
    /// labels<para>Grade</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/grade">http://reference.data.gov.uk/def/organogram/grade</seealso>
    let grade = Prefixed_Name(odv, "grade") |> PrefixedName
    /// <summary>
    ///   <para>odv:junior-posts</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>rdfs:Resource</para>
    ///   <para>The structure of a cube containing data about the number of junior staff of different grades that report to a particular post from within a particular unit, with a particular job and a particular profession, on a particular day.</para>
    /// labels<para>Junior Posts Data Structure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/junior-posts">http://reference.data.gov.uk/def/organogram/junior-posts</seealso>
    let junior_posts = Prefixed_Name(odv, "junior-posts") |> PrefixedName
    /// <summary>
    ///   <para>odv:post</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>The post whose subordinates this statistic relates to.</para>
    /// labels<para>Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/post">http://reference.data.gov.uk/def/organogram/post</seealso>
    let post = Prefixed_Name(odv, "post") |> PrefixedName
    /// <summary>
    ///   <para>odv:reportingTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The post to which the junior posts report.</para>
    /// labels<para>Reporting To</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/reportingTo">http://reference.data.gov.uk/def/organogram/reportingTo</seealso>
    let reportingTo = Prefixed_Name(odv, "reportingTo") |> PrefixedName
    /// <summary>
    ///   <para>odv:totalPay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The total pay received.</para>
    /// labels<para>Total Pay</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/totalPay">http://reference.data.gov.uk/def/organogram/totalPay</seealso>
    let totalPay = Prefixed_Name(odv, "totalPay") |> PrefixedName
    /// <summary>
    ///   <para>odv:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:AttributeProperty</para>
    ///   <para>Currency in which the salary is paid, typically attached to the dataset for single currency datasets.</para>
    /// labels<para>currency</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/organogram/currency">http://reference.data.gov.uk/def/organogram/currency</seealso>
    let currency = Prefixed_Name(odv, "currency") |> PrefixedName

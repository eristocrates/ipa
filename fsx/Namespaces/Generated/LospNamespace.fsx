#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module losp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://sparql.sstu.ru:3030/speciality/" "losp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : УровеньПодготовки - подкласс класса "РазделениеЗначений" необходим для задания экземплярам одного из значений: Бакалавриат, Магистратура, Специалитет.^^xsd:stringrdfs:comment : UrovenPodgotovki - subclass SplitValues, needs to define instances of one of the values: Undergraduate, Graduate, Speciality.rdfs:comment : УровеньПодготовки - подкласс класса SplitValues, необходим для задания экземплярам одного из значений: Бакалавриат, Магистратура, Специалитет.</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/LevelEducation">losp:LevelEducation</a>
    /// </summary>
    let LevelEducation = _prefixId.prefix "LevelEducation"
    /// <summary>
    ///   <para>rdfs:comment : Научная специальность входит в направление подготовки аспирантуры^^xsd:stringrdfs:comment : Scientific specialty included in the field of training of postgraduate studyrdfs:comment : Научная специальность входит в направление подготовки аспирантуры</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/ScientificSpeciality">losp:ScientificSpeciality</a>
    /// </summary>
    let ScientificSpeciality = _prefixId.prefix "ScientificSpeciality"
    /// <summary>
    ///   <para>rdfs:comment : Специальность - это наименование конкретного вида профессиональной подготовки, которая завершается присвоением квалификации. Имеет код и название.^^xsd:stringrdfs:comment : Profession - is the name of a specific type of training that is completed qualification. It has the code and name.rdfs:comment : Специальность - это наименование конкретного вида профессиональной подготовки, которая завершается присвоением квалификации. Имеет код и название.</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/Speciality">losp:Speciality</a>
    /// </summary>
    let Speciality = _prefixId.prefix "Speciality"
    /// <summary>
    ///   <para>rdfs:comment : Разделение значений - вспомогательный класс для создания класса "Уровень подготовки".^^xsd:stringrdfs:comment : Splitting Values ​​- helper class for creating a class "level of training" (LevelEducation).rdfs:comment : Разделение значений - вспомогательный класс для создания класса "Уровень подготовки" (LevelEducation).</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/SplitValues">losp:SplitValues</a>
    /// </summary>
    let SplitValues = _prefixId.prefix "SplitValues"
    /// <summary>
    ///   <para>rdfs:comment : Перечень – именованная совокупность специальностей и УГСН, содержащие эти специальности. Перечень имеет название, дату введения и каким утвержден документом.^^xsd:stringrdfs:comment : List - named set of specialties (Speciality) and UGSN (UGSN), containing these specialty. The list has the name, the date of administration, and how the document was approved.rdfs:comment : Перечень – именованная совокупность специальностей (Speciality) и УГСН (UGSN), содержащие эти специальности. Перечень имеет название, дату введения и каким утвержден документом.</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/TheList">losp:TheList</a>
    /// </summary>
    let TheList = _prefixId.prefix "TheList"
    /// <summary>
    ///   <para>rdfs:comment : УГСН – Укрупненные группы специальностей и направлений подготовки объединяют совокупности специальностей и направлений подготовки, относящихся к какой-либо широкой предметной области. Имеет код и название.^^xsd:stringrdfs:comment : UGSN - Enlarged group of specialties and areas of training are combined together specialties and areas of training related to a broad subject area. It has the code and name.rdfs:comment : УГСН – Укрупненные группы специальностей и направлений подготовки объединяют совокупности специальностей и направлений подготовки, относящихся к какой-либо широкой предметной области. Имеет код и название.</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/UGSN">losp:UGSN</a>
    /// </summary>
    let UGSN = _prefixId.prefix "UGSN"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что у определенного УГСН есть составные части (специальности). Доменом является УГСН, диапазоном – специальность, а также оно является обратным свойству «входитВУГСН».^^xsd:stringrdfs:comment : The property that indicates that there is a certain UGSN components (Speciality). Domain is UGSN, range - Speciality, and it is the inverse of the property «isPartOfUGSN».rdfs:comment : Свойство, показывающее, что у определенного UGSN есть составные части (Speciality). Доменом является UGSN, диапазоном – Speciality, а также оно является обратным свойству «isPartOfUGSN».</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/UGSNConsistsOf">losp:UGSNConsistsOf</a>
    /// </summary>
    let UGSNConsistsOf = _prefixId.prefix "UGSNConsistsOf"
    /// <summary>
    ///   <para>rdfs:comment : показывает каким именно документом перечень был утвержден^^xsd:stringrdfs:comment : It shows how the document list (TheList) was approvedrdfs:comment : Показывает каким документом был утвержден перечень (TheList)</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/approvedDocument">losp:approvedDocument</a>
    /// </summary>
    let approvedDocument = _prefixId.prefix "approvedDocument"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что у определенный объекта есть составные части. Является транзитивным и обратным свойству "входитВ".^^xsd:stringrdfs:comment : Property indicating that a certain object is an integral part. It is transitive and inverse property "partOf".rdfs:comment : Свойство, показывающее, что у определенный объекта есть составные части. Является транзитивным и обратным свойству "partOf".</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/consistsOf">losp:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>rdfs:comment : указывает дату, когда был введен перечень^^xsd:stringrdfs:comment : Date of introduction of the list (TheList)rdfs:comment : Дата введения перечня (TheList)</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/dateOfIntroduction">losp:dateOfIntroduction</a>
    /// </summary>
    let dateOfIntroduction = _prefixId.prefix "dateOfIntroduction"
    let equalsTo = _prefixId.prefix "equalsTo"
    /// <summary>
    ///   <para>rdfs:comment : код может быть и у специальностей, и у перечней, поэтому домен не указан^^xsd:stringrdfs:comment : Code identifier specialties (Speciality) and lists (TheList)rdfs:comment : Кодовый идентификатор специальностей (Speciality) и перечней (TheList)</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/hasCode">losp:hasCode</a>
    /// </summary>
    let hasCode = _prefixId.prefix "hasCode"
    /// <summary>
    ///   <para>rdfs:comment : показывает уровеь образования определенной специальности^^xsd:stringrdfs:comment : Shows the level of education (LevelEducation) a particular specialty (Speciality)rdfs:comment : Показывает уровень образования (LevelEducation) определенной специальности (Speciality)</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/hasLevelEducation">losp:hasLevelEducation</a>
    /// </summary>
    let hasLevelEducation = _prefixId.prefix "hasLevelEducation"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что определенная УГСН входит в определенный перечень^^xsd:stringrdfs:comment : Property indicating that a certain UGSN (UGSN) included in a certain list (TheList)rdfs:comment : Свойство, показывающее, что определенная УГСН (UGSN) входит в определенный перечень (TheList)</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/isPartOfList">losp:isPartOfList</a>
    /// </summary>
    let isPartOfList = _prefixId.prefix "isPartOfList"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что научная специальность входит в направление аспирантуры^^xsd:stringrdfs:comment : Cвойство, показывающее, что научная специальность (ScientificSpeciality) входит в направление аспирантурыrdfs:comment : Properties of showing that scientific specialty (ScientificSpeciality) is included in the post-graduate course</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/isPartOfSpeciality">losp:isPartOfSpeciality</a>
    /// </summary>
    let isPartOfSpeciality = _prefixId.prefix "isPartOfSpeciality"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что определенная специальность входит в определенную УГСН. Доменом является специальность, диапазоном – УГСН, а также оно является обратным свойству «УГСНСостоитИз».^^xsd:stringrdfs:comment : Cвойство, показывающее, что определенная специальность (Speciality) входит в определенную УГСН (UGSN). Доменом является специальность (Speciality), диапазоном – УГСН (UGSN), а также оно является обратным свойству «UGSNConsistsOf».rdfs:comment : Перевести
    /// Properties of showing that a particular specialty (Speciality) included in certain UGSN (UGSN). Domain is a specialty (Speciality), range - UGSN (UGSN), and it is the inverse of the property «UGSNConsistsOf».</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/isPartOfUGSN">losp:isPartOfUGSN</a>
    /// </summary>
    let isPartOfUGSN = _prefixId.prefix "isPartOfUGSN"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что у определенного перечня есть составные части (УГСН). Доменом является перечень, диапазоном – УГСН, а также оно является обратным свойству «входитВПеречень».^^xsd:stringrdfs:comment : Cвойство, показывающее, что у определенного перечня (TheList) есть составные части (UGSN). Доменом является перечень (TheList), диапазоном – УГСН (UGSN), а также оно является обратным свойству «isPartOfList».rdfs:comment : Properties of showing that a specific list (TheList) has components (UGSN). Domain is a list of (TheList), range - UGSN (UGSN), and it is the inverse of the property «isPartOfList».</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/listConsistsOf">losp:listConsistsOf</a>
    /// </summary>
    let listConsistsOf = _prefixId.prefix "listConsistsOf"

    let ``lists%2F1%2Fugsn%2F30000'_plus_'`` = _prefixId.prefix "lists%2F1%2Fugsn%2F30000+"

    let ``lists%2F2%2Fspeciality%2F34700'_plus_'%2F1`` = _prefixId.prefix "lists%2F2%2Fspeciality%2F34700+%2F1"

    let ``lists%2F2%2Fugsn%2F30000'_plus_'`` = _prefixId.prefix "lists%2F2%2Fugsn%2F30000+"

    let ``lists%2F3%2Fscientificspeciality%2FSun'_plus_'May'_plus_'27'_plus_'00%3A00%3A00'_plus_'MSD'_plus_'2001%2F4`` =
        _prefixId.prefix "lists%2F3%2Fscientificspeciality%2FSun+May+27+00%3A00%3A00+MSD+2001%2F4"

    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что определенный объект является частью другого объекта. Является транзитивным и обратным свойству "состоитИз".^^xsd:stringrdfs:comment : Property indicating that a certain object is a part of another object. It is transitive and inverse property "consistsOf".rdfs:comment : Свойство, показывающее, что определенный объект является частью другого объекта. Является транзитивным и обратным свойству "consistsOf".</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/partOf">losp:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>rdfs:comment : свойство, показывающее, что у направления аспирантуры  есть научная специальность. Доменом является направление, диапазоном - научная специальность. Обратным свойством является «входитВСпециальность».^^xsd:stringrdfs:comment : The property that indicates that there are areas of postgraduate scientific specialty (ScientificSpeciality). Domain is a specialty (Speciality), range - scientific specialty (ScientificSpeciality). The inverse property is «isPartOfSpeciality».rdfs:comment : Свойство, показывающее, что у направления аспирантуры  есть научная специальность (ScientificSpeciality). Доменом является специальность (Speciality), диапазоном - научная специальность (ScientificSpeciality). Обратным свойством является «isPartOfSpeciality».</para>
    ///   <a href="http://sparql.sstu.ru:3030/speciality/specialityConsistsOf">losp:specialityConsistsOf</a>
    /// </summary>
    let specialityConsistsOf = _prefixId.prefix "specialityConsistsOf"

namespace http.sparql.sstu.ru.speciality.slash

open DoxAletheia

module losp =
    let _namespace_name = "http://sparql.sstu.ru:3030/speciality/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Научная специальность входит в направление подготовки аспирантуры
    /// Scientific specialty included in the field of training of postgraduate study
    /// <see href="http://sparql.sstu.ru:3030/speciality/ScientificSpeciality"></see></summary>
    let ScientificSpeciality = _prefix "ScientificSpeciality"
    /// <summary>
    /// Специальность - это наименование конкретного вида профессиональной подготовки, которая завершается присвоением квалификации. Имеет код и название.
    /// Profession - is the name of a specific type of training that is completed qualification. It has the code and name.
    /// <see href="http://sparql.sstu.ru:3030/speciality/Speciality"></see></summary>
    let Speciality = _prefix "Speciality"
    /// <summary>
    /// Разделение значений - вспомогательный класс для создания класса "Уровень подготовки".
    /// Splitting Values ​​- helper class for creating a class "level of training" (LevelEducation).
    /// <see href="http://sparql.sstu.ru:3030/speciality/SplitValues"></see></summary>
    let SplitValues = _prefix "SplitValues"
    /// <summary>
    /// Перечень – именованная совокупность специальностей и УГСН, содержащие эти специальности. Перечень имеет название, дату введения и каким утвержден документом.
    /// List - named set of specialties (Speciality) and UGSN (UGSN), containing these specialty. The list has the name, the date of administration, and how the document was approved.
    /// <see href="http://sparql.sstu.ru:3030/speciality/TheList"></see></summary>
    let TheList = _prefix "TheList"
    /// <summary>
    /// УГСН – Укрупненные группы специальностей и направлений подготовки объединяют совокупности специальностей и направлений подготовки, относящихся к какой-либо широкой предметной области. Имеет код и название.
    /// UGSN - Enlarged group of specialties and areas of training are combined together specialties and areas of training related to a broad subject area. It has the code and name.
    /// <see href="http://sparql.sstu.ru:3030/speciality/UGSN"></see></summary>
    let UGSN = _prefix "UGSN"
    /// <summary>
    /// УровеньПодготовки - подкласс класса "РазделениеЗначений" необходим для задания экземплярам одного из значений: Бакалавриат, Магистратура, Специалитет.
    /// UrovenPodgotovki - subclass SplitValues, needs to define instances of one of the values: Undergraduate, Graduate, Speciality.
    /// <see href="http://sparql.sstu.ru:3030/speciality/LevelEducation"></see></summary>
    let LevelEducation = _prefix "LevelEducation"
    /// <summary>
    /// свойство, показывающее, что у определенного УГСН есть составные части (специальности). Доменом является УГСН, диапазоном – специальность, а также оно является обратным свойству «входитВУГСН».
    /// The property that indicates that there is a certain UGSN components (Speciality). Domain is UGSN, range - Speciality, and it is the inverse of the property «isPartOfUGSN».
    /// <see href="http://sparql.sstu.ru:3030/speciality/UGSNConsistsOf"></see></summary>
    let UGSNConsistsOf = _prefix "UGSNConsistsOf"
    /// <summary>
    /// свойство, показывающее, что у определенный объекта есть составные части. Является транзитивным и обратным свойству "входитВ".
    /// Property indicating that a certain object is an integral part. It is transitive and inverse property "partOf".
    /// <see href="http://sparql.sstu.ru:3030/speciality/consistsOf"></see></summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    /// свойство, показывающее, что определенная специальность входит в определенную УГСН. Доменом является специальность, диапазоном – УГСН, а также оно является обратным свойству «УГСНСостоитИз».
    /// Перевести
    /// Properties of showing that a particular specialty (Speciality) included in certain UGSN (UGSN). Domain is a specialty (Speciality), range - UGSN (UGSN), and it is the inverse of the property «UGSNConsistsOf».
    /// <see href="http://sparql.sstu.ru:3030/speciality/isPartOfUGSN"></see></summary>
    let isPartOfUGSN = _prefix "isPartOfUGSN"
    /// <summary>
    /// показывает каким именно документом перечень был утвержден
    /// It shows how the document list (TheList) was approved
    /// <see href="http://sparql.sstu.ru:3030/speciality/approvedDocument"></see></summary>
    let approvedDocument = _prefix "approvedDocument"
    /// <summary>
    /// свойство, показывающее, что определенный объект является частью другого объекта. Является транзитивным и обратным свойству "состоитИз".
    /// Property indicating that a certain object is a part of another object. It is transitive and inverse property "consistsOf".
    /// <see href="http://sparql.sstu.ru:3030/speciality/partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// указывает дату, когда был введен перечень
    /// Date of introduction of the list (TheList)
    /// <see href="http://sparql.sstu.ru:3030/speciality/dateOfIntroduction"></see></summary>
    let dateOfIntroduction = _prefix "dateOfIntroduction"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/equalsTo"></see>
    /// </summary>
    let equalsTo = _prefix "equalsTo"
    /// <summary>
    /// код может быть и у специальностей, и у перечней, поэтому домен не указан
    /// Code identifier specialties (Speciality) and lists (TheList)
    /// <see href="http://sparql.sstu.ru:3030/speciality/hasCode"></see></summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    /// показывает уровеь образования определенной специальности
    /// Shows the level of education (LevelEducation) a particular specialty (Speciality)
    /// <see href="http://sparql.sstu.ru:3030/speciality/hasLevelEducation"></see></summary>
    let hasLevelEducation = _prefix "hasLevelEducation"
    /// <summary>
    /// свойство, показывающее, что определенная УГСН входит в определенный перечень
    /// Property indicating that a certain UGSN (UGSN) included in a certain list (TheList)
    /// <see href="http://sparql.sstu.ru:3030/speciality/isPartOfList"></see></summary>
    let isPartOfList = _prefix "isPartOfList"
    /// <summary>
    /// свойство, показывающее, что у определенного перечня есть составные части (УГСН). Доменом является перечень, диапазоном – УГСН, а также оно является обратным свойству «входитВПеречень».
    /// Properties of showing that a specific list (TheList) has components (UGSN). Domain is a list of (TheList), range - UGSN (UGSN), and it is the inverse of the property «isPartOfList».
    /// <see href="http://sparql.sstu.ru:3030/speciality/listConsistsOf"></see></summary>
    let listConsistsOf = _prefix "listConsistsOf"
    /// <summary>
    /// свойство, показывающее, что научная специальность входит в направление аспирантуры
    /// Properties of showing that scientific specialty (ScientificSpeciality) is included in the post-graduate course
    /// <see href="http://sparql.sstu.ru:3030/speciality/isPartOfSpeciality"></see></summary>
    let isPartOfSpeciality = _prefix "isPartOfSpeciality"
    /// <summary>
    /// свойство, показывающее, что у направления аспирантуры  есть научная специальность. Доменом является направление, диапазоном - научная специальность. Обратным свойством является «входитВСпециальность».
    /// The property that indicates that there are areas of postgraduate scientific specialty (ScientificSpeciality). Domain is a specialty (Speciality), range - scientific specialty (ScientificSpeciality). The inverse property is «isPartOfSpeciality».
    /// <see href="http://sparql.sstu.ru:3030/speciality/specialityConsistsOf"></see></summary>
    let specialityConsistsOf = _prefix "specialityConsistsOf"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/level/1"></see>
    /// </summary>
    let ``level/1`` = _prefix "level/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/level/2"></see>
    /// </summary>
    let ``level/2`` = _prefix "level/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/level/3"></see>
    /// </summary>
    let ``level/3`` = _prefix "level/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/level/4"></see>
    /// </summary>
    let ``level/4`` = _prefix "level/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists%2F1%2Fugsn%2F30000+"></see>
    /// </summary>
    let ``lists%2F1%2Fugsn%2F30000+`` = _prefix "lists%2F1%2Fugsn%2F30000+"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030402/2"></see>
    /// </summary>
    let ``lists/1/speciality/030402/2`` = _prefix "lists/1/speciality/030402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1"></see>
    /// </summary>
    let ``lists/1`` = _prefix "lists/1"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists%2F2%2Fspeciality%2F34700+%2F1"></see>
    /// </summary>
    let ``lists%2F2%2Fspeciality%2F34700+%2F1`` =
        _prefix "lists%2F2%2Fspeciality%2F34700+%2F1"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.03.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/02.03.20/1`` = _prefix "lists/3/speciality/02.03.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists%2F2%2Fugsn%2F30000+"></see>
    /// </summary>
    let ``lists%2F2%2Fugsn%2F30000+`` = _prefix "lists%2F2%2Fugsn%2F30000+"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2"></see>
    /// </summary>
    let ``lists/2`` = _prefix "lists/2"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists%2F3%2Fscientificspeciality%2FSun+May+27+00%3A00%3A00+MSD+2001%2F4"></see>
    /// </summary>
    let ``lists%2F3%2Fscientificspeciality%2FSun+May+27+00%3A00%3A00+MSD+2001%2F4`` =
        _prefix "lists%2F3%2Fscientificspeciality%2FSun+May+27+00%3A00%3A00+MSD+2001%2F4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010100/1"></see>
    /// </summary>
    let ``lists/1/speciality/010100/1`` = _prefix "lists/1/speciality/010100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010100/1"></see>
    /// </summary>
    let ``lists/2/speciality/010100/1`` = _prefix "lists/2/speciality/010100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/01.03.01/1`` = _prefix "lists/3/speciality/01.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/010000"></see>
    /// </summary>
    let ``lists/1/ugsn/010000`` = _prefix "lists/1/ugsn/010000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010100/3"></see>
    /// </summary>
    let ``lists/1/speciality/010100/3`` = _prefix "lists/1/speciality/010100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010100/3"></see>
    /// </summary>
    let ``lists/2/speciality/010100/3`` = _prefix "lists/2/speciality/010100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/01.04.01/3`` = _prefix "lists/3/speciality/01.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010101/2"></see>
    /// </summary>
    let ``lists/1/speciality/010101/2`` = _prefix "lists/1/speciality/010101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010200/1"></see>
    /// </summary>
    let ``lists/1/speciality/010200/1`` = _prefix "lists/1/speciality/010200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010200/1"></see>
    /// </summary>
    let ``lists/2/speciality/010200/1`` = _prefix "lists/2/speciality/010200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/02.03.01/1`` = _prefix "lists/3/speciality/02.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010200/3"></see>
    /// </summary>
    let ``lists/1/speciality/010200/3`` = _prefix "lists/1/speciality/010200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/02.04.01/3`` = _prefix "lists/3/speciality/02.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010200/3"></see>
    /// </summary>
    let ``lists/2/speciality/010200/3`` = _prefix "lists/2/speciality/010200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010300/1"></see>
    /// </summary>
    let ``lists/1/speciality/010300/1`` = _prefix "lists/1/speciality/010300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010300/3"></see>
    /// </summary>
    let ``lists/1/speciality/010300/3`` = _prefix "lists/1/speciality/010300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010400/1"></see>
    /// </summary>
    let ``lists/1/speciality/010400/1`` = _prefix "lists/1/speciality/010400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010300/1"></see>
    /// </summary>
    let ``lists/2/speciality/010300/1`` = _prefix "lists/2/speciality/010300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/02.03.02/1`` = _prefix "lists/3/speciality/02.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010400/3"></see>
    /// </summary>
    let ``lists/1/speciality/010400/3`` = _prefix "lists/1/speciality/010400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010300/3"></see>
    /// </summary>
    let ``lists/2/speciality/010300/3`` = _prefix "lists/2/speciality/010300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/02.04.02/3`` = _prefix "lists/3/speciality/02.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010500/1"></see>
    /// </summary>
    let ``lists/1/speciality/010500/1`` = _prefix "lists/1/speciality/010500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010400/1"></see>
    /// </summary>
    let ``lists/2/speciality/010400/1`` = _prefix "lists/2/speciality/010400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/01.03.02/1`` = _prefix "lists/3/speciality/01.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010500/3"></see>
    /// </summary>
    let ``lists/1/speciality/010500/3`` = _prefix "lists/1/speciality/010500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010400/3"></see>
    /// </summary>
    let ``lists/2/speciality/010400/3`` = _prefix "lists/2/speciality/010400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/01.04.02/3`` = _prefix "lists/3/speciality/01.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010501/2"></see>
    /// </summary>
    let ``lists/1/speciality/010501/2`` = _prefix "lists/1/speciality/010501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010503/2"></see>
    /// </summary>
    let ``lists/1/speciality/010503/2`` = _prefix "lists/1/speciality/010503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010500/1"></see>
    /// </summary>
    let ``lists/2/speciality/010500/1`` = _prefix "lists/2/speciality/010500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/02.03.03/1`` = _prefix "lists/3/speciality/02.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010600/1"></see>
    /// </summary>
    let ``lists/1/speciality/010600/1`` = _prefix "lists/1/speciality/010600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010900/1"></see>
    /// </summary>
    let ``lists/2/speciality/010900/1`` = _prefix "lists/2/speciality/010900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/03.03.01/1`` = _prefix "lists/3/speciality/03.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010600/3"></see>
    /// </summary>
    let ``lists/1/speciality/010600/3`` = _prefix "lists/1/speciality/010600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010900/3"></see>
    /// </summary>
    let ``lists/2/speciality/010900/3`` = _prefix "lists/2/speciality/010900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/03.04.01/3`` = _prefix "lists/3/speciality/03.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010700/1"></see>
    /// </summary>
    let ``lists/1/speciality/010700/1`` = _prefix "lists/1/speciality/010700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/011200/1"></see>
    /// </summary>
    let ``lists/2/speciality/011200/1`` = _prefix "lists/2/speciality/011200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/03.03.02/1`` = _prefix "lists/3/speciality/03.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010700/3"></see>
    /// </summary>
    let ``lists/1/speciality/010700/3`` = _prefix "lists/1/speciality/010700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/011200/3"></see>
    /// </summary>
    let ``lists/2/speciality/011200/3`` = _prefix "lists/2/speciality/011200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/03.04.02/3`` = _prefix "lists/3/speciality/03.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010701/2"></see>
    /// </summary>
    let ``lists/1/speciality/010701/2`` = _prefix "lists/1/speciality/010701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010703/2"></see>
    /// </summary>
    let ``lists/1/speciality/010703/2`` = _prefix "lists/1/speciality/010703/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010704/2"></see>
    /// </summary>
    let ``lists/1/speciality/010704/2`` = _prefix "lists/1/speciality/010704/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010705/2"></see>
    /// </summary>
    let ``lists/1/speciality/010705/2`` = _prefix "lists/1/speciality/010705/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010706/2"></see>
    /// </summary>
    let ``lists/1/speciality/010706/2`` = _prefix "lists/1/speciality/010706/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010707/2"></see>
    /// </summary>
    let ``lists/1/speciality/010707/2`` = _prefix "lists/1/speciality/010707/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010708/2"></see>
    /// </summary>
    let ``lists/1/speciality/010708/2`` = _prefix "lists/1/speciality/010708/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010710/2"></see>
    /// </summary>
    let ``lists/1/speciality/010710/2`` = _prefix "lists/1/speciality/010710/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010800/1"></see>
    /// </summary>
    let ``lists/1/speciality/010800/1`` = _prefix "lists/1/speciality/010800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/011800/1"></see>
    /// </summary>
    let ``lists/2/speciality/011800/1`` = _prefix "lists/2/speciality/011800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/03.03.03/1`` = _prefix "lists/3/speciality/03.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010800/3"></see>
    /// </summary>
    let ``lists/1/speciality/010800/3`` = _prefix "lists/1/speciality/010800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/011800/3"></see>
    /// </summary>
    let ``lists/2/speciality/011800/3`` = _prefix "lists/2/speciality/011800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/03.04.03/3`` = _prefix "lists/3/speciality/03.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010801/2"></see>
    /// </summary>
    let ``lists/1/speciality/010801/2`` = _prefix "lists/1/speciality/010801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010803/2"></see>
    /// </summary>
    let ``lists/1/speciality/010803/2`` = _prefix "lists/1/speciality/010803/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010900/1"></see>
    /// </summary>
    let ``lists/1/speciality/010900/1`` = _prefix "lists/1/speciality/010900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010800/1"></see>
    /// </summary>
    let ``lists/2/speciality/010800/1`` = _prefix "lists/2/speciality/010800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/01.03.03/1`` = _prefix "lists/3/speciality/01.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010900/3"></see>
    /// </summary>
    let ``lists/1/speciality/010900/3`` = _prefix "lists/1/speciality/010900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010800/3"></see>
    /// </summary>
    let ``lists/2/speciality/010800/3`` = _prefix "lists/2/speciality/010800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/01.04.03/3`` = _prefix "lists/3/speciality/01.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/010901/2"></see>
    /// </summary>
    let ``lists/1/speciality/010901/2`` = _prefix "lists/1/speciality/010901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/011000/1"></see>
    /// </summary>
    let ``lists/1/speciality/011000/1`` = _prefix "lists/1/speciality/011000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/011000/3"></see>
    /// </summary>
    let ``lists/1/speciality/011000/3`` = _prefix "lists/1/speciality/011000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020100/1"></see>
    /// </summary>
    let ``lists/1/speciality/020100/1`` = _prefix "lists/1/speciality/020100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020100/1"></see>
    /// </summary>
    let ``lists/2/speciality/020100/1`` = _prefix "lists/2/speciality/020100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/04.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/04.03.01/1`` = _prefix "lists/3/speciality/04.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/020000"></see>
    /// </summary>
    let ``lists/1/ugsn/020000`` = _prefix "lists/1/ugsn/020000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020100/3"></see>
    /// </summary>
    let ``lists/1/speciality/020100/3`` = _prefix "lists/1/speciality/020100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020100/3"></see>
    /// </summary>
    let ``lists/2/speciality/020100/3`` = _prefix "lists/2/speciality/020100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/04.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/04.04.01/3`` = _prefix "lists/3/speciality/04.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020101/2"></see>
    /// </summary>
    let ``lists/1/speciality/020101/2`` = _prefix "lists/1/speciality/020101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020200/1"></see>
    /// </summary>
    let ``lists/1/speciality/020200/1`` = _prefix "lists/1/speciality/020200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020400/1"></see>
    /// </summary>
    let ``lists/2/speciality/020400/1`` = _prefix "lists/2/speciality/020400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/06.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/06.03.01/1`` = _prefix "lists/3/speciality/06.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020200/3"></see>
    /// </summary>
    let ``lists/1/speciality/020200/3`` = _prefix "lists/1/speciality/020200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020400/3"></see>
    /// </summary>
    let ``lists/2/speciality/020400/3`` = _prefix "lists/2/speciality/020400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/06.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/06.04.01/3`` = _prefix "lists/3/speciality/06.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020201/2"></see>
    /// </summary>
    let ``lists/1/speciality/020201/2`` = _prefix "lists/1/speciality/020201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020202/2"></see>
    /// </summary>
    let ``lists/1/speciality/020202/2`` = _prefix "lists/1/speciality/020202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020203/2"></see>
    /// </summary>
    let ``lists/1/speciality/020203/2`` = _prefix "lists/1/speciality/020203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020204/2"></see>
    /// </summary>
    let ``lists/1/speciality/020204/2`` = _prefix "lists/1/speciality/020204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020205/2"></see>
    /// </summary>
    let ``lists/1/speciality/020205/2`` = _prefix "lists/1/speciality/020205/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020206/2"></see>
    /// </summary>
    let ``lists/1/speciality/020206/2`` = _prefix "lists/1/speciality/020206/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020207/2"></see>
    /// </summary>
    let ``lists/1/speciality/020207/2`` = _prefix "lists/1/speciality/020207/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020208/2"></see>
    /// </summary>
    let ``lists/1/speciality/020208/2`` = _prefix "lists/1/speciality/020208/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020209/2"></see>
    /// </summary>
    let ``lists/1/speciality/020209/2`` = _prefix "lists/1/speciality/020209/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020300/1"></see>
    /// </summary>
    let ``lists/1/speciality/020300/1`` = _prefix "lists/1/speciality/020300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020700/1"></see>
    /// </summary>
    let ``lists/2/speciality/020700/1`` = _prefix "lists/2/speciality/020700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.01/1`` = _prefix "lists/3/speciality/05.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020300/3"></see>
    /// </summary>
    let ``lists/1/speciality/020300/3`` = _prefix "lists/1/speciality/020300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020700/3"></see>
    /// </summary>
    let ``lists/2/speciality/020700/3`` = _prefix "lists/2/speciality/020700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/05.04.01/3`` = _prefix "lists/3/speciality/05.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020301/2"></see>
    /// </summary>
    let ``lists/1/speciality/020301/2`` = _prefix "lists/1/speciality/020301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020302/2"></see>
    /// </summary>
    let ``lists/1/speciality/020302/2`` = _prefix "lists/1/speciality/020302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020303/2"></see>
    /// </summary>
    let ``lists/1/speciality/020303/2`` = _prefix "lists/1/speciality/020303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020304/2"></see>
    /// </summary>
    let ``lists/1/speciality/020304/2`` = _prefix "lists/1/speciality/020304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020305/2"></see>
    /// </summary>
    let ``lists/1/speciality/020305/2`` = _prefix "lists/1/speciality/020305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020306/2"></see>
    /// </summary>
    let ``lists/1/speciality/020306/2`` = _prefix "lists/1/speciality/020306/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020400/1"></see>
    /// </summary>
    let ``lists/1/speciality/020400/1`` = _prefix "lists/1/speciality/020400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021000/1"></see>
    /// </summary>
    let ``lists/2/speciality/021000/1`` = _prefix "lists/2/speciality/021000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.02/1`` = _prefix "lists/3/speciality/05.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020400/3"></see>
    /// </summary>
    let ``lists/1/speciality/020400/3`` = _prefix "lists/1/speciality/020400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021000/3"></see>
    /// </summary>
    let ``lists/2/speciality/021000/3`` = _prefix "lists/2/speciality/021000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/05.04.02/3`` = _prefix "lists/3/speciality/05.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020401/2"></see>
    /// </summary>
    let ``lists/1/speciality/020401/2`` = _prefix "lists/1/speciality/020401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020500/1"></see>
    /// </summary>
    let ``lists/1/speciality/020500/1`` = _prefix "lists/1/speciality/020500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021300/1"></see>
    /// </summary>
    let ``lists/2/speciality/021300/1`` = _prefix "lists/2/speciality/021300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.03/1`` = _prefix "lists/3/speciality/05.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020500/3"></see>
    /// </summary>
    let ``lists/1/speciality/020500/3`` = _prefix "lists/1/speciality/020500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021300/3"></see>
    /// </summary>
    let ``lists/2/speciality/021300/3`` = _prefix "lists/2/speciality/021300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/05.04.03/3`` = _prefix "lists/3/speciality/05.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020501/2"></see>
    /// </summary>
    let ``lists/1/speciality/020501/2`` = _prefix "lists/1/speciality/020501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020600/1"></see>
    /// </summary>
    let ``lists/1/speciality/020600/1`` = _prefix "lists/1/speciality/020600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.05/1`` = _prefix "lists/3/speciality/05.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/280400/1"></see>
    /// </summary>
    let ``lists/2/speciality/280400/1`` = _prefix "lists/2/speciality/280400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.04/1`` = _prefix "lists/3/speciality/05.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021600/1"></see>
    /// </summary>
    let ``lists/2/speciality/021600/1`` = _prefix "lists/2/speciality/021600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020600/3"></see>
    /// </summary>
    let ``lists/1/speciality/020600/3`` = _prefix "lists/1/speciality/020600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/05.04.05/3`` = _prefix "lists/3/speciality/05.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/280400/3"></see>
    /// </summary>
    let ``lists/2/speciality/280400/3`` = _prefix "lists/2/speciality/280400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/05.04.04/3`` = _prefix "lists/3/speciality/05.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021600/3"></see>
    /// </summary>
    let ``lists/2/speciality/021600/3`` = _prefix "lists/2/speciality/021600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020601/2"></see>
    /// </summary>
    let ``lists/1/speciality/020601/2`` = _prefix "lists/1/speciality/020601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020602/2"></see>
    /// </summary>
    let ``lists/1/speciality/020602/2`` = _prefix "lists/1/speciality/020602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020603/2"></see>
    /// </summary>
    let ``lists/1/speciality/020603/2`` = _prefix "lists/1/speciality/020603/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020700/1"></see>
    /// </summary>
    let ``lists/1/speciality/020700/1`` = _prefix "lists/1/speciality/020700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021900/1"></see>
    /// </summary>
    let ``lists/2/speciality/021900/1`` = _prefix "lists/2/speciality/021900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/06.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/06.03.02/1`` = _prefix "lists/3/speciality/06.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020700/3"></see>
    /// </summary>
    let ``lists/1/speciality/020700/3`` = _prefix "lists/1/speciality/020700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/021900/3"></see>
    /// </summary>
    let ``lists/2/speciality/021900/3`` = _prefix "lists/2/speciality/021900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/06.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/06.04.02/3`` = _prefix "lists/3/speciality/06.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020701/2"></see>
    /// </summary>
    let ``lists/1/speciality/020701/2`` = _prefix "lists/1/speciality/020701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020800/1"></see>
    /// </summary>
    let ``lists/1/speciality/020800/1`` = _prefix "lists/1/speciality/020800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/022000/1"></see>
    /// </summary>
    let ``lists/2/speciality/022000/1`` = _prefix "lists/2/speciality/022000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.06/1`` = _prefix "lists/3/speciality/05.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020800/3"></see>
    /// </summary>
    let ``lists/1/speciality/020800/3`` = _prefix "lists/1/speciality/020800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/05.04.06/3`` = _prefix "lists/3/speciality/05.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/022000/3"></see>
    /// </summary>
    let ``lists/2/speciality/022000/3`` = _prefix "lists/2/speciality/022000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020801/2"></see>
    /// </summary>
    let ``lists/1/speciality/020801/2`` = _prefix "lists/1/speciality/020801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020802/2"></see>
    /// </summary>
    let ``lists/1/speciality/020802/2`` = _prefix "lists/1/speciality/020802/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020803/2"></see>
    /// </summary>
    let ``lists/1/speciality/020803/2`` = _prefix "lists/1/speciality/020803/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020804/2"></see>
    /// </summary>
    let ``lists/1/speciality/020804/2`` = _prefix "lists/1/speciality/020804/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020900/1"></see>
    /// </summary>
    let ``lists/1/speciality/020900/1`` = _prefix "lists/1/speciality/020900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020300/1"></see>
    /// </summary>
    let ``lists/2/speciality/020300/1`` = _prefix "lists/2/speciality/020300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/04.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/04.03.02/1`` = _prefix "lists/3/speciality/04.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/020900/3"></see>
    /// </summary>
    let ``lists/1/speciality/020900/3`` = _prefix "lists/1/speciality/020900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/04.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/04.04.02/3`` = _prefix "lists/3/speciality/04.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/022200/3"></see>
    /// </summary>
    let ``lists/2/speciality/022200/3`` = _prefix "lists/2/speciality/022200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/020300/3"></see>
    /// </summary>
    let ``lists/2/speciality/020300/3`` = _prefix "lists/2/speciality/020300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/28.04.04/3`` = _prefix "lists/3/speciality/28.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030100/1"></see>
    /// </summary>
    let ``lists/1/speciality/030100/1`` = _prefix "lists/1/speciality/030100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030100/1"></see>
    /// </summary>
    let ``lists/2/speciality/030100/1`` = _prefix "lists/2/speciality/030100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/47.03.01/1`` = _prefix "lists/3/speciality/47.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/030000"></see>
    /// </summary>
    let ``lists/1/ugsn/030000`` = _prefix "lists/1/ugsn/030000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030100/3"></see>
    /// </summary>
    let ``lists/1/speciality/030100/3`` = _prefix "lists/1/speciality/030100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030100/3"></see>
    /// </summary>
    let ``lists/2/speciality/030100/3`` = _prefix "lists/2/speciality/030100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/47.04.01/3`` = _prefix "lists/3/speciality/47.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030101/2"></see>
    /// </summary>
    let ``lists/1/speciality/030101/2`` = _prefix "lists/1/speciality/030101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030200/1"></see>
    /// </summary>
    let ``lists/1/speciality/030200/1`` = _prefix "lists/1/speciality/030200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030200/1"></see>
    /// </summary>
    let ``lists/2/speciality/030200/1`` = _prefix "lists/2/speciality/030200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/41.03.04/1`` = _prefix "lists/3/speciality/41.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030200/3"></see>
    /// </summary>
    let ``lists/1/speciality/030200/3`` = _prefix "lists/1/speciality/030200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030200/3"></see>
    /// </summary>
    let ``lists/2/speciality/030200/3`` = _prefix "lists/2/speciality/030200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/41.04.04/3`` = _prefix "lists/3/speciality/41.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030201/2"></see>
    /// </summary>
    let ``lists/1/speciality/030201/2`` = _prefix "lists/1/speciality/030201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030300/1"></see>
    /// </summary>
    let ``lists/1/speciality/030300/1`` = _prefix "lists/1/speciality/030300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030300/1"></see>
    /// </summary>
    let ``lists/2/speciality/030300/1`` = _prefix "lists/2/speciality/030300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/37.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/37.03.01/1`` = _prefix "lists/3/speciality/37.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030300/3"></see>
    /// </summary>
    let ``lists/1/speciality/030300/3`` = _prefix "lists/1/speciality/030300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/37.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/37.04.01/3`` = _prefix "lists/3/speciality/37.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/050400/3"></see>
    /// </summary>
    let ``lists/2/speciality/050400/3`` = _prefix "lists/2/speciality/050400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/44.04.02/3`` = _prefix "lists/3/speciality/44.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030300/3"></see>
    /// </summary>
    let ``lists/2/speciality/030300/3`` = _prefix "lists/2/speciality/030300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030301/2"></see>
    /// </summary>
    let ``lists/1/speciality/030301/2`` = _prefix "lists/1/speciality/030301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030400/1"></see>
    /// </summary>
    let ``lists/1/speciality/030400/1`` = _prefix "lists/1/speciality/030400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030600/1"></see>
    /// </summary>
    let ``lists/2/speciality/030600/1`` = _prefix "lists/2/speciality/030600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/46.03.01/1`` = _prefix "lists/3/speciality/46.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030400/3"></see>
    /// </summary>
    let ``lists/1/speciality/030400/3`` = _prefix "lists/1/speciality/030400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030600/3"></see>
    /// </summary>
    let ``lists/2/speciality/030600/3`` = _prefix "lists/2/speciality/030600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/46.04.01/3`` = _prefix "lists/3/speciality/46.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030401/2"></see>
    /// </summary>
    let ``lists/1/speciality/030401/2`` = _prefix "lists/1/speciality/030401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/34700+/1"></see>
    /// </summary>
    let ``lists/2/speciality/34700+/1`` = _prefix "lists/2/speciality/34700+/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/30000+"></see>
    /// </summary>
    let ``lists/1/ugsn/30000+`` = _prefix "lists/1/ugsn/30000+"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030500/1"></see>
    /// </summary>
    let ``lists/1/speciality/030500/1`` = _prefix "lists/1/speciality/030500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030900/1"></see>
    /// </summary>
    let ``lists/2/speciality/030900/1`` = _prefix "lists/2/speciality/030900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/40.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/40.03.01/1`` = _prefix "lists/3/speciality/40.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030500/3"></see>
    /// </summary>
    let ``lists/1/speciality/030500/3`` = _prefix "lists/1/speciality/030500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/030900/3"></see>
    /// </summary>
    let ``lists/2/speciality/030900/3`` = _prefix "lists/2/speciality/030900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/40.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/40.04.01/3`` = _prefix "lists/3/speciality/40.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030501/2"></see>
    /// </summary>
    let ``lists/1/speciality/030501/2`` = _prefix "lists/1/speciality/030501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030600/1"></see>
    /// </summary>
    let ``lists/1/speciality/030600/1`` = _prefix "lists/1/speciality/030600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/031300/1"></see>
    /// </summary>
    let ``lists/2/speciality/031300/1`` = _prefix "lists/2/speciality/031300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/42.03.02/1`` = _prefix "lists/3/speciality/42.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030600/3"></see>
    /// </summary>
    let ``lists/1/speciality/030600/3`` = _prefix "lists/1/speciality/030600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/031300/3"></see>
    /// </summary>
    let ``lists/2/speciality/031300/3`` = _prefix "lists/2/speciality/031300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/42.04.02/3`` = _prefix "lists/3/speciality/42.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030601/2"></see>
    /// </summary>
    let ``lists/1/speciality/030601/2`` = _prefix "lists/1/speciality/030601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030602/2"></see>
    /// </summary>
    let ``lists/1/speciality/030602/2`` = _prefix "lists/1/speciality/030602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/031600/1"></see>
    /// </summary>
    let ``lists/2/speciality/031600/1`` = _prefix "lists/2/speciality/031600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/42.03.01/1`` = _prefix "lists/3/speciality/42.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030700/1"></see>
    /// </summary>
    let ``lists/1/speciality/030700/1`` = _prefix "lists/1/speciality/030700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/031900/1"></see>
    /// </summary>
    let ``lists/2/speciality/031900/1`` = _prefix "lists/2/speciality/031900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/41.03.05/1`` = _prefix "lists/3/speciality/41.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030700/3"></see>
    /// </summary>
    let ``lists/1/speciality/030700/3`` = _prefix "lists/1/speciality/030700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/031900/3"></see>
    /// </summary>
    let ``lists/2/speciality/031900/3`` = _prefix "lists/2/speciality/031900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/41.04.05/3`` = _prefix "lists/3/speciality/41.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030701/2"></see>
    /// </summary>
    let ``lists/1/speciality/030701/2`` = _prefix "lists/1/speciality/030701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030800/1"></see>
    /// </summary>
    let ``lists/1/speciality/030800/1`` = _prefix "lists/1/speciality/030800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032100/1"></see>
    /// </summary>
    let ``lists/2/speciality/032100/1`` = _prefix "lists/2/speciality/032100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/41.03.03/1`` = _prefix "lists/3/speciality/41.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030800/3"></see>
    /// </summary>
    let ``lists/1/speciality/030800/3`` = _prefix "lists/1/speciality/030800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032100/3"></see>
    /// </summary>
    let ``lists/2/speciality/032100/3`` = _prefix "lists/2/speciality/032100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/41.04.03/3`` = _prefix "lists/3/speciality/41.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030801/2"></see>
    /// </summary>
    let ``lists/1/speciality/030801/2`` = _prefix "lists/1/speciality/030801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030900/1"></see>
    /// </summary>
    let ``lists/1/speciality/030900/1`` = _prefix "lists/1/speciality/030900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035000/1"></see>
    /// </summary>
    let ``lists/2/speciality/035000/1`` = _prefix "lists/2/speciality/035000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/42.03.03/1`` = _prefix "lists/3/speciality/42.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030900/3"></see>
    /// </summary>
    let ``lists/1/speciality/030900/3`` = _prefix "lists/1/speciality/030900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035000/3"></see>
    /// </summary>
    let ``lists/2/speciality/035000/3`` = _prefix "lists/2/speciality/035000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/42.04.03/3`` = _prefix "lists/3/speciality/42.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030901/2"></see>
    /// </summary>
    let ``lists/1/speciality/030901/2`` = _prefix "lists/1/speciality/030901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/030903/2"></see>
    /// </summary>
    let ``lists/1/speciality/030903/2`` = _prefix "lists/1/speciality/030903/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031000/1"></see>
    /// </summary>
    let ``lists/1/speciality/031000/1`` = _prefix "lists/1/speciality/031000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032700/1"></see>
    /// </summary>
    let ``lists/2/speciality/032700/1`` = _prefix "lists/2/speciality/032700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/45.03.01/1`` = _prefix "lists/3/speciality/45.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031000/3"></see>
    /// </summary>
    let ``lists/1/speciality/031000/3`` = _prefix "lists/1/speciality/031000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032700/3"></see>
    /// </summary>
    let ``lists/2/speciality/032700/3`` = _prefix "lists/2/speciality/032700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/45.04.01/3`` = _prefix "lists/3/speciality/45.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031001/2"></see>
    /// </summary>
    let ``lists/1/speciality/031001/2`` = _prefix "lists/1/speciality/031001/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031100/1"></see>
    /// </summary>
    let ``lists/1/speciality/031100/1`` = _prefix "lists/1/speciality/031100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035700/1"></see>
    /// </summary>
    let ``lists/2/speciality/035700/1`` = _prefix "lists/2/speciality/035700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/45.03.02/1`` = _prefix "lists/3/speciality/45.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031100/3"></see>
    /// </summary>
    let ``lists/1/speciality/031100/3`` = _prefix "lists/1/speciality/031100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035700/3"></see>
    /// </summary>
    let ``lists/2/speciality/035700/3`` = _prefix "lists/2/speciality/035700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/45.04.02/3`` = _prefix "lists/3/speciality/45.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031201/2"></see>
    /// </summary>
    let ``lists/1/speciality/031201/2`` = _prefix "lists/1/speciality/031201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031202/2"></see>
    /// </summary>
    let ``lists/1/speciality/031202/2`` = _prefix "lists/1/speciality/031202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031203/2"></see>
    /// </summary>
    let ``lists/1/speciality/031203/2`` = _prefix "lists/1/speciality/031203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031301/2"></see>
    /// </summary>
    let ``lists/1/speciality/031301/2`` = _prefix "lists/1/speciality/031301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/45.03.03/1`` = _prefix "lists/3/speciality/45.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035800/1"></see>
    /// </summary>
    let ``lists/2/speciality/035800/1`` = _prefix "lists/2/speciality/035800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031302/2"></see>
    /// </summary>
    let ``lists/1/speciality/031302/2`` = _prefix "lists/1/speciality/031302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/036000/1"></see>
    /// </summary>
    let ``lists/2/speciality/036000/1`` = _prefix "lists/2/speciality/036000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/45.03.04/1`` = _prefix "lists/3/speciality/45.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031400/1"></see>
    /// </summary>
    let ``lists/1/speciality/031400/1`` = _prefix "lists/1/speciality/031400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033000/1"></see>
    /// </summary>
    let ``lists/2/speciality/033000/1`` = _prefix "lists/2/speciality/033000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/51.03.01/1`` = _prefix "lists/3/speciality/51.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031400/3"></see>
    /// </summary>
    let ``lists/1/speciality/031400/3`` = _prefix "lists/1/speciality/031400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033000/3"></see>
    /// </summary>
    let ``lists/2/speciality/033000/3`` = _prefix "lists/2/speciality/033000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/51.04.01/3`` = _prefix "lists/3/speciality/51.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031401/2"></see>
    /// </summary>
    let ``lists/1/speciality/031401/2`` = _prefix "lists/1/speciality/031401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031500/1"></see>
    /// </summary>
    let ``lists/1/speciality/031500/1`` = _prefix "lists/1/speciality/031500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/50.03.03/1`` = _prefix "lists/3/speciality/50.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035400/1"></see>
    /// </summary>
    let ``lists/2/speciality/035400/1`` = _prefix "lists/2/speciality/035400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/50.03.01/1`` = _prefix "lists/3/speciality/50.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035300/1"></see>
    /// </summary>
    let ``lists/2/speciality/035300/1`` = _prefix "lists/2/speciality/035300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031500/3"></see>
    /// </summary>
    let ``lists/1/speciality/031500/3`` = _prefix "lists/1/speciality/031500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035400/3"></see>
    /// </summary>
    let ``lists/2/speciality/035400/3`` = _prefix "lists/2/speciality/035400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/50.04.03/3`` = _prefix "lists/3/speciality/50.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031501/2"></see>
    /// </summary>
    let ``lists/1/speciality/031501/2`` = _prefix "lists/1/speciality/031501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031502/2"></see>
    /// </summary>
    let ``lists/1/speciality/031502/2`` = _prefix "lists/1/speciality/031502/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072300/1"></see>
    /// </summary>
    let ``lists/2/speciality/072300/1`` = _prefix "lists/2/speciality/072300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/51.03.04/1`` = _prefix "lists/3/speciality/51.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031600/1"></see>
    /// </summary>
    let ``lists/1/speciality/031600/1`` = _prefix "lists/1/speciality/031600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071200/1"></see>
    /// </summary>
    let ``lists/2/speciality/071200/1`` = _prefix "lists/2/speciality/071200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/52.03.01/1`` = _prefix "lists/3/speciality/52.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/50.03.04/1`` = _prefix "lists/3/speciality/50.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073900/1"></see>
    /// </summary>
    let ``lists/2/speciality/073900/1`` = _prefix "lists/2/speciality/073900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031600/3"></see>
    /// </summary>
    let ``lists/1/speciality/031600/3`` = _prefix "lists/1/speciality/031600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035300/3"></see>
    /// </summary>
    let ``lists/2/speciality/035300/3`` = _prefix "lists/2/speciality/035300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/50.04.01/3`` = _prefix "lists/3/speciality/50.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031700/1"></see>
    /// </summary>
    let ``lists/1/speciality/031700/1`` = _prefix "lists/1/speciality/031700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035200/1"></see>
    /// </summary>
    let ``lists/2/speciality/035200/1`` = _prefix "lists/2/speciality/035200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/50.03.02/1`` = _prefix "lists/3/speciality/50.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031700/3"></see>
    /// </summary>
    let ``lists/1/speciality/031700/3`` = _prefix "lists/1/speciality/031700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035200/3"></see>
    /// </summary>
    let ``lists/2/speciality/035200/3`` = _prefix "lists/2/speciality/035200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/50.04.02/3`` = _prefix "lists/3/speciality/50.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031800/1"></see>
    /// </summary>
    let ``lists/1/speciality/031800/1`` = _prefix "lists/1/speciality/031800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033300/1"></see>
    /// </summary>
    let ``lists/2/speciality/033300/1`` = _prefix "lists/2/speciality/033300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/47.03.03/1`` = _prefix "lists/3/speciality/47.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031800/3"></see>
    /// </summary>
    let ``lists/1/speciality/031800/3`` = _prefix "lists/1/speciality/031800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033300/3"></see>
    /// </summary>
    let ``lists/2/speciality/033300/3`` = _prefix "lists/2/speciality/033300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/47.04.03/3`` = _prefix "lists/3/speciality/47.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031801/2"></see>
    /// </summary>
    let ``lists/1/speciality/031801/2`` = _prefix "lists/1/speciality/031801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031900/1"></see>
    /// </summary>
    let ``lists/1/speciality/031900/1`` = _prefix "lists/1/speciality/031900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033400/1"></see>
    /// </summary>
    let ``lists/2/speciality/033400/1`` = _prefix "lists/2/speciality/033400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/48.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/48.03.01/1`` = _prefix "lists/3/speciality/48.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031900/3"></see>
    /// </summary>
    let ``lists/1/speciality/031900/3`` = _prefix "lists/1/speciality/031900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033400/3"></see>
    /// </summary>
    let ``lists/2/speciality/033400/3`` = _prefix "lists/2/speciality/033400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/48.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/48.04.01/3`` = _prefix "lists/3/speciality/48.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/031901/2"></see>
    /// </summary>
    let ``lists/1/speciality/031901/2`` = _prefix "lists/1/speciality/031901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032000/1"></see>
    /// </summary>
    let ``lists/1/speciality/032000/1`` = _prefix "lists/1/speciality/032000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034700/1"></see>
    /// </summary>
    let ``lists/2/speciality/034700/1`` = _prefix "lists/2/speciality/034700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/46.03.02/1`` = _prefix "lists/3/speciality/46.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032000/3"></see>
    /// </summary>
    let ``lists/1/speciality/032000/3`` = _prefix "lists/1/speciality/032000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034700/3"></see>
    /// </summary>
    let ``lists/2/speciality/034700/3`` = _prefix "lists/2/speciality/034700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/46.04.02/3`` = _prefix "lists/3/speciality/46.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032001/2"></see>
    /// </summary>
    let ``lists/1/speciality/032001/2`` = _prefix "lists/1/speciality/032001/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032100/1"></see>
    /// </summary>
    let ``lists/1/speciality/032100/1`` = _prefix "lists/1/speciality/032100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034300/1"></see>
    /// </summary>
    let ``lists/2/speciality/034300/1`` = _prefix "lists/2/speciality/034300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/49.03.01/1`` = _prefix "lists/3/speciality/49.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032100/3"></see>
    /// </summary>
    let ``lists/1/speciality/032100/3`` = _prefix "lists/1/speciality/032100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034300/3"></see>
    /// </summary>
    let ``lists/2/speciality/034300/3`` = _prefix "lists/2/speciality/034300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034500/3"></see>
    /// </summary>
    let ``lists/2/speciality/034500/3`` = _prefix "lists/2/speciality/034500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/49.04.02/3`` = _prefix "lists/3/speciality/49.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/49.04.01/3`` = _prefix "lists/3/speciality/49.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034400/3"></see>
    /// </summary>
    let ``lists/2/speciality/034400/3`` = _prefix "lists/2/speciality/034400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/49.04.03/3`` = _prefix "lists/3/speciality/49.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032101/2"></see>
    /// </summary>
    let ``lists/1/speciality/032101/2`` = _prefix "lists/1/speciality/032101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032102/2"></see>
    /// </summary>
    let ``lists/1/speciality/032102/2`` = _prefix "lists/1/speciality/032102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034400/1"></see>
    /// </summary>
    let ``lists/2/speciality/034400/1`` = _prefix "lists/2/speciality/034400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/49.03.02/1`` = _prefix "lists/3/speciality/49.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032103/2"></see>
    /// </summary>
    let ``lists/1/speciality/032103/2`` = _prefix "lists/1/speciality/032103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034600/1"></see>
    /// </summary>
    let ``lists/2/speciality/034600/1`` = _prefix "lists/2/speciality/034600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/49.03.03/1`` = _prefix "lists/3/speciality/49.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032200/1"></see>
    /// </summary>
    let ``lists/1/speciality/032200/1`` = _prefix "lists/1/speciality/032200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033700/1"></see>
    /// </summary>
    let ``lists/2/speciality/033700/1`` = _prefix "lists/2/speciality/033700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/47.03.02/1`` = _prefix "lists/3/speciality/47.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032200/3"></see>
    /// </summary>
    let ``lists/1/speciality/032200/3`` = _prefix "lists/1/speciality/032200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/033700/3"></see>
    /// </summary>
    let ``lists/2/speciality/033700/3`` = _prefix "lists/2/speciality/033700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/47.04.02/3`` = _prefix "lists/3/speciality/47.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032300/1"></see>
    /// </summary>
    let ``lists/1/speciality/032300/1`` = _prefix "lists/1/speciality/032300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032000/1"></see>
    /// </summary>
    let ``lists/2/speciality/032000/1`` = _prefix "lists/2/speciality/032000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/41.03.01/1`` = _prefix "lists/3/speciality/41.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/41.03.02/1`` = _prefix "lists/3/speciality/41.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032200/1"></see>
    /// </summary>
    let ``lists/2/speciality/032200/1`` = _prefix "lists/2/speciality/032200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032300/3"></see>
    /// </summary>
    let ``lists/1/speciality/032300/3`` = _prefix "lists/1/speciality/032300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032000/3"></see>
    /// </summary>
    let ``lists/2/speciality/032000/3`` = _prefix "lists/2/speciality/032000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/41.04.01/3`` = _prefix "lists/3/speciality/41.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/41.04.02/3`` = _prefix "lists/3/speciality/41.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032200/3"></see>
    /// </summary>
    let ``lists/2/speciality/032200/3`` = _prefix "lists/2/speciality/032200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032301/2"></see>
    /// </summary>
    let ``lists/1/speciality/032301/2`` = _prefix "lists/1/speciality/032301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/032401/2"></see>
    /// </summary>
    let ``lists/1/speciality/032401/2`` = _prefix "lists/1/speciality/032401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100700/1"></see>
    /// </summary>
    let ``lists/2/speciality/100700/1`` = _prefix "lists/2/speciality/100700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.06/1`` = _prefix "lists/3/speciality/38.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/035800/3"></see>
    /// </summary>
    let ``lists/1/speciality/035800/3`` = _prefix "lists/1/speciality/035800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035800/3"></see>
    /// </summary>
    let ``lists/2/speciality/035800/3`` = _prefix "lists/2/speciality/035800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/45.04.03/3`` = _prefix "lists/3/speciality/45.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040100/1"></see>
    /// </summary>
    let ``lists/1/speciality/040100/1`` = _prefix "lists/1/speciality/040100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/040400/1"></see>
    /// </summary>
    let ``lists/2/speciality/040400/1`` = _prefix "lists/2/speciality/040400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/39.03.02/1`` = _prefix "lists/3/speciality/39.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/040000"></see>
    /// </summary>
    let ``lists/1/ugsn/040000`` = _prefix "lists/1/ugsn/040000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040100/3"></see>
    /// </summary>
    let ``lists/1/speciality/040100/3`` = _prefix "lists/1/speciality/040100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/040400/3"></see>
    /// </summary>
    let ``lists/2/speciality/040400/3`` = _prefix "lists/2/speciality/040400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/39.04.02/3`` = _prefix "lists/3/speciality/39.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040101/2"></see>
    /// </summary>
    let ``lists/1/speciality/040101/2`` = _prefix "lists/1/speciality/040101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040102/2"></see>
    /// </summary>
    let ``lists/1/speciality/040102/2`` = _prefix "lists/1/speciality/040102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/090900/1"></see>
    /// </summary>
    let ``lists/2/speciality/090900/1`` = _prefix "lists/2/speciality/090900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/10.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/10.03.01/1`` = _prefix "lists/3/speciality/10.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/090000"></see>
    /// </summary>
    let ``lists/1/ugsn/090000`` = _prefix "lists/1/ugsn/090000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040104/2"></see>
    /// </summary>
    let ``lists/1/speciality/040104/2`` = _prefix "lists/1/speciality/040104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/040700/1"></see>
    /// </summary>
    let ``lists/2/speciality/040700/1`` = _prefix "lists/2/speciality/040700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/39.03.03/1`` = _prefix "lists/3/speciality/39.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040200/1"></see>
    /// </summary>
    let ``lists/1/speciality/040200/1`` = _prefix "lists/1/speciality/040200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/040100/1"></see>
    /// </summary>
    let ``lists/2/speciality/040100/1`` = _prefix "lists/2/speciality/040100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/39.03.01/1`` = _prefix "lists/3/speciality/39.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040200/3"></see>
    /// </summary>
    let ``lists/1/speciality/040200/3`` = _prefix "lists/1/speciality/040200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/040100/3"></see>
    /// </summary>
    let ``lists/2/speciality/040100/3`` = _prefix "lists/2/speciality/040100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/39.04.01/3`` = _prefix "lists/3/speciality/39.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040201/2"></see>
    /// </summary>
    let ``lists/1/speciality/040201/2`` = _prefix "lists/1/speciality/040201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040300/1"></see>
    /// </summary>
    let ``lists/1/speciality/040300/1`` = _prefix "lists/1/speciality/040300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034000/1"></see>
    /// </summary>
    let ``lists/2/speciality/034000/1`` = _prefix "lists/2/speciality/034000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/37.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/37.03.02/1`` = _prefix "lists/3/speciality/37.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/040300/3"></see>
    /// </summary>
    let ``lists/1/speciality/040300/3`` = _prefix "lists/1/speciality/040300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/034000/3"></see>
    /// </summary>
    let ``lists/2/speciality/034000/3`` = _prefix "lists/2/speciality/034000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/37.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/37.04.02/3`` = _prefix "lists/3/speciality/37.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050100/1"></see>
    /// </summary>
    let ``lists/1/speciality/050100/1`` = _prefix "lists/1/speciality/050100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/050100/1"></see>
    /// </summary>
    let ``lists/2/speciality/050100/1`` = _prefix "lists/2/speciality/050100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/44.03.01/1`` = _prefix "lists/3/speciality/44.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/44.03.05/1`` = _prefix "lists/3/speciality/44.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/050000"></see>
    /// </summary>
    let ``lists/1/ugsn/050000`` = _prefix "lists/1/ugsn/050000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050100/3"></see>
    /// </summary>
    let ``lists/1/speciality/050100/3`` = _prefix "lists/1/speciality/050100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/050100/3"></see>
    /// </summary>
    let ``lists/2/speciality/050100/3`` = _prefix "lists/2/speciality/050100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/44.04.01/3`` = _prefix "lists/3/speciality/44.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050101/2"></see>
    /// </summary>
    let ``lists/1/speciality/050101/2`` = _prefix "lists/1/speciality/050101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050102/2"></see>
    /// </summary>
    let ``lists/1/speciality/050102/2`` = _prefix "lists/1/speciality/050102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050103/2"></see>
    /// </summary>
    let ``lists/1/speciality/050103/2`` = _prefix "lists/1/speciality/050103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050104/2"></see>
    /// </summary>
    let ``lists/1/speciality/050104/2`` = _prefix "lists/1/speciality/050104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050200/1"></see>
    /// </summary>
    let ``lists/1/speciality/050200/1`` = _prefix "lists/1/speciality/050200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050200/3"></see>
    /// </summary>
    let ``lists/1/speciality/050200/3`` = _prefix "lists/1/speciality/050200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050201/2"></see>
    /// </summary>
    let ``lists/1/speciality/050201/2`` = _prefix "lists/1/speciality/050201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050202/2"></see>
    /// </summary>
    let ``lists/1/speciality/050202/2`` = _prefix "lists/1/speciality/050202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050203/2"></see>
    /// </summary>
    let ``lists/1/speciality/050203/2`` = _prefix "lists/1/speciality/050203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050300/1"></see>
    /// </summary>
    let ``lists/1/speciality/050300/1`` = _prefix "lists/1/speciality/050300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050300/3"></see>
    /// </summary>
    let ``lists/1/speciality/050300/3`` = _prefix "lists/1/speciality/050300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050301/2"></see>
    /// </summary>
    let ``lists/1/speciality/050301/2`` = _prefix "lists/1/speciality/050301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050302/2"></see>
    /// </summary>
    let ``lists/1/speciality/050302/2`` = _prefix "lists/1/speciality/050302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050303/2"></see>
    /// </summary>
    let ``lists/1/speciality/050303/2`` = _prefix "lists/1/speciality/050303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050400/1"></see>
    /// </summary>
    let ``lists/1/speciality/050400/1`` = _prefix "lists/1/speciality/050400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050400/3"></see>
    /// </summary>
    let ``lists/1/speciality/050400/3`` = _prefix "lists/1/speciality/050400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050401/2"></see>
    /// </summary>
    let ``lists/1/speciality/050401/2`` = _prefix "lists/1/speciality/050401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050402/2"></see>
    /// </summary>
    let ``lists/1/speciality/050402/2`` = _prefix "lists/1/speciality/050402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050403/1"></see>
    /// </summary>
    let ``lists/1/speciality/050403/1`` = _prefix "lists/1/speciality/050403/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050403/2"></see>
    /// </summary>
    let ``lists/1/speciality/050403/2`` = _prefix "lists/1/speciality/050403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050500/1"></see>
    /// </summary>
    let ``lists/1/speciality/050500/1`` = _prefix "lists/1/speciality/050500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050500/3"></see>
    /// </summary>
    let ``lists/1/speciality/050500/3`` = _prefix "lists/1/speciality/050500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050501/2"></see>
    /// </summary>
    let ``lists/1/speciality/050501/2`` = _prefix "lists/1/speciality/050501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/051000/1"></see>
    /// </summary>
    let ``lists/2/speciality/051000/1`` = _prefix "lists/2/speciality/051000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/44.03.04/1`` = _prefix "lists/3/speciality/44.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050502/2"></see>
    /// </summary>
    let ``lists/1/speciality/050502/2`` = _prefix "lists/1/speciality/050502/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050600/1"></see>
    /// </summary>
    let ``lists/1/speciality/050600/1`` = _prefix "lists/1/speciality/050600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050600/3"></see>
    /// </summary>
    let ``lists/1/speciality/050600/3`` = _prefix "lists/1/speciality/050600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050601/2"></see>
    /// </summary>
    let ``lists/1/speciality/050601/2`` = _prefix "lists/1/speciality/050601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050602/2"></see>
    /// </summary>
    let ``lists/1/speciality/050602/2`` = _prefix "lists/1/speciality/050602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050700/1"></see>
    /// </summary>
    let ``lists/1/speciality/050700/1`` = _prefix "lists/1/speciality/050700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/44.03.02/1`` = _prefix "lists/3/speciality/44.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/050700/1"></see>
    /// </summary>
    let ``lists/2/speciality/050700/1`` = _prefix "lists/2/speciality/050700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/050400/1"></see>
    /// </summary>
    let ``lists/2/speciality/050400/1`` = _prefix "lists/2/speciality/050400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/44.03.03/1`` = _prefix "lists/3/speciality/44.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050700/3"></see>
    /// </summary>
    let ``lists/1/speciality/050700/3`` = _prefix "lists/1/speciality/050700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/051000/3"></see>
    /// </summary>
    let ``lists/2/speciality/051000/3`` = _prefix "lists/2/speciality/051000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/050700/3"></see>
    /// </summary>
    let ``lists/2/speciality/050700/3`` = _prefix "lists/2/speciality/050700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/44.04.04/3`` = _prefix "lists/3/speciality/44.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/44.04.03/3`` = _prefix "lists/3/speciality/44.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050701/2"></see>
    /// </summary>
    let ``lists/1/speciality/050701/2`` = _prefix "lists/1/speciality/050701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/444.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/444.03.05/1`` = _prefix "lists/3/speciality/444.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050703/2"></see>
    /// </summary>
    let ``lists/1/speciality/050703/2`` = _prefix "lists/1/speciality/050703/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050706/2"></see>
    /// </summary>
    let ``lists/1/speciality/050706/2`` = _prefix "lists/1/speciality/050706/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050707/2"></see>
    /// </summary>
    let ``lists/1/speciality/050707/2`` = _prefix "lists/1/speciality/050707/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.03.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/05.03.20/1`` = _prefix "lists/3/speciality/05.03.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050708/2"></see>
    /// </summary>
    let ``lists/1/speciality/050708/2`` = _prefix "lists/1/speciality/050708/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050711/2"></see>
    /// </summary>
    let ``lists/1/speciality/050711/2`` = _prefix "lists/1/speciality/050711/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050712/2"></see>
    /// </summary>
    let ``lists/1/speciality/050712/2`` = _prefix "lists/1/speciality/050712/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050713/2"></see>
    /// </summary>
    let ``lists/1/speciality/050713/2`` = _prefix "lists/1/speciality/050713/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050714/2"></see>
    /// </summary>
    let ``lists/1/speciality/050714/2`` = _prefix "lists/1/speciality/050714/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050715/2"></see>
    /// </summary>
    let ``lists/1/speciality/050715/2`` = _prefix "lists/1/speciality/050715/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050716/2"></see>
    /// </summary>
    let ``lists/1/speciality/050716/2`` = _prefix "lists/1/speciality/050716/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050717/2"></see>
    /// </summary>
    let ``lists/1/speciality/050717/2`` = _prefix "lists/1/speciality/050717/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/050720/2"></see>
    /// </summary>
    let ``lists/1/speciality/050720/2`` = _prefix "lists/1/speciality/050720/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/060109/1"></see>
    /// </summary>
    let ``lists/1/speciality/060109/1`` = _prefix "lists/1/speciality/060109/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/060500/1"></see>
    /// </summary>
    let ``lists/2/speciality/060500/1`` = _prefix "lists/2/speciality/060500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/34.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/34.03.01/1`` = _prefix "lists/3/speciality/34.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/060000"></see>
    /// </summary>
    let ``lists/1/ugsn/060000`` = _prefix "lists/1/ugsn/060000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070100/1"></see>
    /// </summary>
    let ``lists/1/speciality/070100/1`` = _prefix "lists/1/speciality/070100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073100/1"></see>
    /// </summary>
    let ``lists/2/speciality/073100/1`` = _prefix "lists/2/speciality/073100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/53.03.04/1`` = _prefix "lists/3/speciality/53.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073000/1"></see>
    /// </summary>
    let ``lists/2/speciality/073000/1`` = _prefix "lists/2/speciality/073000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/53.03.06/1`` = _prefix "lists/3/speciality/53.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/53.03.01/1`` = _prefix "lists/3/speciality/53.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071600/1"></see>
    /// </summary>
    let ``lists/2/speciality/071600/1`` = _prefix "lists/2/speciality/071600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/53.03.03/1`` = _prefix "lists/3/speciality/53.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073400/1"></see>
    /// </summary>
    let ``lists/2/speciality/073400/1`` = _prefix "lists/2/speciality/073400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073700/1"></see>
    /// </summary>
    let ``lists/2/speciality/073700/1`` = _prefix "lists/2/speciality/073700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/53.03.05/1`` = _prefix "lists/3/speciality/53.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/53.03.02/1`` = _prefix "lists/3/speciality/53.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073500/1"></see>
    /// </summary>
    let ``lists/2/speciality/073500/1`` = _prefix "lists/2/speciality/073500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/070000"></see>
    /// </summary>
    let ``lists/1/ugsn/070000`` = _prefix "lists/1/ugsn/070000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070100/3"></see>
    /// </summary>
    let ``lists/1/speciality/070100/3`` = _prefix "lists/1/speciality/070100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073100/3"></see>
    /// </summary>
    let ``lists/2/speciality/073100/3`` = _prefix "lists/2/speciality/073100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073700/3"></see>
    /// </summary>
    let ``lists/2/speciality/073700/3`` = _prefix "lists/2/speciality/073700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073000/3"></see>
    /// </summary>
    let ``lists/2/speciality/073000/3`` = _prefix "lists/2/speciality/073000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/53.04.06/3`` = _prefix "lists/3/speciality/53.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/53.04.04/3`` = _prefix "lists/3/speciality/53.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073500/3"></see>
    /// </summary>
    let ``lists/2/speciality/073500/3`` = _prefix "lists/2/speciality/073500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/53.04.03/3`` = _prefix "lists/3/speciality/53.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/53.04.01/3`` = _prefix "lists/3/speciality/53.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073400/3"></see>
    /// </summary>
    let ``lists/2/speciality/073400/3`` = _prefix "lists/2/speciality/073400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/53.04.02/3`` = _prefix "lists/3/speciality/53.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070101/2"></see>
    /// </summary>
    let ``lists/1/speciality/070101/2`` = _prefix "lists/1/speciality/070101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070103/2"></see>
    /// </summary>
    let ``lists/1/speciality/070103/2`` = _prefix "lists/1/speciality/070103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070105/2"></see>
    /// </summary>
    let ``lists/1/speciality/070105/2`` = _prefix "lists/1/speciality/070105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070108/2"></see>
    /// </summary>
    let ``lists/1/speciality/070108/2`` = _prefix "lists/1/speciality/070108/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070111/2"></see>
    /// </summary>
    let ``lists/1/speciality/070111/2`` = _prefix "lists/1/speciality/070111/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070112/2"></see>
    /// </summary>
    let ``lists/1/speciality/070112/2`` = _prefix "lists/1/speciality/070112/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070200/2"></see>
    /// </summary>
    let ``lists/1/speciality/070200/2`` = _prefix "lists/1/speciality/070200/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/074100/1"></see>
    /// </summary>
    let ``lists/2/speciality/074100/1`` = _prefix "lists/2/speciality/074100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/52.03.05/1`` = _prefix "lists/3/speciality/52.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070200/3"></see>
    /// </summary>
    let ``lists/1/speciality/070200/3`` = _prefix "lists/1/speciality/070200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/074000/3"></see>
    /// </summary>
    let ``lists/2/speciality/074000/3`` = _prefix "lists/2/speciality/074000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/52.04.03/3`` = _prefix "lists/3/speciality/52.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070205/2"></see>
    /// </summary>
    let ``lists/1/speciality/070205/2`` = _prefix "lists/1/speciality/070205/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073600/1"></see>
    /// </summary>
    let ``lists/2/speciality/073600/1`` = _prefix "lists/2/speciality/073600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/52.03.04/1`` = _prefix "lists/3/speciality/52.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070209/2"></see>
    /// </summary>
    let ``lists/1/speciality/070209/2`` = _prefix "lists/1/speciality/070209/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071400/1"></see>
    /// </summary>
    let ``lists/2/speciality/071400/1`` = _prefix "lists/2/speciality/071400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/51.03.05/1`` = _prefix "lists/3/speciality/51.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070210/2"></see>
    /// </summary>
    let ``lists/1/speciality/070210/2`` = _prefix "lists/1/speciality/070210/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/070800/1"></see>
    /// </summary>
    let ``lists/2/speciality/070800/1`` = _prefix "lists/2/speciality/070800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/52.03.06/1`` = _prefix "lists/3/speciality/52.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070211/2"></see>
    /// </summary>
    let ``lists/1/speciality/070211/2`` = _prefix "lists/1/speciality/070211/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070300/1"></see>
    /// </summary>
    let ``lists/1/speciality/070300/1`` = _prefix "lists/1/speciality/070300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/52.03.02/1`` = _prefix "lists/3/speciality/52.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071300/1"></see>
    /// </summary>
    let ``lists/2/speciality/071300/1`` = _prefix "lists/2/speciality/071300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070300/3"></see>
    /// </summary>
    let ``lists/1/speciality/070300/3`` = _prefix "lists/1/speciality/070300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/073900/3"></see>
    /// </summary>
    let ``lists/2/speciality/073900/3`` = _prefix "lists/2/speciality/073900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/50.04.04/3`` = _prefix "lists/3/speciality/50.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070301/2"></see>
    /// </summary>
    let ``lists/1/speciality/070301/2`` = _prefix "lists/1/speciality/070301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070301/3"></see>
    /// </summary>
    let ``lists/1/speciality/070301/3`` = _prefix "lists/1/speciality/070301/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071200/3"></see>
    /// </summary>
    let ``lists/2/speciality/071200/3`` = _prefix "lists/2/speciality/071200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070303/2"></see>
    /// </summary>
    let ``lists/1/speciality/070303/2`` = _prefix "lists/1/speciality/070303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070304/2"></see>
    /// </summary>
    let ``lists/1/speciality/070304/2`` = _prefix "lists/1/speciality/070304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070305/2"></see>
    /// </summary>
    let ``lists/1/speciality/070305/2`` = _prefix "lists/1/speciality/070305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070500/1"></see>
    /// </summary>
    let ``lists/1/speciality/070500/1`` = _prefix "lists/1/speciality/070500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072200/1"></see>
    /// </summary>
    let ``lists/2/speciality/072200/1`` = _prefix "lists/2/speciality/072200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/54.03.04/1`` = _prefix "lists/3/speciality/54.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070500/3"></see>
    /// </summary>
    let ``lists/1/speciality/070500/3`` = _prefix "lists/1/speciality/070500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072200/3"></see>
    /// </summary>
    let ``lists/2/speciality/072200/3`` = _prefix "lists/2/speciality/072200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/54.04.04/3`` = _prefix "lists/3/speciality/54.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070501/2"></see>
    /// </summary>
    let ``lists/1/speciality/070501/2`` = _prefix "lists/1/speciality/070501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070503/2"></see>
    /// </summary>
    let ``lists/1/speciality/070503/2`` = _prefix "lists/1/speciality/070503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070600/1"></see>
    /// </summary>
    let ``lists/1/speciality/070600/1`` = _prefix "lists/1/speciality/070600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072500/1"></see>
    /// </summary>
    let ``lists/2/speciality/072500/1`` = _prefix "lists/2/speciality/072500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/54.03.01/1`` = _prefix "lists/3/speciality/54.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070600/3"></see>
    /// </summary>
    let ``lists/1/speciality/070600/3`` = _prefix "lists/1/speciality/070600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072500/3"></see>
    /// </summary>
    let ``lists/2/speciality/072500/3`` = _prefix "lists/2/speciality/072500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/54.04.01/3`` = _prefix "lists/3/speciality/54.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070601/2"></see>
    /// </summary>
    let ``lists/1/speciality/070601/2`` = _prefix "lists/1/speciality/070601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070603/2"></see>
    /// </summary>
    let ``lists/1/speciality/070603/2`` = _prefix "lists/1/speciality/070603/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070800/1"></see>
    /// </summary>
    let ``lists/1/speciality/070800/1`` = _prefix "lists/1/speciality/070800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072600/1"></see>
    /// </summary>
    let ``lists/2/speciality/072600/1`` = _prefix "lists/2/speciality/072600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/54.03.02/1`` = _prefix "lists/3/speciality/54.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070800/3"></see>
    /// </summary>
    let ``lists/1/speciality/070800/3`` = _prefix "lists/1/speciality/070800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072600/3"></see>
    /// </summary>
    let ``lists/2/speciality/072600/3`` = _prefix "lists/2/speciality/072600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/54.04.02/3`` = _prefix "lists/3/speciality/54.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070801/2"></see>
    /// </summary>
    let ``lists/1/speciality/070801/2`` = _prefix "lists/1/speciality/070801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070900/1"></see>
    /// </summary>
    let ``lists/1/speciality/070900/1`` = _prefix "lists/1/speciality/070900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070900/3"></see>
    /// </summary>
    let ``lists/1/speciality/070900/3`` = _prefix "lists/1/speciality/070900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/51.04.04/3`` = _prefix "lists/3/speciality/51.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070905/2"></see>
    /// </summary>
    let ``lists/1/speciality/070905/2`` = _prefix "lists/1/speciality/070905/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270100/1"></see>
    /// </summary>
    let ``lists/2/speciality/270100/1`` = _prefix "lists/2/speciality/270100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/07.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/07.03.01/1`` = _prefix "lists/3/speciality/07.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/070906/2"></see>
    /// </summary>
    let ``lists/1/speciality/070906/2`` = _prefix "lists/1/speciality/070906/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071000/1"></see>
    /// </summary>
    let ``lists/1/speciality/071000/1`` = _prefix "lists/1/speciality/071000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071000/3"></see>
    /// </summary>
    let ``lists/1/speciality/071000/3`` = _prefix "lists/1/speciality/071000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071100/1"></see>
    /// </summary>
    let ``lists/1/speciality/071100/1`` = _prefix "lists/1/speciality/071100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071100/3"></see>
    /// </summary>
    let ``lists/1/speciality/071100/3`` = _prefix "lists/1/speciality/071100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071200/1"></see>
    /// </summary>
    let ``lists/1/speciality/071200/1`` = _prefix "lists/1/speciality/071200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071900/1"></see>
    /// </summary>
    let ``lists/2/speciality/071900/1`` = _prefix "lists/2/speciality/071900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/51.03.06/1`` = _prefix "lists/3/speciality/51.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071200/3"></see>
    /// </summary>
    let ``lists/1/speciality/071200/3`` = _prefix "lists/1/speciality/071200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071900/3"></see>
    /// </summary>
    let ``lists/2/speciality/071900/3`` = _prefix "lists/2/speciality/071900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/51.04.06/3`` = _prefix "lists/3/speciality/51.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071201/2"></see>
    /// </summary>
    let ``lists/1/speciality/071201/2`` = _prefix "lists/1/speciality/071201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071300/1"></see>
    /// </summary>
    let ``lists/1/speciality/071300/1`` = _prefix "lists/1/speciality/071300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/51.03.02/1`` = _prefix "lists/3/speciality/51.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071500/1"></see>
    /// </summary>
    let ``lists/2/speciality/071500/1`` = _prefix "lists/2/speciality/071500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071300/3"></see>
    /// </summary>
    let ``lists/1/speciality/071300/3`` = _prefix "lists/1/speciality/071300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071500/3"></see>
    /// </summary>
    let ``lists/2/speciality/071500/3`` = _prefix "lists/2/speciality/071500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/51.04.02/3`` = _prefix "lists/3/speciality/51.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071301/2"></see>
    /// </summary>
    let ``lists/1/speciality/071301/2`` = _prefix "lists/1/speciality/071301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071400/1"></see>
    /// </summary>
    let ``lists/1/speciality/071400/1`` = _prefix "lists/1/speciality/071400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071800/1"></see>
    /// </summary>
    let ``lists/2/speciality/071800/1`` = _prefix "lists/2/speciality/071800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/51.03.03/1`` = _prefix "lists/3/speciality/51.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071400/3"></see>
    /// </summary>
    let ``lists/1/speciality/071400/3`` = _prefix "lists/1/speciality/071400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071800/3"></see>
    /// </summary>
    let ``lists/2/speciality/071800/3`` = _prefix "lists/2/speciality/071800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/51.04.03/3`` = _prefix "lists/3/speciality/51.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071401/2"></see>
    /// </summary>
    let ``lists/1/speciality/071401/2`` = _prefix "lists/1/speciality/071401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071501/2"></see>
    /// </summary>
    let ``lists/1/speciality/071501/2`` = _prefix "lists/1/speciality/071501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072700/1"></see>
    /// </summary>
    let ``lists/2/speciality/072700/1`` = _prefix "lists/2/speciality/072700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/54.03.03/1`` = _prefix "lists/3/speciality/54.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071502/2"></see>
    /// </summary>
    let ``lists/1/speciality/071502/2`` = _prefix "lists/1/speciality/071502/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071503/2"></see>
    /// </summary>
    let ``lists/1/speciality/071503/2`` = _prefix "lists/1/speciality/071503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/071504/2"></see>
    /// </summary>
    let ``lists/1/speciality/071504/2`` = _prefix "lists/1/speciality/071504/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080100/1"></see>
    /// </summary>
    let ``lists/1/speciality/080100/1`` = _prefix "lists/1/speciality/080100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080100/1"></see>
    /// </summary>
    let ``lists/2/speciality/080100/1`` = _prefix "lists/2/speciality/080100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.01/1`` = _prefix "lists/3/speciality/38.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/080000"></see>
    /// </summary>
    let ``lists/1/ugsn/080000`` = _prefix "lists/1/ugsn/080000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080100/3"></see>
    /// </summary>
    let ``lists/1/speciality/080100/3`` = _prefix "lists/1/speciality/080100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080100/3"></see>
    /// </summary>
    let ``lists/2/speciality/080100/3`` = _prefix "lists/2/speciality/080100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.01/3`` = _prefix "lists/3/speciality/38.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.08/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.08/3`` = _prefix "lists/3/speciality/38.04.08/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080300/3"></see>
    /// </summary>
    let ``lists/2/speciality/080300/3`` = _prefix "lists/2/speciality/080300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080101/2"></see>
    /// </summary>
    let ``lists/1/speciality/080101/2`` = _prefix "lists/1/speciality/080101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080102/2"></see>
    /// </summary>
    let ``lists/1/speciality/080102/2`` = _prefix "lists/1/speciality/080102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080103/2"></see>
    /// </summary>
    let ``lists/1/speciality/080103/2`` = _prefix "lists/1/speciality/080103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080104/2"></see>
    /// </summary>
    let ``lists/1/speciality/080104/2`` = _prefix "lists/1/speciality/080104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080400/1"></see>
    /// </summary>
    let ``lists/2/speciality/080400/1`` = _prefix "lists/2/speciality/080400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080105/2"></see>
    /// </summary>
    let ``lists/1/speciality/080105/2`` = _prefix "lists/1/speciality/080105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080107/2"></see>
    /// </summary>
    let ``lists/1/speciality/080107/2`` = _prefix "lists/1/speciality/080107/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080109/2"></see>
    /// </summary>
    let ``lists/1/speciality/080109/2`` = _prefix "lists/1/speciality/080109/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080111/2"></see>
    /// </summary>
    let ``lists/1/speciality/080111/2`` = _prefix "lists/1/speciality/080111/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.02/1`` = _prefix "lists/3/speciality/38.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080200/1"></see>
    /// </summary>
    let ``lists/2/speciality/080200/1`` = _prefix "lists/2/speciality/080200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080116/2"></see>
    /// </summary>
    let ``lists/1/speciality/080116/2`` = _prefix "lists/1/speciality/080116/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/230700/1"></see>
    /// </summary>
    let ``lists/2/speciality/230700/1`` = _prefix "lists/2/speciality/230700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080500/1"></see>
    /// </summary>
    let ``lists/2/speciality/080500/1`` = _prefix "lists/2/speciality/080500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/09.03.03/1`` = _prefix "lists/3/speciality/09.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.05/1`` = _prefix "lists/3/speciality/38.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080300/1"></see>
    /// </summary>
    let ``lists/1/speciality/080300/1`` = _prefix "lists/1/speciality/080300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080300/3"></see>
    /// </summary>
    let ``lists/1/speciality/080300/3`` = _prefix "lists/1/speciality/080300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100700/3"></see>
    /// </summary>
    let ``lists/2/speciality/100700/3`` = _prefix "lists/2/speciality/100700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.06/3`` = _prefix "lists/3/speciality/38.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080301/2"></see>
    /// </summary>
    let ``lists/1/speciality/080301/2`` = _prefix "lists/1/speciality/080301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080401/2"></see>
    /// </summary>
    let ``lists/1/speciality/080401/2`` = _prefix "lists/1/speciality/080401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100800/1"></see>
    /// </summary>
    let ``lists/2/speciality/100800/1`` = _prefix "lists/2/speciality/100800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.07/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.07/1`` = _prefix "lists/3/speciality/38.03.07/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080500/1"></see>
    /// </summary>
    let ``lists/1/speciality/080500/1`` = _prefix "lists/1/speciality/080500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080500/3"></see>
    /// </summary>
    let ``lists/1/speciality/080500/3`` = _prefix "lists/1/speciality/080500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.02/3`` = _prefix "lists/3/speciality/38.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080400/3"></see>
    /// </summary>
    let ``lists/2/speciality/080400/3`` = _prefix "lists/2/speciality/080400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/081100/3"></see>
    /// </summary>
    let ``lists/2/speciality/081100/3`` = _prefix "lists/2/speciality/081100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.04/3`` = _prefix "lists/3/speciality/38.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080200/3"></see>
    /// </summary>
    let ``lists/2/speciality/080200/3`` = _prefix "lists/2/speciality/080200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.03/3`` = _prefix "lists/3/speciality/38.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080502/2"></see>
    /// </summary>
    let ``lists/1/speciality/080502/2`` = _prefix "lists/1/speciality/080502/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080503/2"></see>
    /// </summary>
    let ``lists/1/speciality/080503/2`` = _prefix "lists/1/speciality/080503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080504/2"></see>
    /// </summary>
    let ``lists/1/speciality/080504/2`` = _prefix "lists/1/speciality/080504/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/081100/1"></see>
    /// </summary>
    let ``lists/2/speciality/081100/1`` = _prefix "lists/2/speciality/081100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.04/1`` = _prefix "lists/3/speciality/38.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080505/2"></see>
    /// </summary>
    let ``lists/1/speciality/080505/2`` = _prefix "lists/1/speciality/080505/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/38.03.03/1`` = _prefix "lists/3/speciality/38.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080506/2"></see>
    /// </summary>
    let ``lists/1/speciality/080506/2`` = _prefix "lists/1/speciality/080506/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080507/2"></see>
    /// </summary>
    let ``lists/1/speciality/080507/2`` = _prefix "lists/1/speciality/080507/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080508/2"></see>
    /// </summary>
    let ``lists/1/speciality/080508/2`` = _prefix "lists/1/speciality/080508/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080600/1"></see>
    /// </summary>
    let ``lists/1/speciality/080600/1`` = _prefix "lists/1/speciality/080600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080600/3"></see>
    /// </summary>
    let ``lists/1/speciality/080600/3`` = _prefix "lists/1/speciality/080600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080601/2"></see>
    /// </summary>
    let ``lists/1/speciality/080601/2`` = _prefix "lists/1/speciality/080601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080700/1"></see>
    /// </summary>
    let ``lists/1/speciality/080700/1`` = _prefix "lists/1/speciality/080700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080700/3"></see>
    /// </summary>
    let ``lists/1/speciality/080700/3`` = _prefix "lists/1/speciality/080700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/080500/3"></see>
    /// </summary>
    let ``lists/2/speciality/080500/3`` = _prefix "lists/2/speciality/080500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.05/3`` = _prefix "lists/3/speciality/38.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080800/1"></see>
    /// </summary>
    let ``lists/1/speciality/080800/1`` = _prefix "lists/1/speciality/080800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080800/3"></see>
    /// </summary>
    let ``lists/1/speciality/080800/3`` = _prefix "lists/1/speciality/080800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/230700/3"></see>
    /// </summary>
    let ``lists/2/speciality/230700/3`` = _prefix "lists/2/speciality/230700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/09.04.03/3`` = _prefix "lists/3/speciality/09.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/080801/2"></see>
    /// </summary>
    let ``lists/1/speciality/080801/2`` = _prefix "lists/1/speciality/080801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/090103/2"></see>
    /// </summary>
    let ``lists/1/speciality/090103/2`` = _prefix "lists/1/speciality/090103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/090104/2"></see>
    /// </summary>
    let ``lists/1/speciality/090104/2`` = _prefix "lists/1/speciality/090104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/090105/2"></see>
    /// </summary>
    let ``lists/1/speciality/090105/2`` = _prefix "lists/1/speciality/090105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/090106/2"></see>
    /// </summary>
    let ``lists/1/speciality/090106/2`` = _prefix "lists/1/speciality/090106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100100/1"></see>
    /// </summary>
    let ``lists/1/speciality/100100/1`` = _prefix "lists/1/speciality/100100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100100/1"></see>
    /// </summary>
    let ``lists/2/speciality/100100/1`` = _prefix "lists/2/speciality/100100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/43.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/43.03.01/1`` = _prefix "lists/3/speciality/43.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/100000"></see>
    /// </summary>
    let ``lists/1/ugsn/100000`` = _prefix "lists/1/ugsn/100000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100100/3"></see>
    /// </summary>
    let ``lists/1/speciality/100100/3`` = _prefix "lists/1/speciality/100100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100100/3"></see>
    /// </summary>
    let ``lists/2/speciality/100100/3`` = _prefix "lists/2/speciality/100100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/43.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/43.04.01/3`` = _prefix "lists/3/speciality/43.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100101/2"></see>
    /// </summary>
    let ``lists/1/speciality/100101/2`` = _prefix "lists/1/speciality/100101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100103/2"></see>
    /// </summary>
    let ``lists/1/speciality/100103/2`` = _prefix "lists/1/speciality/100103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/43.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/43.03.02/1`` = _prefix "lists/3/speciality/43.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100400/1"></see>
    /// </summary>
    let ``lists/2/speciality/100400/1`` = _prefix "lists/2/speciality/100400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/101100/1"></see>
    /// </summary>
    let ``lists/2/speciality/101100/1`` = _prefix "lists/2/speciality/101100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/43.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/43.03.03/1`` = _prefix "lists/3/speciality/43.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100110/2"></see>
    /// </summary>
    let ``lists/1/speciality/100110/2`` = _prefix "lists/1/speciality/100110/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100200/1"></see>
    /// </summary>
    let ``lists/1/speciality/100200/1`` = _prefix "lists/1/speciality/100200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100200/3"></see>
    /// </summary>
    let ``lists/1/speciality/100200/3`` = _prefix "lists/1/speciality/100200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/101100/3"></see>
    /// </summary>
    let ``lists/2/speciality/101100/3`` = _prefix "lists/2/speciality/101100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/43.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/43.04.03/3`` = _prefix "lists/3/speciality/43.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/43.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/43.04.02/3`` = _prefix "lists/3/speciality/43.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100400/3"></see>
    /// </summary>
    let ``lists/2/speciality/100400/3`` = _prefix "lists/2/speciality/100400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/100201/2"></see>
    /// </summary>
    let ``lists/1/speciality/100201/2`` = _prefix "lists/1/speciality/100201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110100/1"></see>
    /// </summary>
    let ``lists/1/speciality/110100/1`` = _prefix "lists/1/speciality/110100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110100/1"></see>
    /// </summary>
    let ``lists/2/speciality/110100/1`` = _prefix "lists/2/speciality/110100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.03/1`` = _prefix "lists/3/speciality/35.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/110000"></see>
    /// </summary>
    let ``lists/1/ugsn/110000`` = _prefix "lists/1/ugsn/110000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110100/3"></see>
    /// </summary>
    let ``lists/1/speciality/110100/3`` = _prefix "lists/1/speciality/110100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110100/3"></see>
    /// </summary>
    let ``lists/2/speciality/110100/3`` = _prefix "lists/2/speciality/110100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.03/3`` = _prefix "lists/3/speciality/35.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110101/2"></see>
    /// </summary>
    let ``lists/1/speciality/110101/2`` = _prefix "lists/1/speciality/110101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110102/2"></see>
    /// </summary>
    let ``lists/1/speciality/110102/2`` = _prefix "lists/1/speciality/110102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110200/1"></see>
    /// </summary>
    let ``lists/1/speciality/110200/1`` = _prefix "lists/1/speciality/110200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.05/1`` = _prefix "lists/3/speciality/35.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.04/1`` = _prefix "lists/3/speciality/35.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110400/1"></see>
    /// </summary>
    let ``lists/2/speciality/110400/1`` = _prefix "lists/2/speciality/110400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110500/1"></see>
    /// </summary>
    let ``lists/2/speciality/110500/1`` = _prefix "lists/2/speciality/110500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110200/3"></see>
    /// </summary>
    let ``lists/1/speciality/110200/3`` = _prefix "lists/1/speciality/110200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110400/3"></see>
    /// </summary>
    let ``lists/2/speciality/110400/3`` = _prefix "lists/2/speciality/110400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.04/3`` = _prefix "lists/3/speciality/35.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110201/2"></see>
    /// </summary>
    let ``lists/1/speciality/110201/2`` = _prefix "lists/1/speciality/110201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110202/2"></see>
    /// </summary>
    let ``lists/1/speciality/110202/2`` = _prefix "lists/1/speciality/110202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110203/2"></see>
    /// </summary>
    let ``lists/1/speciality/110203/2`` = _prefix "lists/1/speciality/110203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110204/2"></see>
    /// </summary>
    let ``lists/1/speciality/110204/2`` = _prefix "lists/1/speciality/110204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110300/1"></see>
    /// </summary>
    let ``lists/1/speciality/110300/1`` = _prefix "lists/1/speciality/110300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110800/1"></see>
    /// </summary>
    let ``lists/2/speciality/110800/1`` = _prefix "lists/2/speciality/110800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.06/1`` = _prefix "lists/3/speciality/35.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110300/3"></see>
    /// </summary>
    let ``lists/1/speciality/110300/3`` = _prefix "lists/1/speciality/110300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110800/3"></see>
    /// </summary>
    let ``lists/2/speciality/110800/3`` = _prefix "lists/2/speciality/110800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.06/3`` = _prefix "lists/3/speciality/35.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110301/2"></see>
    /// </summary>
    let ``lists/1/speciality/110301/2`` = _prefix "lists/1/speciality/110301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110302/2"></see>
    /// </summary>
    let ``lists/1/speciality/110302/2`` = _prefix "lists/1/speciality/110302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110303/2"></see>
    /// </summary>
    let ``lists/1/speciality/110303/2`` = _prefix "lists/1/speciality/110303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110304/2"></see>
    /// </summary>
    let ``lists/1/speciality/110304/2`` = _prefix "lists/1/speciality/110304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110305/2"></see>
    /// </summary>
    let ``lists/1/speciality/110305/2`` = _prefix "lists/1/speciality/110305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110900/1"></see>
    /// </summary>
    let ``lists/2/speciality/110900/1`` = _prefix "lists/2/speciality/110900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.07/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.07/1`` = _prefix "lists/3/speciality/35.03.07/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110400/1"></see>
    /// </summary>
    let ``lists/1/speciality/110400/1`` = _prefix "lists/1/speciality/110400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111100/1"></see>
    /// </summary>
    let ``lists/2/speciality/111100/1`` = _prefix "lists/2/speciality/111100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/36.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/36.03.02/1`` = _prefix "lists/3/speciality/36.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110400/3"></see>
    /// </summary>
    let ``lists/1/speciality/110400/3`` = _prefix "lists/1/speciality/110400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111100/3"></see>
    /// </summary>
    let ``lists/2/speciality/111100/3`` = _prefix "lists/2/speciality/111100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/36.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/36.04.02/3`` = _prefix "lists/3/speciality/36.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110401/2"></see>
    /// </summary>
    let ``lists/1/speciality/110401/2`` = _prefix "lists/1/speciality/110401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110500/1"></see>
    /// </summary>
    let ``lists/1/speciality/110500/1`` = _prefix "lists/1/speciality/110500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111900/1"></see>
    /// </summary>
    let ``lists/2/speciality/111900/1`` = _prefix "lists/2/speciality/111900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/36.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/36.03.01/1`` = _prefix "lists/3/speciality/36.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110500/3"></see>
    /// </summary>
    let ``lists/1/speciality/110500/3`` = _prefix "lists/1/speciality/110500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111900/3"></see>
    /// </summary>
    let ``lists/2/speciality/111900/3`` = _prefix "lists/2/speciality/111900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/36.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/36.04.01/3`` = _prefix "lists/3/speciality/36.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110501/2"></see>
    /// </summary>
    let ``lists/1/speciality/110501/2`` = _prefix "lists/1/speciality/110501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.03.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/01.03.20/1`` = _prefix "lists/3/speciality/01.03.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110900/1"></see>
    /// </summary>
    let ``lists/1/speciality/110900/1`` = _prefix "lists/1/speciality/110900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111400/1"></see>
    /// </summary>
    let ``lists/2/speciality/111400/1`` = _prefix "lists/2/speciality/111400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.08/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.08/1`` = _prefix "lists/3/speciality/35.03.08/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110900/3"></see>
    /// </summary>
    let ``lists/1/speciality/110900/3`` = _prefix "lists/1/speciality/110900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111400/3"></see>
    /// </summary>
    let ``lists/2/speciality/111400/3`` = _prefix "lists/2/speciality/111400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.07/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.07/3`` = _prefix "lists/3/speciality/35.04.07/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/110901/2"></see>
    /// </summary>
    let ``lists/1/speciality/110901/2`` = _prefix "lists/1/speciality/110901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/111000/1"></see>
    /// </summary>
    let ``lists/1/speciality/111000/1`` = _prefix "lists/1/speciality/111000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111500/1"></see>
    /// </summary>
    let ``lists/2/speciality/111500/1`` = _prefix "lists/2/speciality/111500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.09/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.09/1`` = _prefix "lists/3/speciality/35.03.09/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/111000/3"></see>
    /// </summary>
    let ``lists/1/speciality/111000/3`` = _prefix "lists/1/speciality/111000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/111500/3"></see>
    /// </summary>
    let ``lists/2/speciality/111500/3`` = _prefix "lists/2/speciality/111500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.08/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.08/3`` = _prefix "lists/3/speciality/35.04.08/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/111001/2"></see>
    /// </summary>
    let ``lists/1/speciality/111001/2`` = _prefix "lists/1/speciality/111001/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/111300/1"></see>
    /// </summary>
    let ``lists/1/speciality/111300/1`` = _prefix "lists/1/speciality/111300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/111300/3"></see>
    /// </summary>
    let ``lists/1/speciality/111300/3`` = _prefix "lists/1/speciality/111300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/110500/3"></see>
    /// </summary>
    let ``lists/2/speciality/110500/3`` = _prefix "lists/2/speciality/110500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.05/3`` = _prefix "lists/3/speciality/35.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120100/1"></see>
    /// </summary>
    let ``lists/1/speciality/120100/1`` = _prefix "lists/1/speciality/120100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/120100/1"></see>
    /// </summary>
    let ``lists/2/speciality/120100/1`` = _prefix "lists/2/speciality/120100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/21.03.03/1`` = _prefix "lists/3/speciality/21.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/120000"></see>
    /// </summary>
    let ``lists/1/ugsn/120000`` = _prefix "lists/1/ugsn/120000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120100/3"></see>
    /// </summary>
    let ``lists/1/speciality/120100/3`` = _prefix "lists/1/speciality/120100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/120100/3"></see>
    /// </summary>
    let ``lists/2/speciality/120100/3`` = _prefix "lists/2/speciality/120100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/21.04.03/3`` = _prefix "lists/3/speciality/21.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120102/2"></see>
    /// </summary>
    let ``lists/1/speciality/120102/2`` = _prefix "lists/1/speciality/120102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120103/2"></see>
    /// </summary>
    let ``lists/1/speciality/120103/2`` = _prefix "lists/1/speciality/120103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120201/2"></see>
    /// </summary>
    let ``lists/1/speciality/120201/2`` = _prefix "lists/1/speciality/120201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120202/2"></see>
    /// </summary>
    let ``lists/1/speciality/120202/2`` = _prefix "lists/1/speciality/120202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120300/1"></see>
    /// </summary>
    let ``lists/1/speciality/120300/1`` = _prefix "lists/1/speciality/120300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/120700/1"></see>
    /// </summary>
    let ``lists/2/speciality/120700/1`` = _prefix "lists/2/speciality/120700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/21.03.02/1`` = _prefix "lists/3/speciality/21.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120300/3"></see>
    /// </summary>
    let ``lists/1/speciality/120300/3`` = _prefix "lists/1/speciality/120300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/120700/3"></see>
    /// </summary>
    let ``lists/2/speciality/120700/3`` = _prefix "lists/2/speciality/120700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/21.04.02/3`` = _prefix "lists/3/speciality/21.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120302/2"></see>
    /// </summary>
    let ``lists/1/speciality/120302/2`` = _prefix "lists/1/speciality/120302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/120303/2"></see>
    /// </summary>
    let ``lists/1/speciality/120303/2`` = _prefix "lists/1/speciality/120303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.03.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/21.03.20/1`` = _prefix "lists/3/speciality/21.03.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130100/1"></see>
    /// </summary>
    let ``lists/1/speciality/130100/1`` = _prefix "lists/1/speciality/130100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/130000"></see>
    /// </summary>
    let ``lists/1/ugsn/130000`` = _prefix "lists/1/ugsn/130000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130100/3"></see>
    /// </summary>
    let ``lists/1/speciality/130100/3`` = _prefix "lists/1/speciality/130100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130400/1"></see>
    /// </summary>
    let ``lists/1/speciality/130400/1`` = _prefix "lists/1/speciality/130400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130400/3"></see>
    /// </summary>
    let ``lists/1/speciality/130400/3`` = _prefix "lists/1/speciality/130400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130500/1"></see>
    /// </summary>
    let ``lists/1/speciality/130500/1`` = _prefix "lists/1/speciality/130500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/131000/1"></see>
    /// </summary>
    let ``lists/2/speciality/131000/1`` = _prefix "lists/2/speciality/131000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/21.03.01/1`` = _prefix "lists/3/speciality/21.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130500/3"></see>
    /// </summary>
    let ``lists/1/speciality/130500/3`` = _prefix "lists/1/speciality/130500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/131000/3"></see>
    /// </summary>
    let ``lists/2/speciality/131000/3`` = _prefix "lists/2/speciality/131000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/21.04.01/3`` = _prefix "lists/3/speciality/21.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130501/2"></see>
    /// </summary>
    let ``lists/1/speciality/130501/2`` = _prefix "lists/1/speciality/130501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130503/2"></see>
    /// </summary>
    let ``lists/1/speciality/130503/2`` = _prefix "lists/1/speciality/130503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130504/2"></see>
    /// </summary>
    let ``lists/1/speciality/130504/2`` = _prefix "lists/1/speciality/130504/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130601/2"></see>
    /// </summary>
    let ``lists/1/speciality/130601/2`` = _prefix "lists/1/speciality/130601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/151000/1"></see>
    /// </summary>
    let ``lists/2/speciality/151000/1`` = _prefix "lists/2/speciality/151000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.02/1`` = _prefix "lists/3/speciality/15.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130602/2"></see>
    /// </summary>
    let ``lists/1/speciality/130602/2`` = _prefix "lists/1/speciality/130602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/130603/2"></see>
    /// </summary>
    let ``lists/1/speciality/130603/2`` = _prefix "lists/1/speciality/130603/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140100/1"></see>
    /// </summary>
    let ``lists/1/speciality/140100/1`` = _prefix "lists/1/speciality/140100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140100/1"></see>
    /// </summary>
    let ``lists/2/speciality/140100/1`` = _prefix "lists/2/speciality/140100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/13.03.01/1`` = _prefix "lists/3/speciality/13.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/140000"></see>
    /// </summary>
    let ``lists/1/ugsn/140000`` = _prefix "lists/1/ugsn/140000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140100/3"></see>
    /// </summary>
    let ``lists/1/speciality/140100/3`` = _prefix "lists/1/speciality/140100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140100/3"></see>
    /// </summary>
    let ``lists/2/speciality/140100/3`` = _prefix "lists/2/speciality/140100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/13.04.01/3`` = _prefix "lists/3/speciality/13.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140101/2"></see>
    /// </summary>
    let ``lists/1/speciality/140101/2`` = _prefix "lists/1/speciality/140101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140103/2"></see>
    /// </summary>
    let ``lists/1/speciality/140103/2`` = _prefix "lists/1/speciality/140103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140104/2"></see>
    /// </summary>
    let ``lists/1/speciality/140104/2`` = _prefix "lists/1/speciality/140104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140105/2"></see>
    /// </summary>
    let ``lists/1/speciality/140105/2`` = _prefix "lists/1/speciality/140105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140106/2"></see>
    /// </summary>
    let ``lists/1/speciality/140106/2`` = _prefix "lists/1/speciality/140106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140200/1"></see>
    /// </summary>
    let ``lists/1/speciality/140200/1`` = _prefix "lists/1/speciality/140200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140400/1"></see>
    /// </summary>
    let ``lists/2/speciality/140400/1`` = _prefix "lists/2/speciality/140400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/13.03.02/1`` = _prefix "lists/3/speciality/13.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140200/3"></see>
    /// </summary>
    let ``lists/1/speciality/140200/3`` = _prefix "lists/1/speciality/140200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/16.04.02/3`` = _prefix "lists/3/speciality/16.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/13.04.02/3`` = _prefix "lists/3/speciality/13.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140400/3"></see>
    /// </summary>
    let ``lists/2/speciality/140400/3`` = _prefix "lists/2/speciality/140400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140600/3"></see>
    /// </summary>
    let ``lists/2/speciality/140600/3`` = _prefix "lists/2/speciality/140600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140201/2"></see>
    /// </summary>
    let ``lists/1/speciality/140201/2`` = _prefix "lists/1/speciality/140201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140202/2"></see>
    /// </summary>
    let ``lists/1/speciality/140202/2`` = _prefix "lists/1/speciality/140202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140203/2"></see>
    /// </summary>
    let ``lists/1/speciality/140203/2`` = _prefix "lists/1/speciality/140203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140204/2"></see>
    /// </summary>
    let ``lists/1/speciality/140204/2`` = _prefix "lists/1/speciality/140204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140205/2"></see>
    /// </summary>
    let ``lists/1/speciality/140205/2`` = _prefix "lists/1/speciality/140205/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140209/2"></see>
    /// </summary>
    let ``lists/1/speciality/140209/2`` = _prefix "lists/1/speciality/140209/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140211/2"></see>
    /// </summary>
    let ``lists/1/speciality/140211/2`` = _prefix "lists/1/speciality/140211/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140301/2"></see>
    /// </summary>
    let ``lists/1/speciality/140301/2`` = _prefix "lists/1/speciality/140301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140800/1"></see>
    /// </summary>
    let ``lists/2/speciality/140800/1`` = _prefix "lists/2/speciality/140800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/14.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/14.03.02/1`` = _prefix "lists/3/speciality/14.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140302/2"></see>
    /// </summary>
    let ``lists/1/speciality/140302/2`` = _prefix "lists/1/speciality/140302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140303/2"></see>
    /// </summary>
    let ``lists/1/speciality/140303/2`` = _prefix "lists/1/speciality/140303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140304/2"></see>
    /// </summary>
    let ``lists/1/speciality/140304/2`` = _prefix "lists/1/speciality/140304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140305/2"></see>
    /// </summary>
    let ``lists/1/speciality/140305/2`` = _prefix "lists/1/speciality/140305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140306/2"></see>
    /// </summary>
    let ``lists/1/speciality/140306/2`` = _prefix "lists/1/speciality/140306/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140307/2"></see>
    /// </summary>
    let ``lists/1/speciality/140307/2`` = _prefix "lists/1/speciality/140307/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140309/2"></see>
    /// </summary>
    let ``lists/1/speciality/140309/2`` = _prefix "lists/1/speciality/140309/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140400/1"></see>
    /// </summary>
    let ``lists/1/speciality/140400/1`` = _prefix "lists/1/speciality/140400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140700/1"></see>
    /// </summary>
    let ``lists/2/speciality/140700/1`` = _prefix "lists/2/speciality/140700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/14.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/14.03.01/1`` = _prefix "lists/3/speciality/14.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/223200/1"></see>
    /// </summary>
    let ``lists/2/speciality/223200/1`` = _prefix "lists/2/speciality/223200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.03.00/1"></see>
    /// </summary>
    let ``lists/3/speciality/16.03.00/1`` = _prefix "lists/3/speciality/16.03.00/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140400/3"></see>
    /// </summary>
    let ``lists/1/speciality/140400/3`` = _prefix "lists/1/speciality/140400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140700/3"></see>
    /// </summary>
    let ``lists/2/speciality/140700/3`` = _prefix "lists/2/speciality/140700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/14.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/14.04.01/3`` = _prefix "lists/3/speciality/14.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/16.04.01/3`` = _prefix "lists/3/speciality/16.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/223200/3"></see>
    /// </summary>
    let ``lists/2/speciality/223200/3`` = _prefix "lists/2/speciality/223200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140401/2"></see>
    /// </summary>
    let ``lists/1/speciality/140401/2`` = _prefix "lists/1/speciality/140401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/16.03.01/1`` = _prefix "lists/3/speciality/16.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140402/2"></see>
    /// </summary>
    let ``lists/1/speciality/140402/2`` = _prefix "lists/1/speciality/140402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140403/2"></see>
    /// </summary>
    let ``lists/1/speciality/140403/2`` = _prefix "lists/1/speciality/140403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140404/2"></see>
    /// </summary>
    let ``lists/1/speciality/140404/2`` = _prefix "lists/1/speciality/140404/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140500/1"></see>
    /// </summary>
    let ``lists/1/speciality/140500/1`` = _prefix "lists/1/speciality/140500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/141100/1"></see>
    /// </summary>
    let ``lists/2/speciality/141100/1`` = _prefix "lists/2/speciality/141100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/16.03.02/1`` = _prefix "lists/3/speciality/16.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140600/1"></see>
    /// </summary>
    let ``lists/2/speciality/140600/1`` = _prefix "lists/2/speciality/140600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/141200/1"></see>
    /// </summary>
    let ``lists/2/speciality/141200/1`` = _prefix "lists/2/speciality/141200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/16.03.03/1`` = _prefix "lists/3/speciality/16.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/13.03.03/1`` = _prefix "lists/3/speciality/13.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140500/3"></see>
    /// </summary>
    let ``lists/1/speciality/140500/3`` = _prefix "lists/1/speciality/140500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/13.04.03/3`` = _prefix "lists/3/speciality/13.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/141200/3"></see>
    /// </summary>
    let ``lists/2/speciality/141200/3`` = _prefix "lists/2/speciality/141200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/16.04.03/3`` = _prefix "lists/3/speciality/16.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/141100/3"></see>
    /// </summary>
    let ``lists/2/speciality/141100/3`` = _prefix "lists/2/speciality/141100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140501/2"></see>
    /// </summary>
    let ``lists/1/speciality/140501/2`` = _prefix "lists/1/speciality/140501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140503/2"></see>
    /// </summary>
    let ``lists/1/speciality/140503/2`` = _prefix "lists/1/speciality/140503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140504/2"></see>
    /// </summary>
    let ``lists/1/speciality/140504/2`` = _prefix "lists/1/speciality/140504/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140600/1"></see>
    /// </summary>
    let ``lists/1/speciality/140600/1`` = _prefix "lists/1/speciality/140600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140600/3"></see>
    /// </summary>
    let ``lists/1/speciality/140600/3`` = _prefix "lists/1/speciality/140600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140601/2"></see>
    /// </summary>
    let ``lists/1/speciality/140601/2`` = _prefix "lists/1/speciality/140601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140602/2"></see>
    /// </summary>
    let ``lists/1/speciality/140602/2`` = _prefix "lists/1/speciality/140602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140604/2"></see>
    /// </summary>
    let ``lists/1/speciality/140604/2`` = _prefix "lists/1/speciality/140604/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140605/2"></see>
    /// </summary>
    let ``lists/1/speciality/140605/2`` = _prefix "lists/1/speciality/140605/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140606/2"></see>
    /// </summary>
    let ``lists/1/speciality/140606/2`` = _prefix "lists/1/speciality/140606/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140607/2"></see>
    /// </summary>
    let ``lists/1/speciality/140607/2`` = _prefix "lists/1/speciality/140607/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140608/2"></see>
    /// </summary>
    let ``lists/1/speciality/140608/2`` = _prefix "lists/1/speciality/140608/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140609/2"></see>
    /// </summary>
    let ``lists/1/speciality/140609/2`` = _prefix "lists/1/speciality/140609/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140610/2"></see>
    /// </summary>
    let ``lists/1/speciality/140610/2`` = _prefix "lists/1/speciality/140610/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/140611/2"></see>
    /// </summary>
    let ``lists/1/speciality/140611/2`` = _prefix "lists/1/speciality/140611/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150100/1"></see>
    /// </summary>
    let ``lists/1/speciality/150100/1`` = _prefix "lists/1/speciality/150100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/150400/1"></see>
    /// </summary>
    let ``lists/2/speciality/150400/1`` = _prefix "lists/2/speciality/150400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/22.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/22.03.02/1`` = _prefix "lists/3/speciality/22.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/150000"></see>
    /// </summary>
    let ``lists/1/ugsn/150000`` = _prefix "lists/1/ugsn/150000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150100/3"></see>
    /// </summary>
    let ``lists/1/speciality/150100/3`` = _prefix "lists/1/speciality/150100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/150400/3"></see>
    /// </summary>
    let ``lists/2/speciality/150400/3`` = _prefix "lists/2/speciality/150400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/22.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/22.04.02/3`` = _prefix "lists/3/speciality/22.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150101/2"></see>
    /// </summary>
    let ``lists/1/speciality/150101/2`` = _prefix "lists/1/speciality/150101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150102/2"></see>
    /// </summary>
    let ``lists/1/speciality/150102/2`` = _prefix "lists/1/speciality/150102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150103/2"></see>
    /// </summary>
    let ``lists/1/speciality/150103/2`` = _prefix "lists/1/speciality/150103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150104/2"></see>
    /// </summary>
    let ``lists/1/speciality/150104/2`` = _prefix "lists/1/speciality/150104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150105/2"></see>
    /// </summary>
    let ``lists/1/speciality/150105/2`` = _prefix "lists/1/speciality/150105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150106/2"></see>
    /// </summary>
    let ``lists/1/speciality/150106/2`` = _prefix "lists/1/speciality/150106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150107/2"></see>
    /// </summary>
    let ``lists/1/speciality/150107/2`` = _prefix "lists/1/speciality/150107/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150108/2"></see>
    /// </summary>
    let ``lists/1/speciality/150108/2`` = _prefix "lists/1/speciality/150108/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150109/2"></see>
    /// </summary>
    let ``lists/1/speciality/150109/2`` = _prefix "lists/1/speciality/150109/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150201/2"></see>
    /// </summary>
    let ``lists/1/speciality/150201/2`` = _prefix "lists/1/speciality/150201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/150700/1"></see>
    /// </summary>
    let ``lists/2/speciality/150700/1`` = _prefix "lists/2/speciality/150700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.01/1`` = _prefix "lists/3/speciality/15.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150202/2"></see>
    /// </summary>
    let ``lists/1/speciality/150202/2`` = _prefix "lists/1/speciality/150202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150204/2"></see>
    /// </summary>
    let ``lists/1/speciality/150204/2`` = _prefix "lists/1/speciality/150204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150205/2"></see>
    /// </summary>
    let ``lists/1/speciality/150205/2`` = _prefix "lists/1/speciality/150205/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150206/2"></see>
    /// </summary>
    let ``lists/1/speciality/150206/2`` = _prefix "lists/1/speciality/150206/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.20/1`` = _prefix "lists/3/speciality/15.03.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150207/2"></see>
    /// </summary>
    let ``lists/1/speciality/150207/2`` = _prefix "lists/1/speciality/150207/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150300/1"></see>
    /// </summary>
    let ``lists/1/speciality/150300/1`` = _prefix "lists/1/speciality/150300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/151600/1"></see>
    /// </summary>
    let ``lists/2/speciality/151600/1`` = _prefix "lists/2/speciality/151600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.03/1`` = _prefix "lists/3/speciality/15.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150300/3"></see>
    /// </summary>
    let ``lists/1/speciality/150300/3`` = _prefix "lists/1/speciality/150300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/151600/3"></see>
    /// </summary>
    let ``lists/2/speciality/151600/3`` = _prefix "lists/2/speciality/151600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/15.04.03/3`` = _prefix "lists/3/speciality/15.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150301/2"></see>
    /// </summary>
    let ``lists/1/speciality/150301/2`` = _prefix "lists/1/speciality/150301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150302/2"></see>
    /// </summary>
    let ``lists/1/speciality/150302/2`` = _prefix "lists/1/speciality/150302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150400/2"></see>
    /// </summary>
    let ``lists/1/speciality/150400/2`` = _prefix "lists/1/speciality/150400/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/150700/3"></see>
    /// </summary>
    let ``lists/2/speciality/150700/3`` = _prefix "lists/2/speciality/150700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.04.02/2"></see>
    /// </summary>
    let ``lists/3/speciality/15.04.02/2`` = _prefix "lists/3/speciality/15.04.02/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/15.04.01/3`` = _prefix "lists/3/speciality/15.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/151000/2"></see>
    /// </summary>
    let ``lists/2/speciality/151000/2`` = _prefix "lists/2/speciality/151000/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150401/2"></see>
    /// </summary>
    let ``lists/1/speciality/150401/2`` = _prefix "lists/1/speciality/150401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150403/2"></see>
    /// </summary>
    let ``lists/1/speciality/150403/2`` = _prefix "lists/1/speciality/150403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150404/2"></see>
    /// </summary>
    let ``lists/1/speciality/150404/2`` = _prefix "lists/1/speciality/150404/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150405/2"></see>
    /// </summary>
    let ``lists/1/speciality/150405/2`` = _prefix "lists/1/speciality/150405/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150406/2"></see>
    /// </summary>
    let ``lists/1/speciality/150406/2`` = _prefix "lists/1/speciality/150406/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150407/2"></see>
    /// </summary>
    let ``lists/1/speciality/150407/2`` = _prefix "lists/1/speciality/150407/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150408/2"></see>
    /// </summary>
    let ``lists/1/speciality/150408/2`` = _prefix "lists/1/speciality/150408/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150501/2"></see>
    /// </summary>
    let ``lists/1/speciality/150501/2`` = _prefix "lists/1/speciality/150501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150502/2"></see>
    /// </summary>
    let ``lists/1/speciality/150502/2`` = _prefix "lists/1/speciality/150502/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/150100/1"></see>
    /// </summary>
    let ``lists/2/speciality/150100/1`` = _prefix "lists/2/speciality/150100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/22.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/22.03.01/1`` = _prefix "lists/3/speciality/22.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150600/1"></see>
    /// </summary>
    let ``lists/1/speciality/150600/1`` = _prefix "lists/1/speciality/150600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150600/3"></see>
    /// </summary>
    let ``lists/1/speciality/150600/3`` = _prefix "lists/1/speciality/150600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/150100/3"></see>
    /// </summary>
    let ``lists/2/speciality/150100/3`` = _prefix "lists/2/speciality/150100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/22.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/22.04.01/3`` = _prefix "lists/3/speciality/22.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150601/2"></see>
    /// </summary>
    let ``lists/1/speciality/150601/2`` = _prefix "lists/1/speciality/150601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150701/2"></see>
    /// </summary>
    let ``lists/1/speciality/150701/2`` = _prefix "lists/1/speciality/150701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150702/2"></see>
    /// </summary>
    let ``lists/1/speciality/150702/2`` = _prefix "lists/1/speciality/150702/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150800/1"></see>
    /// </summary>
    let ``lists/1/speciality/150800/1`` = _prefix "lists/1/speciality/150800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150800/3"></see>
    /// </summary>
    let ``lists/1/speciality/150800/3`` = _prefix "lists/1/speciality/150800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150801/2"></see>
    /// </summary>
    let ``lists/1/speciality/150801/2`` = _prefix "lists/1/speciality/150801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150802/2"></see>
    /// </summary>
    let ``lists/1/speciality/150802/2`` = _prefix "lists/1/speciality/150802/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150900/1"></see>
    /// </summary>
    let ``lists/1/speciality/150900/1`` = _prefix "lists/1/speciality/150900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/150900/3"></see>
    /// </summary>
    let ``lists/1/speciality/150900/3`` = _prefix "lists/1/speciality/150900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/151900/3"></see>
    /// </summary>
    let ``lists/2/speciality/151900/3`` = _prefix "lists/2/speciality/151900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/15.04.05/3`` = _prefix "lists/3/speciality/15.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/151000/1"></see>
    /// </summary>
    let ``lists/1/speciality/151000/1`` = _prefix "lists/1/speciality/151000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/151900/1"></see>
    /// </summary>
    let ``lists/2/speciality/151900/1`` = _prefix "lists/2/speciality/151900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.05/1`` = _prefix "lists/3/speciality/15.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/151000/3"></see>
    /// </summary>
    let ``lists/1/speciality/151000/3`` = _prefix "lists/1/speciality/151000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/151001/2"></see>
    /// </summary>
    let ``lists/1/speciality/151001/2`` = _prefix "lists/1/speciality/151001/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/151002/2"></see>
    /// </summary>
    let ``lists/1/speciality/151002/2`` = _prefix "lists/1/speciality/151002/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/151003/2"></see>
    /// </summary>
    let ``lists/1/speciality/151003/2`` = _prefix "lists/1/speciality/151003/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160100/1"></see>
    /// </summary>
    let ``lists/1/speciality/160100/1`` = _prefix "lists/1/speciality/160100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/160700/1"></see>
    /// </summary>
    let ``lists/2/speciality/160700/1`` = _prefix "lists/2/speciality/160700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/24.03.01/1`` = _prefix "lists/3/speciality/24.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/160400/1"></see>
    /// </summary>
    let ``lists/2/speciality/160400/1`` = _prefix "lists/2/speciality/160400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/24.03.04/1`` = _prefix "lists/3/speciality/24.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/161100/1"></see>
    /// </summary>
    let ``lists/2/speciality/161100/1`` = _prefix "lists/2/speciality/161100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/160100/1"></see>
    /// </summary>
    let ``lists/2/speciality/160100/1`` = _prefix "lists/2/speciality/160100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/24.03.02/1`` = _prefix "lists/3/speciality/24.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/24.03.05/1`` = _prefix "lists/3/speciality/24.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/160000"></see>
    /// </summary>
    let ``lists/1/ugsn/160000`` = _prefix "lists/1/ugsn/160000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160100/3"></see>
    /// </summary>
    let ``lists/1/speciality/160100/3`` = _prefix "lists/1/speciality/160100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/160700/3"></see>
    /// </summary>
    let ``lists/2/speciality/160700/3`` = _prefix "lists/2/speciality/160700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/160100/3"></see>
    /// </summary>
    let ``lists/2/speciality/160100/3`` = _prefix "lists/2/speciality/160100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/160400/3"></see>
    /// </summary>
    let ``lists/2/speciality/160400/3`` = _prefix "lists/2/speciality/160400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/24.04.04/3`` = _prefix "lists/3/speciality/24.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/24.04.05/3`` = _prefix "lists/3/speciality/24.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/24.04.01/3`` = _prefix "lists/3/speciality/24.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/161700/3"></see>
    /// </summary>
    let ``lists/2/speciality/161700/3`` = _prefix "lists/2/speciality/161700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/161100/3"></see>
    /// </summary>
    let ``lists/2/speciality/161100/3`` = _prefix "lists/2/speciality/161100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/24.04.02/3`` = _prefix "lists/3/speciality/24.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/24.04.03/3`` = _prefix "lists/3/speciality/24.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160201/2"></see>
    /// </summary>
    let ``lists/1/speciality/160201/2`` = _prefix "lists/1/speciality/160201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/161700/1"></see>
    /// </summary>
    let ``lists/2/speciality/161700/1`` = _prefix "lists/2/speciality/161700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/24.03.03/1`` = _prefix "lists/3/speciality/24.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160202/2"></see>
    /// </summary>
    let ``lists/1/speciality/160202/2`` = _prefix "lists/1/speciality/160202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160301/2"></see>
    /// </summary>
    let ``lists/1/speciality/160301/2`` = _prefix "lists/1/speciality/160301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160302/2"></see>
    /// </summary>
    let ``lists/1/speciality/160302/2`` = _prefix "lists/1/speciality/160302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160303/2"></see>
    /// </summary>
    let ``lists/1/speciality/160303/2`` = _prefix "lists/1/speciality/160303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160304/2"></see>
    /// </summary>
    let ``lists/1/speciality/160304/2`` = _prefix "lists/1/speciality/160304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160401/2"></see>
    /// </summary>
    let ``lists/1/speciality/160401/2`` = _prefix "lists/1/speciality/160401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160402/2"></see>
    /// </summary>
    let ``lists/1/speciality/160402/2`` = _prefix "lists/1/speciality/160402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160403/2"></see>
    /// </summary>
    let ``lists/1/speciality/160403/2`` = _prefix "lists/1/speciality/160403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160501/2"></see>
    /// </summary>
    let ``lists/1/speciality/160501/2`` = _prefix "lists/1/speciality/160501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/25.03.03/1`` = _prefix "lists/3/speciality/25.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/161000/1"></see>
    /// </summary>
    let ``lists/2/speciality/161000/1`` = _prefix "lists/2/speciality/161000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160503/2"></see>
    /// </summary>
    let ``lists/1/speciality/160503/2`` = _prefix "lists/1/speciality/160503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/162700/1"></see>
    /// </summary>
    let ``lists/2/speciality/162700/1`` = _prefix "lists/2/speciality/162700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/25.03.04/1`` = _prefix "lists/3/speciality/25.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160505/2"></see>
    /// </summary>
    let ``lists/1/speciality/160505/2`` = _prefix "lists/1/speciality/160505/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160701/2"></see>
    /// </summary>
    let ``lists/1/speciality/160701/2`` = _prefix "lists/1/speciality/160701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160702/2"></see>
    /// </summary>
    let ``lists/1/speciality/160702/2`` = _prefix "lists/1/speciality/160702/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160703/2"></see>
    /// </summary>
    let ``lists/1/speciality/160703/2`` = _prefix "lists/1/speciality/160703/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160801/2"></see>
    /// </summary>
    let ``lists/1/speciality/160801/2`` = _prefix "lists/1/speciality/160801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160802/2"></see>
    /// </summary>
    let ``lists/1/speciality/160802/2`` = _prefix "lists/1/speciality/160802/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160803/2"></see>
    /// </summary>
    let ``lists/1/speciality/160803/2`` = _prefix "lists/1/speciality/160803/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160804/2"></see>
    /// </summary>
    let ``lists/1/speciality/160804/2`` = _prefix "lists/1/speciality/160804/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160900/1"></see>
    /// </summary>
    let ``lists/1/speciality/160900/1`` = _prefix "lists/1/speciality/160900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160900/3"></see>
    /// </summary>
    let ``lists/1/speciality/160900/3`` = _prefix "lists/1/speciality/160900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/25.04.01/3`` = _prefix "lists/3/speciality/25.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/162500/3"></see>
    /// </summary>
    let ``lists/2/speciality/162500/3`` = _prefix "lists/2/speciality/162500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/162300/3"></see>
    /// </summary>
    let ``lists/2/speciality/162300/3`` = _prefix "lists/2/speciality/162300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/25.04.02/3`` = _prefix "lists/3/speciality/25.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160901/2"></see>
    /// </summary>
    let ``lists/1/speciality/160901/2`` = _prefix "lists/1/speciality/160901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/162300/1"></see>
    /// </summary>
    let ``lists/2/speciality/162300/1`` = _prefix "lists/2/speciality/162300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/25.03.01/1`` = _prefix "lists/3/speciality/25.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/160903/2"></see>
    /// </summary>
    let ``lists/1/speciality/160903/2`` = _prefix "lists/1/speciality/160903/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/162500/1"></see>
    /// </summary>
    let ``lists/2/speciality/162500/1`` = _prefix "lists/2/speciality/162500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/25.03.02/1`` = _prefix "lists/3/speciality/25.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180100/1"></see>
    /// </summary>
    let ``lists/1/speciality/180100/1`` = _prefix "lists/1/speciality/180100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/180100/1"></see>
    /// </summary>
    let ``lists/2/speciality/180100/1`` = _prefix "lists/2/speciality/180100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/26.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/26.03.02/1`` = _prefix "lists/3/speciality/26.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/180000"></see>
    /// </summary>
    let ``lists/1/ugsn/180000`` = _prefix "lists/1/ugsn/180000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180100/3"></see>
    /// </summary>
    let ``lists/1/speciality/180100/3`` = _prefix "lists/1/speciality/180100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/17.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/17.04.01/3`` = _prefix "lists/3/speciality/17.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/180800/3"></see>
    /// </summary>
    let ``lists/2/speciality/180800/3`` = _prefix "lists/2/speciality/180800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/180100/3"></see>
    /// </summary>
    let ``lists/2/speciality/180100/3`` = _prefix "lists/2/speciality/180100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/26.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/26.04.02/3`` = _prefix "lists/3/speciality/26.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180101/2"></see>
    /// </summary>
    let ``lists/1/speciality/180101/2`` = _prefix "lists/1/speciality/180101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/180800/1"></see>
    /// </summary>
    let ``lists/2/speciality/180800/1`` = _prefix "lists/2/speciality/180800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/17.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/17.03.01/1`` = _prefix "lists/3/speciality/17.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180103/2"></see>
    /// </summary>
    let ``lists/1/speciality/180103/2`` = _prefix "lists/1/speciality/180103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180104/2"></see>
    /// </summary>
    let ``lists/1/speciality/180104/2`` = _prefix "lists/1/speciality/180104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180105/2"></see>
    /// </summary>
    let ``lists/1/speciality/180105/2`` = _prefix "lists/1/speciality/180105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180106/2"></see>
    /// </summary>
    let ``lists/1/speciality/180106/2`` = _prefix "lists/1/speciality/180106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180201/2"></see>
    /// </summary>
    let ``lists/1/speciality/180201/2`` = _prefix "lists/1/speciality/180201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180202/2"></see>
    /// </summary>
    let ``lists/1/speciality/180202/2`` = _prefix "lists/1/speciality/180202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180301/2"></see>
    /// </summary>
    let ``lists/1/speciality/180301/2`` = _prefix "lists/1/speciality/180301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180302/2"></see>
    /// </summary>
    let ``lists/1/speciality/180302/2`` = _prefix "lists/1/speciality/180302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180303/2"></see>
    /// </summary>
    let ``lists/1/speciality/180303/2`` = _prefix "lists/1/speciality/180303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180304/2"></see>
    /// </summary>
    let ``lists/1/speciality/180304/2`` = _prefix "lists/1/speciality/180304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180305/2"></see>
    /// </summary>
    let ``lists/1/speciality/180305/2`` = _prefix "lists/1/speciality/180305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/180401/2"></see>
    /// </summary>
    let ``lists/1/speciality/180401/2`` = _prefix "lists/1/speciality/180401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/180500/1"></see>
    /// </summary>
    let ``lists/2/speciality/180500/1`` = _prefix "lists/2/speciality/180500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/26.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/26.03.01/1`` = _prefix "lists/3/speciality/26.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190100/3"></see>
    /// </summary>
    let ``lists/1/speciality/190100/3`` = _prefix "lists/1/speciality/190100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/190100/3"></see>
    /// </summary>
    let ``lists/2/speciality/190100/3`` = _prefix "lists/2/speciality/190100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/23.04.02/3`` = _prefix "lists/3/speciality/23.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/190000"></see>
    /// </summary>
    let ``lists/1/ugsn/190000`` = _prefix "lists/1/ugsn/190000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190201/2"></see>
    /// </summary>
    let ``lists/1/speciality/190201/2`` = _prefix "lists/1/speciality/190201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/190100/1"></see>
    /// </summary>
    let ``lists/2/speciality/190100/1`` = _prefix "lists/2/speciality/190100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/23.03.02/1`` = _prefix "lists/3/speciality/23.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190202/2"></see>
    /// </summary>
    let ``lists/1/speciality/190202/2`` = _prefix "lists/1/speciality/190202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190203/2"></see>
    /// </summary>
    let ``lists/1/speciality/190203/2`` = _prefix "lists/1/speciality/190203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190204/2"></see>
    /// </summary>
    let ``lists/1/speciality/190204/2`` = _prefix "lists/1/speciality/190204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190205/2"></see>
    /// </summary>
    let ``lists/1/speciality/190205/2`` = _prefix "lists/1/speciality/190205/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190206/2"></see>
    /// </summary>
    let ``lists/1/speciality/190206/2`` = _prefix "lists/1/speciality/190206/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190207/2"></see>
    /// </summary>
    let ``lists/1/speciality/190207/2`` = _prefix "lists/1/speciality/190207/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190500/1"></see>
    /// </summary>
    let ``lists/1/speciality/190500/1`` = _prefix "lists/1/speciality/190500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/190600/1"></see>
    /// </summary>
    let ``lists/2/speciality/190600/1`` = _prefix "lists/2/speciality/190600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/23.03.03/1`` = _prefix "lists/3/speciality/23.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190500/3"></see>
    /// </summary>
    let ``lists/1/speciality/190500/3`` = _prefix "lists/1/speciality/190500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/23.04.03/3`` = _prefix "lists/3/speciality/23.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/190600/3"></see>
    /// </summary>
    let ``lists/2/speciality/190600/3`` = _prefix "lists/2/speciality/190600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/26.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/26.04.01/3`` = _prefix "lists/3/speciality/26.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/180500/3"></see>
    /// </summary>
    let ``lists/2/speciality/180500/3`` = _prefix "lists/2/speciality/180500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/23.04.01/3`` = _prefix "lists/3/speciality/23.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/190700/3"></see>
    /// </summary>
    let ``lists/2/speciality/190700/3`` = _prefix "lists/2/speciality/190700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190601/2"></see>
    /// </summary>
    let ``lists/1/speciality/190601/2`` = _prefix "lists/1/speciality/190601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/190700/1"></see>
    /// </summary>
    let ``lists/2/speciality/190700/1`` = _prefix "lists/2/speciality/190700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/23.03.01/1`` = _prefix "lists/3/speciality/23.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190602/2"></see>
    /// </summary>
    let ``lists/1/speciality/190602/2`` = _prefix "lists/1/speciality/190602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190603/2"></see>
    /// </summary>
    let ``lists/1/speciality/190603/2`` = _prefix "lists/1/speciality/190603/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190701/2"></see>
    /// </summary>
    let ``lists/1/speciality/190701/2`` = _prefix "lists/1/speciality/190701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/190702/2"></see>
    /// </summary>
    let ``lists/1/speciality/190702/2`` = _prefix "lists/1/speciality/190702/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200100/3"></see>
    /// </summary>
    let ``lists/1/speciality/200100/3`` = _prefix "lists/1/speciality/200100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200100/3"></see>
    /// </summary>
    let ``lists/2/speciality/200100/3`` = _prefix "lists/2/speciality/200100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/12.04.01/3`` = _prefix "lists/3/speciality/12.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/200000"></see>
    /// </summary>
    let ``lists/1/ugsn/200000`` = _prefix "lists/1/ugsn/200000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200101/2"></see>
    /// </summary>
    let ``lists/1/speciality/200101/2`` = _prefix "lists/1/speciality/200101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200100/1"></see>
    /// </summary>
    let ``lists/2/speciality/200100/1`` = _prefix "lists/2/speciality/200100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/12.03.01/1`` = _prefix "lists/3/speciality/12.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200102/2"></see>
    /// </summary>
    let ``lists/1/speciality/200102/2`` = _prefix "lists/1/speciality/200102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200103/2"></see>
    /// </summary>
    let ``lists/1/speciality/200103/2`` = _prefix "lists/1/speciality/200103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.12.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/03.12.20/1`` = _prefix "lists/3/speciality/03.12.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200105/2"></see>
    /// </summary>
    let ``lists/1/speciality/200105/2`` = _prefix "lists/1/speciality/200105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200106/2"></see>
    /// </summary>
    let ``lists/1/speciality/200106/2`` = _prefix "lists/1/speciality/200106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200107/2"></see>
    /// </summary>
    let ``lists/1/speciality/200107/2`` = _prefix "lists/1/speciality/200107/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200200/1"></see>
    /// </summary>
    let ``lists/1/speciality/200200/1`` = _prefix "lists/1/speciality/200200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/12.03.02/1`` = _prefix "lists/3/speciality/12.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200400/1"></see>
    /// </summary>
    let ``lists/2/speciality/200400/1`` = _prefix "lists/2/speciality/200400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200200/3"></see>
    /// </summary>
    let ``lists/1/speciality/200200/3`` = _prefix "lists/1/speciality/200200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/12.04.05/3`` = _prefix "lists/3/speciality/12.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200500/3"></see>
    /// </summary>
    let ``lists/2/speciality/200500/3`` = _prefix "lists/2/speciality/200500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/12.04.02/3`` = _prefix "lists/3/speciality/12.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200400/3"></see>
    /// </summary>
    let ``lists/2/speciality/200400/3`` = _prefix "lists/2/speciality/200400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200201/2"></see>
    /// </summary>
    let ``lists/1/speciality/200201/2`` = _prefix "lists/1/speciality/200201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200500/1"></see>
    /// </summary>
    let ``lists/2/speciality/200500/1`` = _prefix "lists/2/speciality/200500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/12.03.05/1`` = _prefix "lists/3/speciality/12.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200202/2"></see>
    /// </summary>
    let ``lists/1/speciality/200202/2`` = _prefix "lists/1/speciality/200202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200203/2"></see>
    /// </summary>
    let ``lists/1/speciality/200203/2`` = _prefix "lists/1/speciality/200203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200206/2"></see>
    /// </summary>
    let ``lists/1/speciality/200206/2`` = _prefix "lists/1/speciality/200206/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200300/1"></see>
    /// </summary>
    let ``lists/1/speciality/200300/1`` = _prefix "lists/1/speciality/200300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200700/1"></see>
    /// </summary>
    let ``lists/2/speciality/200700/1`` = _prefix "lists/2/speciality/200700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/12.03.03/1`` = _prefix "lists/3/speciality/12.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200300/3"></see>
    /// </summary>
    let ``lists/1/speciality/200300/3`` = _prefix "lists/1/speciality/200300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/201000/3"></see>
    /// </summary>
    let ``lists/2/speciality/201000/3`` = _prefix "lists/2/speciality/201000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/12.04.04/3`` = _prefix "lists/3/speciality/12.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200401/2"></see>
    /// </summary>
    let ``lists/1/speciality/200401/2`` = _prefix "lists/1/speciality/200401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/201000/1"></see>
    /// </summary>
    let ``lists/2/speciality/201000/1`` = _prefix "lists/2/speciality/201000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/12.03.04/1`` = _prefix "lists/3/speciality/12.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200402/2"></see>
    /// </summary>
    let ``lists/1/speciality/200402/2`` = _prefix "lists/1/speciality/200402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200500/1"></see>
    /// </summary>
    let ``lists/1/speciality/200500/1`` = _prefix "lists/1/speciality/200500/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200500/3"></see>
    /// </summary>
    let ``lists/1/speciality/200500/3`` = _prefix "lists/1/speciality/200500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.01/3`` = _prefix "lists/3/speciality/27.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.02/3`` = _prefix "lists/3/speciality/27.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/221700/3"></see>
    /// </summary>
    let ``lists/2/speciality/221700/3`` = _prefix "lists/2/speciality/221700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/221400/3"></see>
    /// </summary>
    let ``lists/2/speciality/221400/3`` = _prefix "lists/2/speciality/221400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200501/2"></see>
    /// </summary>
    let ``lists/1/speciality/200501/2`` = _prefix "lists/1/speciality/200501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/221700/1"></see>
    /// </summary>
    let ``lists/2/speciality/221700/1`` = _prefix "lists/2/speciality/221700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/27.03.01/1`` = _prefix "lists/3/speciality/27.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200503/2"></see>
    /// </summary>
    let ``lists/1/speciality/200503/2`` = _prefix "lists/1/speciality/200503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200600/1"></see>
    /// </summary>
    let ``lists/1/speciality/200600/1`` = _prefix "lists/1/speciality/200600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/200600/3"></see>
    /// </summary>
    let ``lists/1/speciality/200600/3`` = _prefix "lists/1/speciality/200600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/200700/3"></see>
    /// </summary>
    let ``lists/2/speciality/200700/3`` = _prefix "lists/2/speciality/200700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/12.04.03/3`` = _prefix "lists/3/speciality/12.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/201120/2"></see>
    /// </summary>
    let ``lists/1/speciality/201120/2`` = _prefix "lists/1/speciality/201120/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210100/1"></see>
    /// </summary>
    let ``lists/1/speciality/210100/1`` = _prefix "lists/1/speciality/210100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/210100/1"></see>
    /// </summary>
    let ``lists/2/speciality/210100/1`` = _prefix "lists/2/speciality/210100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/11.03.04/1`` = _prefix "lists/3/speciality/11.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/210000"></see>
    /// </summary>
    let ``lists/1/ugsn/210000`` = _prefix "lists/1/ugsn/210000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210100/3"></see>
    /// </summary>
    let ``lists/1/speciality/210100/3`` = _prefix "lists/1/speciality/210100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/210100/3"></see>
    /// </summary>
    let ``lists/2/speciality/210100/3`` = _prefix "lists/2/speciality/210100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/11.04.04/3`` = _prefix "lists/3/speciality/11.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210101/2"></see>
    /// </summary>
    let ``lists/1/speciality/210101/2`` = _prefix "lists/1/speciality/210101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210102/2"></see>
    /// </summary>
    let ``lists/1/speciality/210102/2`` = _prefix "lists/1/speciality/210102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210103/2"></see>
    /// </summary>
    let ``lists/1/speciality/210103/2`` = _prefix "lists/1/speciality/210103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210104/2"></see>
    /// </summary>
    let ``lists/1/speciality/210104/2`` = _prefix "lists/1/speciality/210104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210105/2"></see>
    /// </summary>
    let ``lists/1/speciality/210105/2`` = _prefix "lists/1/speciality/210105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210106/2"></see>
    /// </summary>
    let ``lists/1/speciality/210106/2`` = _prefix "lists/1/speciality/210106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210107/2"></see>
    /// </summary>
    let ``lists/1/speciality/210107/2`` = _prefix "lists/1/speciality/210107/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210108/2"></see>
    /// </summary>
    let ``lists/1/speciality/210108/2`` = _prefix "lists/1/speciality/210108/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/28.03.01/1`` = _prefix "lists/3/speciality/28.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/222900/1"></see>
    /// </summary>
    let ``lists/2/speciality/222900/1`` = _prefix "lists/2/speciality/222900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210200/1"></see>
    /// </summary>
    let ``lists/1/speciality/210200/1`` = _prefix "lists/1/speciality/210200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/211000/1"></see>
    /// </summary>
    let ``lists/2/speciality/211000/1`` = _prefix "lists/2/speciality/211000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/11.03.03/1`` = _prefix "lists/3/speciality/11.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210200/3"></see>
    /// </summary>
    let ``lists/1/speciality/210200/3`` = _prefix "lists/1/speciality/210200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/211000/3"></see>
    /// </summary>
    let ``lists/2/speciality/211000/3`` = _prefix "lists/2/speciality/211000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/11.04.03/3`` = _prefix "lists/3/speciality/11.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210201/2"></see>
    /// </summary>
    let ``lists/1/speciality/210201/2`` = _prefix "lists/1/speciality/210201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210202/2"></see>
    /// </summary>
    let ``lists/1/speciality/210202/2`` = _prefix "lists/1/speciality/210202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210300/1"></see>
    /// </summary>
    let ``lists/1/speciality/210300/1`` = _prefix "lists/1/speciality/210300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/210400/1"></see>
    /// </summary>
    let ``lists/2/speciality/210400/1`` = _prefix "lists/2/speciality/210400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/11.03.01/1`` = _prefix "lists/3/speciality/11.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210300/3"></see>
    /// </summary>
    let ``lists/1/speciality/210300/3`` = _prefix "lists/1/speciality/210300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/210400/3"></see>
    /// </summary>
    let ``lists/2/speciality/210400/3`` = _prefix "lists/2/speciality/210400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/11.04.01/3`` = _prefix "lists/3/speciality/11.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210301/2"></see>
    /// </summary>
    let ``lists/1/speciality/210301/2`` = _prefix "lists/1/speciality/210301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210302/2"></see>
    /// </summary>
    let ``lists/1/speciality/210302/2`` = _prefix "lists/1/speciality/210302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210303/2"></see>
    /// </summary>
    let ``lists/1/speciality/210303/2`` = _prefix "lists/1/speciality/210303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210304/2"></see>
    /// </summary>
    let ``lists/1/speciality/210304/2`` = _prefix "lists/1/speciality/210304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210305/2"></see>
    /// </summary>
    let ``lists/1/speciality/210305/2`` = _prefix "lists/1/speciality/210305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210312/2"></see>
    /// </summary>
    let ``lists/1/speciality/210312/2`` = _prefix "lists/1/speciality/210312/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210400/1"></see>
    /// </summary>
    let ``lists/1/speciality/210400/1`` = _prefix "lists/1/speciality/210400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/210700/1"></see>
    /// </summary>
    let ``lists/2/speciality/210700/1`` = _prefix "lists/2/speciality/210700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/11.03.02/1`` = _prefix "lists/3/speciality/11.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210400/3"></see>
    /// </summary>
    let ``lists/1/speciality/210400/3`` = _prefix "lists/1/speciality/210400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/210700/3"></see>
    /// </summary>
    let ``lists/2/speciality/210700/3`` = _prefix "lists/2/speciality/210700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/11.04.02/3`` = _prefix "lists/3/speciality/11.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210401/2"></see>
    /// </summary>
    let ``lists/1/speciality/210401/2`` = _prefix "lists/1/speciality/210401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210402/2"></see>
    /// </summary>
    let ``lists/1/speciality/210402/2`` = _prefix "lists/1/speciality/210402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210403/2"></see>
    /// </summary>
    let ``lists/1/speciality/210403/2`` = _prefix "lists/1/speciality/210403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210404/2"></see>
    /// </summary>
    let ``lists/1/speciality/210404/2`` = _prefix "lists/1/speciality/210404/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210405/2"></see>
    /// </summary>
    let ``lists/1/speciality/210405/2`` = _prefix "lists/1/speciality/210405/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210406/2"></see>
    /// </summary>
    let ``lists/1/speciality/210406/2`` = _prefix "lists/1/speciality/210406/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210600/1"></see>
    /// </summary>
    let ``lists/1/speciality/210600/1`` = _prefix "lists/1/speciality/210600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/152200/1"></see>
    /// </summary>
    let ``lists/2/speciality/152200/1`` = _prefix "lists/2/speciality/152200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/28.03.02/1`` = _prefix "lists/3/speciality/28.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210600/3"></see>
    /// </summary>
    let ``lists/1/speciality/210600/3`` = _prefix "lists/1/speciality/210600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/222900/3"></see>
    /// </summary>
    let ``lists/2/speciality/222900/3`` = _prefix "lists/2/speciality/222900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/28.04.01/3`` = _prefix "lists/3/speciality/28.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/28.04.02/3`` = _prefix "lists/3/speciality/28.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/152200/3"></see>
    /// </summary>
    let ``lists/2/speciality/152200/3`` = _prefix "lists/2/speciality/152200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210601/2"></see>
    /// </summary>
    let ``lists/1/speciality/210601/2`` = _prefix "lists/1/speciality/210601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/210602/2"></see>
    /// </summary>
    let ``lists/1/speciality/210602/2`` = _prefix "lists/1/speciality/210602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220100/1"></see>
    /// </summary>
    let ``lists/1/speciality/220100/1`` = _prefix "lists/1/speciality/220100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/220100/1"></see>
    /// </summary>
    let ``lists/2/speciality/220100/1`` = _prefix "lists/2/speciality/220100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/27.03.03/1`` = _prefix "lists/3/speciality/27.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/220000"></see>
    /// </summary>
    let ``lists/1/ugsn/220000`` = _prefix "lists/1/ugsn/220000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220100/3"></see>
    /// </summary>
    let ``lists/1/speciality/220100/3`` = _prefix "lists/1/speciality/220100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/220100/3"></see>
    /// </summary>
    let ``lists/2/speciality/220100/3`` = _prefix "lists/2/speciality/220100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.03/3`` = _prefix "lists/3/speciality/27.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220101/2"></see>
    /// </summary>
    let ``lists/1/speciality/220101/2`` = _prefix "lists/1/speciality/220101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220200/1"></see>
    /// </summary>
    let ``lists/1/speciality/220200/1`` = _prefix "lists/1/speciality/220200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/221000/1"></see>
    /// </summary>
    let ``lists/2/speciality/221000/1`` = _prefix "lists/2/speciality/221000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/220400/1"></see>
    /// </summary>
    let ``lists/2/speciality/220400/1`` = _prefix "lists/2/speciality/220400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.06/1`` = _prefix "lists/3/speciality/15.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/27.03.04/1`` = _prefix "lists/3/speciality/27.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220200/3"></see>
    /// </summary>
    let ``lists/1/speciality/220200/3`` = _prefix "lists/1/speciality/220200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/221000/3"></see>
    /// </summary>
    let ``lists/2/speciality/221000/3`` = _prefix "lists/2/speciality/221000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/220400/3"></see>
    /// </summary>
    let ``lists/2/speciality/220400/3`` = _prefix "lists/2/speciality/220400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.04/3`` = _prefix "lists/3/speciality/27.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/220700/3"></see>
    /// </summary>
    let ``lists/2/speciality/220700/3`` = _prefix "lists/2/speciality/220700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/15.04.04/3`` = _prefix "lists/3/speciality/15.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/15.04.06/3`` = _prefix "lists/3/speciality/15.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220201/2"></see>
    /// </summary>
    let ``lists/1/speciality/220201/2`` = _prefix "lists/1/speciality/220201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220202/2"></see>
    /// </summary>
    let ``lists/1/speciality/220202/2`` = _prefix "lists/1/speciality/220202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220203/2"></see>
    /// </summary>
    let ``lists/1/speciality/220203/2`` = _prefix "lists/1/speciality/220203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220301/2"></see>
    /// </summary>
    let ``lists/1/speciality/220301/2`` = _prefix "lists/1/speciality/220301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/220700/1"></see>
    /// </summary>
    let ``lists/2/speciality/220700/1`` = _prefix "lists/2/speciality/220700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/15.03.04/1`` = _prefix "lists/3/speciality/15.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220305/2"></see>
    /// </summary>
    let ``lists/1/speciality/220305/2`` = _prefix "lists/1/speciality/220305/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220306/2"></see>
    /// </summary>
    let ``lists/1/speciality/220306/2`` = _prefix "lists/1/speciality/220306/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220401/2"></see>
    /// </summary>
    let ``lists/1/speciality/220401/2`` = _prefix "lists/1/speciality/220401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220402/2"></see>
    /// </summary>
    let ``lists/1/speciality/220402/2`` = _prefix "lists/1/speciality/220402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220501/2"></see>
    /// </summary>
    let ``lists/1/speciality/220501/2`` = _prefix "lists/1/speciality/220501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/221400/1"></see>
    /// </summary>
    let ``lists/2/speciality/221400/1`` = _prefix "lists/2/speciality/221400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/27.03.02/1`` = _prefix "lists/3/speciality/27.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220600/1"></see>
    /// </summary>
    let ``lists/1/speciality/220600/1`` = _prefix "lists/1/speciality/220600/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/222000/1"></see>
    /// </summary>
    let ``lists/2/speciality/222000/1`` = _prefix "lists/2/speciality/222000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/27.03.05/1`` = _prefix "lists/3/speciality/27.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220600/3"></see>
    /// </summary>
    let ``lists/1/speciality/220600/3`` = _prefix "lists/1/speciality/220600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.05/3`` = _prefix "lists/3/speciality/27.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/222000/3"></see>
    /// </summary>
    let ``lists/2/speciality/222000/3`` = _prefix "lists/2/speciality/222000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220601/2"></see>
    /// </summary>
    let ``lists/1/speciality/220601/2`` = _prefix "lists/1/speciality/220601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/220701/2"></see>
    /// </summary>
    let ``lists/1/speciality/220701/2`` = _prefix "lists/1/speciality/220701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/222600/3"></see>
    /// </summary>
    let ``lists/2/speciality/222600/3`` = _prefix "lists/2/speciality/222600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.06/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.06/3`` = _prefix "lists/3/speciality/27.04.06/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230100/1"></see>
    /// </summary>
    let ``lists/1/speciality/230100/1`` = _prefix "lists/1/speciality/230100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/09.03.01/1`` = _prefix "lists/3/speciality/09.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/09.03.04/1`` = _prefix "lists/3/speciality/09.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/231000/1"></see>
    /// </summary>
    let ``lists/2/speciality/231000/1`` = _prefix "lists/2/speciality/231000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/230100/1"></see>
    /// </summary>
    let ``lists/2/speciality/230100/1`` = _prefix "lists/2/speciality/230100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/230000"></see>
    /// </summary>
    let ``lists/1/ugsn/230000`` = _prefix "lists/1/ugsn/230000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230100/3"></see>
    /// </summary>
    let ``lists/1/speciality/230100/3`` = _prefix "lists/1/speciality/230100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/09.04.04/3`` = _prefix "lists/3/speciality/09.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/231000/3"></see>
    /// </summary>
    let ``lists/2/speciality/231000/3`` = _prefix "lists/2/speciality/231000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/230100/3"></see>
    /// </summary>
    let ``lists/2/speciality/230100/3`` = _prefix "lists/2/speciality/230100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/09.04.01/3`` = _prefix "lists/3/speciality/09.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230101/2"></see>
    /// </summary>
    let ``lists/1/speciality/230101/2`` = _prefix "lists/1/speciality/230101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230102/2"></see>
    /// </summary>
    let ``lists/1/speciality/230102/2`` = _prefix "lists/1/speciality/230102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230104/2"></see>
    /// </summary>
    let ``lists/1/speciality/230104/2`` = _prefix "lists/1/speciality/230104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230105/2"></see>
    /// </summary>
    let ``lists/1/speciality/230105/2`` = _prefix "lists/1/speciality/230105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230200/1"></see>
    /// </summary>
    let ``lists/1/speciality/230200/1`` = _prefix "lists/1/speciality/230200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/230400/1"></see>
    /// </summary>
    let ``lists/2/speciality/230400/1`` = _prefix "lists/2/speciality/230400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/09.03.02/1`` = _prefix "lists/3/speciality/09.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230200/3"></see>
    /// </summary>
    let ``lists/1/speciality/230200/3`` = _prefix "lists/1/speciality/230200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/230400/3"></see>
    /// </summary>
    let ``lists/2/speciality/230400/3`` = _prefix "lists/2/speciality/230400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/09.04.02/3`` = _prefix "lists/3/speciality/09.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230201/2"></see>
    /// </summary>
    let ``lists/1/speciality/230201/2`` = _prefix "lists/1/speciality/230201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230202/2"></see>
    /// </summary>
    let ``lists/1/speciality/230202/2`` = _prefix "lists/1/speciality/230202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230203/2"></see>
    /// </summary>
    let ``lists/1/speciality/230203/2`` = _prefix "lists/1/speciality/230203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230204/2"></see>
    /// </summary>
    let ``lists/1/speciality/230204/2`` = _prefix "lists/1/speciality/230204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230301/2"></see>
    /// </summary>
    let ``lists/1/speciality/230301/2`` = _prefix "lists/1/speciality/230301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/230401/2"></see>
    /// </summary>
    let ``lists/1/speciality/230401/2`` = _prefix "lists/1/speciality/230401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/231300/1"></see>
    /// </summary>
    let ``lists/2/speciality/231300/1`` = _prefix "lists/2/speciality/231300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/01.03.04/1`` = _prefix "lists/3/speciality/01.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240100/1"></see>
    /// </summary>
    let ``lists/1/speciality/240100/1`` = _prefix "lists/1/speciality/240100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/240100/1"></see>
    /// </summary>
    let ``lists/2/speciality/240100/1`` = _prefix "lists/2/speciality/240100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/18.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/18.03.01/1`` = _prefix "lists/3/speciality/18.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/240000"></see>
    /// </summary>
    let ``lists/1/ugsn/240000`` = _prefix "lists/1/ugsn/240000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240100/3"></see>
    /// </summary>
    let ``lists/1/speciality/240100/3`` = _prefix "lists/1/speciality/240100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/240700/3"></see>
    /// </summary>
    let ``lists/2/speciality/240700/3`` = _prefix "lists/2/speciality/240700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/18.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/18.04.01/3`` = _prefix "lists/3/speciality/18.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/241000/3"></see>
    /// </summary>
    let ``lists/2/speciality/241000/3`` = _prefix "lists/2/speciality/241000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/240100/3"></see>
    /// </summary>
    let ``lists/2/speciality/240100/3`` = _prefix "lists/2/speciality/240100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/19.04.01/3`` = _prefix "lists/3/speciality/19.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/18.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/18.04.02/3`` = _prefix "lists/3/speciality/18.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240201/2"></see>
    /// </summary>
    let ``lists/1/speciality/240201/2`` = _prefix "lists/1/speciality/240201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240202/2"></see>
    /// </summary>
    let ``lists/1/speciality/240202/2`` = _prefix "lists/1/speciality/240202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240301/2"></see>
    /// </summary>
    let ``lists/1/speciality/240301/2`` = _prefix "lists/1/speciality/240301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240302/2"></see>
    /// </summary>
    let ``lists/1/speciality/240302/2`` = _prefix "lists/1/speciality/240302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240304/2"></see>
    /// </summary>
    let ``lists/1/speciality/240304/2`` = _prefix "lists/1/speciality/240304/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240306/2"></see>
    /// </summary>
    let ``lists/1/speciality/240306/2`` = _prefix "lists/1/speciality/240306/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240307/2"></see>
    /// </summary>
    let ``lists/1/speciality/240307/2`` = _prefix "lists/1/speciality/240307/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240401/2"></see>
    /// </summary>
    let ``lists/1/speciality/240401/2`` = _prefix "lists/1/speciality/240401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240402/2"></see>
    /// </summary>
    let ``lists/1/speciality/240402/2`` = _prefix "lists/1/speciality/240402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240403/2"></see>
    /// </summary>
    let ``lists/1/speciality/240403/2`` = _prefix "lists/1/speciality/240403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240406/2"></see>
    /// </summary>
    let ``lists/1/speciality/240406/2`` = _prefix "lists/1/speciality/240406/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240501/2"></see>
    /// </summary>
    let ``lists/1/speciality/240501/2`` = _prefix "lists/1/speciality/240501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240502/2"></see>
    /// </summary>
    let ``lists/1/speciality/240502/2`` = _prefix "lists/1/speciality/240502/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240504/2"></see>
    /// </summary>
    let ``lists/1/speciality/240504/2`` = _prefix "lists/1/speciality/240504/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240603/2"></see>
    /// </summary>
    let ``lists/1/speciality/240603/2`` = _prefix "lists/1/speciality/240603/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240801/2"></see>
    /// </summary>
    let ``lists/1/speciality/240801/2`` = _prefix "lists/1/speciality/240801/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/241000/1"></see>
    /// </summary>
    let ``lists/2/speciality/241000/1`` = _prefix "lists/2/speciality/241000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/18.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/18.03.02/1`` = _prefix "lists/3/speciality/18.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240802/2"></see>
    /// </summary>
    let ``lists/1/speciality/240802/2`` = _prefix "lists/1/speciality/240802/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240803/2"></see>
    /// </summary>
    let ``lists/1/speciality/240803/2`` = _prefix "lists/1/speciality/240803/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240901/2"></see>
    /// </summary>
    let ``lists/1/speciality/240901/2`` = _prefix "lists/1/speciality/240901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/240700/1"></see>
    /// </summary>
    let ``lists/2/speciality/240700/1`` = _prefix "lists/2/speciality/240700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/19.03.01/1`` = _prefix "lists/3/speciality/19.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/240902/2"></see>
    /// </summary>
    let ``lists/1/speciality/240902/2`` = _prefix "lists/1/speciality/240902/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250100/1"></see>
    /// </summary>
    let ``lists/1/speciality/250100/1`` = _prefix "lists/1/speciality/250100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/250100/1"></see>
    /// </summary>
    let ``lists/2/speciality/250100/1`` = _prefix "lists/2/speciality/250100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.01/1`` = _prefix "lists/3/speciality/35.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/250000"></see>
    /// </summary>
    let ``lists/1/ugsn/250000`` = _prefix "lists/1/ugsn/250000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250100/3"></see>
    /// </summary>
    let ``lists/1/speciality/250100/3`` = _prefix "lists/1/speciality/250100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/250700/3"></see>
    /// </summary>
    let ``lists/2/speciality/250700/3`` = _prefix "lists/2/speciality/250700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/250100/3"></see>
    /// </summary>
    let ``lists/2/speciality/250100/3`` = _prefix "lists/2/speciality/250100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.01/3`` = _prefix "lists/3/speciality/35.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.09/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.09/3`` = _prefix "lists/3/speciality/35.04.09/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250201/2"></see>
    /// </summary>
    let ``lists/1/speciality/250201/2`` = _prefix "lists/1/speciality/250201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250203/2"></see>
    /// </summary>
    let ``lists/1/speciality/250203/2`` = _prefix "lists/1/speciality/250203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/250700/1"></see>
    /// </summary>
    let ``lists/2/speciality/250700/1`` = _prefix "lists/2/speciality/250700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.10/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.10/1`` = _prefix "lists/3/speciality/35.03.10/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250300/1"></see>
    /// </summary>
    let ``lists/1/speciality/250300/1`` = _prefix "lists/1/speciality/250300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/250400/1"></see>
    /// </summary>
    let ``lists/2/speciality/250400/1`` = _prefix "lists/2/speciality/250400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/35.03.02/1`` = _prefix "lists/3/speciality/35.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250300/3"></see>
    /// </summary>
    let ``lists/1/speciality/250300/3`` = _prefix "lists/1/speciality/250300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/250400/3"></see>
    /// </summary>
    let ``lists/2/speciality/250400/3`` = _prefix "lists/2/speciality/250400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/35.04.02/3`` = _prefix "lists/3/speciality/35.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250401/2"></see>
    /// </summary>
    let ``lists/1/speciality/250401/2`` = _prefix "lists/1/speciality/250401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/250403/2"></see>
    /// </summary>
    let ``lists/1/speciality/250403/2`` = _prefix "lists/1/speciality/250403/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260100/1"></see>
    /// </summary>
    let ``lists/1/speciality/260100/1`` = _prefix "lists/1/speciality/260100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/19.03.03/1`` = _prefix "lists/3/speciality/19.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260100/1"></see>
    /// </summary>
    let ``lists/2/speciality/260100/1`` = _prefix "lists/2/speciality/260100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260200/1"></see>
    /// </summary>
    let ``lists/2/speciality/260200/1`` = _prefix "lists/2/speciality/260200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/19.03.02/1`` = _prefix "lists/3/speciality/19.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/260000"></see>
    /// </summary>
    let ``lists/1/ugsn/260000`` = _prefix "lists/1/ugsn/260000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260100/3"></see>
    /// </summary>
    let ``lists/1/speciality/260100/3`` = _prefix "lists/1/speciality/260100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260800/3"></see>
    /// </summary>
    let ``lists/2/speciality/260800/3`` = _prefix "lists/2/speciality/260800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/19.04.02/3`` = _prefix "lists/3/speciality/19.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260100/3"></see>
    /// </summary>
    let ``lists/2/speciality/260100/3`` = _prefix "lists/2/speciality/260100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/19.04.03/3`` = _prefix "lists/3/speciality/19.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/19.04.04/3`` = _prefix "lists/3/speciality/19.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260200/3"></see>
    /// </summary>
    let ``lists/2/speciality/260200/3`` = _prefix "lists/2/speciality/260200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260201/2"></see>
    /// </summary>
    let ``lists/1/speciality/260201/2`` = _prefix "lists/1/speciality/260201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260202/2"></see>
    /// </summary>
    let ``lists/1/speciality/260202/2`` = _prefix "lists/1/speciality/260202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260203/2"></see>
    /// </summary>
    let ``lists/1/speciality/260203/2`` = _prefix "lists/1/speciality/260203/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260204/2"></see>
    /// </summary>
    let ``lists/1/speciality/260204/2`` = _prefix "lists/1/speciality/260204/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260301/2"></see>
    /// </summary>
    let ``lists/1/speciality/260301/2`` = _prefix "lists/1/speciality/260301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260302/2"></see>
    /// </summary>
    let ``lists/1/speciality/260302/2`` = _prefix "lists/1/speciality/260302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260303/2"></see>
    /// </summary>
    let ``lists/1/speciality/260303/2`` = _prefix "lists/1/speciality/260303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260401/2"></see>
    /// </summary>
    let ``lists/1/speciality/260401/2`` = _prefix "lists/1/speciality/260401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260501/2"></see>
    /// </summary>
    let ``lists/1/speciality/260501/2`` = _prefix "lists/1/speciality/260501/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260800/1"></see>
    /// </summary>
    let ``lists/2/speciality/260800/1`` = _prefix "lists/2/speciality/260800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260503/2"></see>
    /// </summary>
    let ``lists/1/speciality/260503/2`` = _prefix "lists/1/speciality/260503/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260504/2"></see>
    /// </summary>
    let ``lists/1/speciality/260504/2`` = _prefix "lists/1/speciality/260504/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260505/2"></see>
    /// </summary>
    let ``lists/1/speciality/260505/2`` = _prefix "lists/1/speciality/260505/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260601/2"></see>
    /// </summary>
    let ``lists/1/speciality/260601/2`` = _prefix "lists/1/speciality/260601/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260602/2"></see>
    /// </summary>
    let ``lists/1/speciality/260602/2`` = _prefix "lists/1/speciality/260602/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260700/1"></see>
    /// </summary>
    let ``lists/1/speciality/260700/1`` = _prefix "lists/1/speciality/260700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/261100/1"></see>
    /// </summary>
    let ``lists/2/speciality/261100/1`` = _prefix "lists/2/speciality/261100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/29.03.02/1`` = _prefix "lists/3/speciality/29.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260700/3"></see>
    /// </summary>
    let ``lists/1/speciality/260700/3`` = _prefix "lists/1/speciality/260700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/261100/3"></see>
    /// </summary>
    let ``lists/2/speciality/261100/3`` = _prefix "lists/2/speciality/261100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/29.04.02/3`` = _prefix "lists/3/speciality/29.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260701/2"></see>
    /// </summary>
    let ``lists/1/speciality/260701/2`` = _prefix "lists/1/speciality/260701/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260703/2"></see>
    /// </summary>
    let ``lists/1/speciality/260703/2`` = _prefix "lists/1/speciality/260703/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260704/2"></see>
    /// </summary>
    let ``lists/1/speciality/260704/2`` = _prefix "lists/1/speciality/260704/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260800/1"></see>
    /// </summary>
    let ``lists/1/speciality/260800/1`` = _prefix "lists/1/speciality/260800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/262000/1"></see>
    /// </summary>
    let ``lists/2/speciality/262000/1`` = _prefix "lists/2/speciality/262000/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/29.03.01/1`` = _prefix "lists/3/speciality/29.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.03.20/1"></see>
    /// </summary>
    let ``lists/3/speciality/29.03.20/1`` = _prefix "lists/3/speciality/29.03.20/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260800/3"></see>
    /// </summary>
    let ``lists/1/speciality/260800/3`` = _prefix "lists/1/speciality/260800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/29.04.05/3`` = _prefix "lists/3/speciality/29.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/262200/3"></see>
    /// </summary>
    let ``lists/2/speciality/262200/3`` = _prefix "lists/2/speciality/262200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/262000/3"></see>
    /// </summary>
    let ``lists/2/speciality/262000/3`` = _prefix "lists/2/speciality/262000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/29.04.01/3`` = _prefix "lists/3/speciality/29.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260901/2"></see>
    /// </summary>
    let ``lists/1/speciality/260901/2`` = _prefix "lists/1/speciality/260901/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260902/2"></see>
    /// </summary>
    let ``lists/1/speciality/260902/2`` = _prefix "lists/1/speciality/260902/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.03.05/1"></see>
    /// </summary>
    let ``lists/3/speciality/29.03.05/1`` = _prefix "lists/3/speciality/29.03.05/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260904/2"></see>
    /// </summary>
    let ``lists/1/speciality/260904/2`` = _prefix "lists/1/speciality/260904/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260905/2"></see>
    /// </summary>
    let ``lists/1/speciality/260905/2`` = _prefix "lists/1/speciality/260905/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/260906/2"></see>
    /// </summary>
    let ``lists/1/speciality/260906/2`` = _prefix "lists/1/speciality/260906/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/262200/1"></see>
    /// </summary>
    let ``lists/2/speciality/262200/1`` = _prefix "lists/2/speciality/262200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/261001/2"></see>
    /// </summary>
    let ``lists/1/speciality/261001/2`` = _prefix "lists/1/speciality/261001/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/261400/1"></see>
    /// </summary>
    let ``lists/2/speciality/261400/1`` = _prefix "lists/2/speciality/261400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/29.03.04/1`` = _prefix "lists/3/speciality/29.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/261002/2"></see>
    /// </summary>
    let ``lists/1/speciality/261002/2`` = _prefix "lists/1/speciality/261002/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/261100/1"></see>
    /// </summary>
    let ``lists/1/speciality/261100/1`` = _prefix "lists/1/speciality/261100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/261700/1"></see>
    /// </summary>
    let ``lists/2/speciality/261700/1`` = _prefix "lists/2/speciality/261700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/29.03.03/1`` = _prefix "lists/3/speciality/29.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/261100/3"></see>
    /// </summary>
    let ``lists/1/speciality/261100/3`` = _prefix "lists/1/speciality/261100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/261700/3"></see>
    /// </summary>
    let ``lists/2/speciality/261700/3`` = _prefix "lists/2/speciality/261700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/29.04.03/3`` = _prefix "lists/3/speciality/29.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/261201/2"></see>
    /// </summary>
    let ``lists/1/speciality/261201/2`` = _prefix "lists/1/speciality/261201/2"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/%D0%A2%D0%B5%D1%85%D0%BD%D0%BE%D0%BB%D0%BE%D0%B3/1"></see>
    /// </summary>
    let ``lists/3/speciality/%D0%A2%D0%B5%D1%85%D0%BD%D0%BE%D0%BB%D0%BE%D0%B3/1`` =
        _prefix "lists/3/speciality/%D0%A2%D0%B5%D1%85%D0%BD%D0%BE%D0%BB%D0%BE%D0%B3/1"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/261202/2"></see>
    /// </summary>
    let ``lists/1/speciality/261202/2`` = _prefix "lists/1/speciality/261202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270100/1"></see>
    /// </summary>
    let ``lists/1/speciality/270100/1`` = _prefix "lists/1/speciality/270100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270800/1"></see>
    /// </summary>
    let ``lists/2/speciality/270800/1`` = _prefix "lists/2/speciality/270800/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/08.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/08.03.01/1`` = _prefix "lists/3/speciality/08.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/270000"></see>
    /// </summary>
    let ``lists/1/ugsn/270000`` = _prefix "lists/1/ugsn/270000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270100/3"></see>
    /// </summary>
    let ``lists/1/speciality/270100/3`` = _prefix "lists/1/speciality/270100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270800/3"></see>
    /// </summary>
    let ``lists/2/speciality/270800/3`` = _prefix "lists/2/speciality/270800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/08.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/08.04.01/3`` = _prefix "lists/3/speciality/08.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270101/2"></see>
    /// </summary>
    let ``lists/1/speciality/270101/2`` = _prefix "lists/1/speciality/270101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270102/2"></see>
    /// </summary>
    let ``lists/1/speciality/270102/2`` = _prefix "lists/1/speciality/270102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270104/2"></see>
    /// </summary>
    let ``lists/1/speciality/270104/2`` = _prefix "lists/1/speciality/270104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270105/2"></see>
    /// </summary>
    let ``lists/1/speciality/270105/2`` = _prefix "lists/1/speciality/270105/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270106/2"></see>
    /// </summary>
    let ``lists/1/speciality/270106/2`` = _prefix "lists/1/speciality/270106/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270109/2"></see>
    /// </summary>
    let ``lists/1/speciality/270109/2`` = _prefix "lists/1/speciality/270109/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270112/2"></see>
    /// </summary>
    let ``lists/1/speciality/270112/2`` = _prefix "lists/1/speciality/270112/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270113/2"></see>
    /// </summary>
    let ``lists/1/speciality/270113/2`` = _prefix "lists/1/speciality/270113/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270114/2"></see>
    /// </summary>
    let ``lists/1/speciality/270114/2`` = _prefix "lists/1/speciality/270114/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270115/2"></see>
    /// </summary>
    let ``lists/1/speciality/270115/2`` = _prefix "lists/1/speciality/270115/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270201/2"></see>
    /// </summary>
    let ``lists/1/speciality/270201/2`` = _prefix "lists/1/speciality/270201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270205/2"></see>
    /// </summary>
    let ``lists/1/speciality/270205/2`` = _prefix "lists/1/speciality/270205/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270300/1"></see>
    /// </summary>
    let ``lists/1/speciality/270300/1`` = _prefix "lists/1/speciality/270300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270300/3"></see>
    /// </summary>
    let ``lists/1/speciality/270300/3`` = _prefix "lists/1/speciality/270300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270100/3"></see>
    /// </summary>
    let ``lists/2/speciality/270100/3`` = _prefix "lists/2/speciality/270100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/07.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/07.04.01/3`` = _prefix "lists/3/speciality/07.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270301/2"></see>
    /// </summary>
    let ``lists/1/speciality/270301/2`` = _prefix "lists/1/speciality/270301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270302/2"></see>
    /// </summary>
    let ``lists/1/speciality/270302/2`` = _prefix "lists/1/speciality/270302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270300/1"></see>
    /// </summary>
    let ``lists/2/speciality/270300/1`` = _prefix "lists/2/speciality/270300/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/07.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/07.03.03/1`` = _prefix "lists/3/speciality/07.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270303/2"></see>
    /// </summary>
    let ``lists/1/speciality/270303/2`` = _prefix "lists/1/speciality/270303/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270200/1"></see>
    /// </summary>
    let ``lists/2/speciality/270200/1`` = _prefix "lists/2/speciality/270200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/07.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/07.03.02/1`` = _prefix "lists/3/speciality/07.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/270400/1"></see>
    /// </summary>
    let ``lists/1/speciality/270400/1`` = _prefix "lists/1/speciality/270400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/270900/1"></see>
    /// </summary>
    let ``lists/2/speciality/270900/1`` = _prefix "lists/2/speciality/270900/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/07.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/07.03.04/1`` = _prefix "lists/3/speciality/07.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280101/2"></see>
    /// </summary>
    let ``lists/1/speciality/280101/2`` = _prefix "lists/1/speciality/280101/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/280700/1"></see>
    /// </summary>
    let ``lists/2/speciality/280700/1`` = _prefix "lists/2/speciality/280700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/20.03.01/1"></see>
    /// </summary>
    let ``lists/3/speciality/20.03.01/1`` = _prefix "lists/3/speciality/20.03.01/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/ugsn/280000"></see>
    /// </summary>
    let ``lists/1/ugsn/280000`` = _prefix "lists/1/ugsn/280000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280102/2"></see>
    /// </summary>
    let ``lists/1/speciality/280102/2`` = _prefix "lists/1/speciality/280102/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280103/2"></see>
    /// </summary>
    let ``lists/1/speciality/280103/2`` = _prefix "lists/1/speciality/280103/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280104/2"></see>
    /// </summary>
    let ``lists/1/speciality/280104/2`` = _prefix "lists/1/speciality/280104/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280200/1"></see>
    /// </summary>
    let ``lists/1/speciality/280200/1`` = _prefix "lists/1/speciality/280200/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280201/2"></see>
    /// </summary>
    let ``lists/1/speciality/280201/2`` = _prefix "lists/1/speciality/280201/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280202/2"></see>
    /// </summary>
    let ``lists/1/speciality/280202/2`` = _prefix "lists/1/speciality/280202/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280301/2"></see>
    /// </summary>
    let ``lists/1/speciality/280301/2`` = _prefix "lists/1/speciality/280301/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/280100/1"></see>
    /// </summary>
    let ``lists/2/speciality/280100/1`` = _prefix "lists/2/speciality/280100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/20.03.02/1"></see>
    /// </summary>
    let ``lists/3/speciality/20.03.02/1`` = _prefix "lists/3/speciality/20.03.02/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280302/2"></see>
    /// </summary>
    let ``lists/1/speciality/280302/2`` = _prefix "lists/1/speciality/280302/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280400/1"></see>
    /// </summary>
    let ``lists/1/speciality/280400/1`` = _prefix "lists/1/speciality/280400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280401/2"></see>
    /// </summary>
    let ``lists/1/speciality/280401/2`` = _prefix "lists/1/speciality/280401/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/1/speciality/280402/2"></see>
    /// </summary>
    let ``lists/1/speciality/280402/2`` = _prefix "lists/1/speciality/280402/2"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/010000"></see>
    /// </summary>
    let ``lists/2/ugsn/010000`` = _prefix "lists/2/ugsn/010000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/010500/3"></see>
    /// </summary>
    let ``lists/2/speciality/010500/3`` = _prefix "lists/2/speciality/010500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/02.04.03/3`` = _prefix "lists/3/speciality/02.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/020000"></see>
    /// </summary>
    let ``lists/2/ugsn/020000`` = _prefix "lists/2/ugsn/020000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/030000"></see>
    /// </summary>
    let ``lists/2/ugsn/030000`` = _prefix "lists/2/ugsn/030000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.03.06/1"></see>
    /// </summary>
    let ``lists/3/speciality/41.03.06/1`` = _prefix "lists/3/speciality/41.03.06/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/031600/3"></see>
    /// </summary>
    let ``lists/2/speciality/031600/3`` = _prefix "lists/2/speciality/031600/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/42.04.01/3`` = _prefix "lists/3/speciality/42.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032400/1"></see>
    /// </summary>
    let ``lists/2/speciality/032400/1`` = _prefix "lists/2/speciality/032400/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/46.03.03/1`` = _prefix "lists/3/speciality/46.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/032400/3"></see>
    /// </summary>
    let ``lists/2/speciality/032400/3`` = _prefix "lists/2/speciality/032400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/46.04.03/3`` = _prefix "lists/3/speciality/46.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035100/1"></see>
    /// </summary>
    let ``lists/2/speciality/035100/1`` = _prefix "lists/2/speciality/035100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.03.04/1"></see>
    /// </summary>
    let ``lists/3/speciality/42.03.04/1`` = _prefix "lists/3/speciality/42.03.04/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/035100/3"></see>
    /// </summary>
    let ``lists/2/speciality/035100/3`` = _prefix "lists/2/speciality/035100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/42.04.04/3`` = _prefix "lists/3/speciality/42.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/036000/3"></see>
    /// </summary>
    let ``lists/2/speciality/036000/3`` = _prefix "lists/2/speciality/036000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/45.04.04/3`` = _prefix "lists/3/speciality/45.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/040000"></see>
    /// </summary>
    let ``lists/2/ugsn/040000`` = _prefix "lists/2/ugsn/040000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/040700/3"></see>
    /// </summary>
    let ``lists/2/speciality/040700/3`` = _prefix "lists/2/speciality/040700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/39.04.03/3`` = _prefix "lists/3/speciality/39.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/050000"></see>
    /// </summary>
    let ``lists/2/ugsn/050000`` = _prefix "lists/2/ugsn/050000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/060400/3"></see>
    /// </summary>
    let ``lists/2/speciality/060400/3`` = _prefix "lists/2/speciality/060400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/32.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/32.04.01/3`` = _prefix "lists/3/speciality/32.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/060000"></see>
    /// </summary>
    let ``lists/2/ugsn/060000`` = _prefix "lists/2/ugsn/060000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/070100/3"></see>
    /// </summary>
    let ``lists/2/speciality/070100/3`` = _prefix "lists/2/speciality/070100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/53.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/53.04.05/3`` = _prefix "lists/3/speciality/53.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/070000"></see>
    /// </summary>
    let ``lists/2/ugsn/070000`` = _prefix "lists/2/ugsn/070000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/070800/3"></see>
    /// </summary>
    let ``lists/2/speciality/070800/3`` = _prefix "lists/2/speciality/070800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/52.04.02/3`` = _prefix "lists/3/speciality/52.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071400/3"></see>
    /// </summary>
    let ``lists/2/speciality/071400/3`` = _prefix "lists/2/speciality/071400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/51.04.05/3`` = _prefix "lists/3/speciality/51.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/071700/1"></see>
    /// </summary>
    let ``lists/2/speciality/071700/1`` = _prefix "lists/2/speciality/071700/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/52.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/52.03.03/1`` = _prefix "lists/3/speciality/52.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072300/3"></see>
    /// </summary>
    let ``lists/2/speciality/072300/3`` = _prefix "lists/2/speciality/072300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/072700/3"></see>
    /// </summary>
    let ``lists/2/speciality/072700/3`` = _prefix "lists/2/speciality/072700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/54.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/54.04.03/3`` = _prefix "lists/3/speciality/54.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/080000"></see>
    /// </summary>
    let ``lists/2/ugsn/080000`` = _prefix "lists/2/ugsn/080000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/081200/3"></see>
    /// </summary>
    let ``lists/2/speciality/081200/3`` = _prefix "lists/2/speciality/081200/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.09/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.09/3`` = _prefix "lists/3/speciality/38.04.09/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/090000"></see>
    /// </summary>
    let ``lists/2/ugsn/090000`` = _prefix "lists/2/ugsn/090000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/090900/3"></see>
    /// </summary>
    let ``lists/2/speciality/090900/3`` = _prefix "lists/2/speciality/090900/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/10.04.01/3"></see>
    /// </summary>
    let ``lists/3/speciality/10.04.01/3`` = _prefix "lists/3/speciality/10.04.01/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/100000"></see>
    /// </summary>
    let ``lists/2/ugsn/100000`` = _prefix "lists/2/ugsn/100000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/100800/3"></see>
    /// </summary>
    let ``lists/2/speciality/100800/3`` = _prefix "lists/2/speciality/100800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.04.07/3"></see>
    /// </summary>
    let ``lists/3/speciality/38.04.07/3`` = _prefix "lists/3/speciality/38.04.07/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/111000"></see>
    /// </summary>
    let ``lists/2/ugsn/111000`` = _prefix "lists/2/ugsn/111000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/110000"></see>
    /// </summary>
    let ``lists/2/ugsn/110000`` = _prefix "lists/2/ugsn/110000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/120000"></see>
    /// </summary>
    let ``lists/2/ugsn/120000`` = _prefix "lists/2/ugsn/120000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/130000"></see>
    /// </summary>
    let ``lists/2/ugsn/130000`` = _prefix "lists/2/ugsn/130000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/140000"></see>
    /// </summary>
    let ``lists/2/ugsn/140000`` = _prefix "lists/2/ugsn/140000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/140800/3"></see>
    /// </summary>
    let ``lists/2/speciality/140800/3`` = _prefix "lists/2/speciality/140800/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/14.04.02/3"></see>
    /// </summary>
    let ``lists/3/speciality/14.04.02/3`` = _prefix "lists/3/speciality/14.04.02/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/150000"></see>
    /// </summary>
    let ``lists/2/ugsn/150000`` = _prefix "lists/2/ugsn/150000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/152100/1"></see>
    /// </summary>
    let ``lists/2/speciality/152100/1`` = _prefix "lists/2/speciality/152100/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.03.03/1"></see>
    /// </summary>
    let ``lists/3/speciality/28.03.03/1`` = _prefix "lists/3/speciality/28.03.03/1"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/152100/3"></see>
    /// </summary>
    let ``lists/2/speciality/152100/3`` = _prefix "lists/2/speciality/152100/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/28.04.03/3`` = _prefix "lists/3/speciality/28.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/160000"></see>
    /// </summary>
    let ``lists/2/ugsn/160000`` = _prefix "lists/2/ugsn/160000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/161000/3"></see>
    /// </summary>
    let ``lists/2/speciality/161000/3`` = _prefix "lists/2/speciality/161000/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.04.03/3"></see>
    /// </summary>
    let ``lists/3/speciality/25.04.03/3`` = _prefix "lists/3/speciality/25.04.03/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/162700/3"></see>
    /// </summary>
    let ``lists/2/speciality/162700/3`` = _prefix "lists/2/speciality/162700/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/25.04.04/3`` = _prefix "lists/3/speciality/25.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/180000"></see>
    /// </summary>
    let ``lists/2/ugsn/180000`` = _prefix "lists/2/ugsn/180000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/190000"></see>
    /// </summary>
    let ``lists/2/ugsn/190000`` = _prefix "lists/2/ugsn/190000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/200000"></see>
    /// </summary>
    let ``lists/2/ugsn/200000`` = _prefix "lists/2/ugsn/200000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/210000"></see>
    /// </summary>
    let ``lists/2/ugsn/210000`` = _prefix "lists/2/ugsn/210000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/220000"></see>
    /// </summary>
    let ``lists/2/ugsn/220000`` = _prefix "lists/2/ugsn/220000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/222300/3"></see>
    /// </summary>
    let ``lists/2/speciality/222300/3`` = _prefix "lists/2/speciality/222300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.04.07/3"></see>
    /// </summary>
    let ``lists/3/speciality/27.04.07/3`` = _prefix "lists/3/speciality/27.04.07/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/230000"></see>
    /// </summary>
    let ``lists/2/ugsn/230000`` = _prefix "lists/2/ugsn/230000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/231300/3"></see>
    /// </summary>
    let ``lists/2/speciality/231300/3`` = _prefix "lists/2/speciality/231300/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/01.04.04/3`` = _prefix "lists/3/speciality/01.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/240000"></see>
    /// </summary>
    let ``lists/2/ugsn/240000`` = _prefix "lists/2/ugsn/240000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/250000"></see>
    /// </summary>
    let ``lists/2/ugsn/250000`` = _prefix "lists/2/ugsn/250000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/260000"></see>
    /// </summary>
    let ``lists/2/ugsn/260000`` = _prefix "lists/2/ugsn/260000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/260500/3"></see>
    /// </summary>
    let ``lists/2/speciality/260500/3`` = _prefix "lists/2/speciality/260500/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.04.05/3"></see>
    /// </summary>
    let ``lists/3/speciality/19.04.05/3`` = _prefix "lists/3/speciality/19.04.05/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/speciality/261400/3"></see>
    /// </summary>
    let ``lists/2/speciality/261400/3`` = _prefix "lists/2/speciality/261400/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.04.04/3"></see>
    /// </summary>
    let ``lists/3/speciality/29.04.04/3`` = _prefix "lists/3/speciality/29.04.04/3"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/270000"></see>
    /// </summary>
    let ``lists/2/ugsn/270000`` = _prefix "lists/2/ugsn/270000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/280000"></see>
    /// </summary>
    let ``lists/2/ugsn/280000`` = _prefix "lists/2/ugsn/280000"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/2/ugsn/30000+"></see>
    /// </summary>
    let ``lists/2/ugsn/30000+`` = _prefix "lists/2/ugsn/30000+"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3"></see>
    /// </summary>
    let ``lists/3`` = _prefix "lists/3"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.01/4`` =
        _prefix "lists/3/scientificspeciality/01.01.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.02/4`` =
        _prefix "lists/3/scientificspeciality/01.01.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.03/4`` =
        _prefix "lists/3/scientificspeciality/01.01.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.04/4`` =
        _prefix "lists/3/scientificspeciality/01.01.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.05/4`` =
        _prefix "lists/3/scientificspeciality/01.01.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.06/4`` =
        _prefix "lists/3/scientificspeciality/01.01.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.07/4`` =
        _prefix "lists/3/scientificspeciality/01.01.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.01.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.01.09/4`` =
        _prefix "lists/3/scientificspeciality/01.01.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.02.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.02.01/4`` =
        _prefix "lists/3/scientificspeciality/01.02.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.02.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.02.04/4`` =
        _prefix "lists/3/scientificspeciality/01.02.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.02.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.02.05/4`` =
        _prefix "lists/3/scientificspeciality/01.02.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.02.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.02.06/4`` =
        _prefix "lists/3/scientificspeciality/01.02.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.02.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.02.08/4`` =
        _prefix "lists/3/scientificspeciality/01.02.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.03..01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.03..01/4`` =
        _prefix "lists/3/scientificspeciality/01.03..01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.03.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.03.02/4`` =
        _prefix "lists/3/scientificspeciality/01.03.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.03.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.03.03/4`` =
        _prefix "lists/3/scientificspeciality/01.03.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.03.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.03.04/4`` =
        _prefix "lists/3/scientificspeciality/01.03.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.01/4`` =
        _prefix "lists/3/scientificspeciality/01.04.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.02/4`` =
        _prefix "lists/3/scientificspeciality/01.04.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.03/4`` =
        _prefix "lists/3/scientificspeciality/01.04.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.04/4`` =
        _prefix "lists/3/scientificspeciality/01.04.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.05/4`` =
        _prefix "lists/3/scientificspeciality/01.04.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.06/4`` =
        _prefix "lists/3/scientificspeciality/01.04.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.07/4`` =
        _prefix "lists/3/scientificspeciality/01.04.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.08/4`` =
        _prefix "lists/3/scientificspeciality/01.04.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.09/4`` =
        _prefix "lists/3/scientificspeciality/01.04.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.10/4`` =
        _prefix "lists/3/scientificspeciality/01.04.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.11/4`` =
        _prefix "lists/3/scientificspeciality/01.04.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.13/4`` =
        _prefix "lists/3/scientificspeciality/01.04.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.14/4`` =
        _prefix "lists/3/scientificspeciality/01.04.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.15/4`` =
        _prefix "lists/3/scientificspeciality/01.04.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.16/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.16/4`` =
        _prefix "lists/3/scientificspeciality/01.04.16/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.17/4`` =
        _prefix "lists/3/scientificspeciality/01.04.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.18/4`` =
        _prefix "lists/3/scientificspeciality/01.04.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.20/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.20/4`` =
        _prefix "lists/3/scientificspeciality/01.04.20/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.21/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.21/4`` =
        _prefix "lists/3/scientificspeciality/01.04.21/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/01.04.23/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/01.04.23/4`` =
        _prefix "lists/3/scientificspeciality/01.04.23/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.01/4`` =
        _prefix "lists/3/scientificspeciality/02.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.02/4`` =
        _prefix "lists/3/scientificspeciality/02.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.03/4`` =
        _prefix "lists/3/scientificspeciality/02.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.04/4`` =
        _prefix "lists/3/scientificspeciality/02.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.05/4`` =
        _prefix "lists/3/scientificspeciality/02.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.06/4`` =
        _prefix "lists/3/scientificspeciality/02.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.08/4`` =
        _prefix "lists/3/scientificspeciality/02.00.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.09/4`` =
        _prefix "lists/3/scientificspeciality/02.00.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.10/4`` =
        _prefix "lists/3/scientificspeciality/02.00.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.11/4`` =
        _prefix "lists/3/scientificspeciality/02.00.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.12/4`` =
        _prefix "lists/3/scientificspeciality/02.00.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.13/4`` =
        _prefix "lists/3/scientificspeciality/02.00.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.14/4`` =
        _prefix "lists/3/scientificspeciality/02.00.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.15/4`` =
        _prefix "lists/3/scientificspeciality/02.00.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.16/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.16/4`` =
        _prefix "lists/3/scientificspeciality/02.00.16/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.17/4`` =
        _prefix "lists/3/scientificspeciality/02.00.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/02.00.21/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/02.00.21/4`` =
        _prefix "lists/3/scientificspeciality/02.00.21/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.01/4`` =
        _prefix "lists/3/scientificspeciality/03.01.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.02/4`` =
        _prefix "lists/3/scientificspeciality/03.01.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.03/4`` =
        _prefix "lists/3/scientificspeciality/03.01.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.04/4`` =
        _prefix "lists/3/scientificspeciality/03.01.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.05/4`` =
        _prefix "lists/3/scientificspeciality/03.01.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.06/4`` =
        _prefix "lists/3/scientificspeciality/03.01.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.07/4`` =
        _prefix "lists/3/scientificspeciality/03.01.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.08/4`` =
        _prefix "lists/3/scientificspeciality/03.01.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.01.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.01.09/4`` =
        _prefix "lists/3/scientificspeciality/03.01.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.01/4`` =
        _prefix "lists/3/scientificspeciality/03.02.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.02/4`` =
        _prefix "lists/3/scientificspeciality/03.02.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.03/4`` =
        _prefix "lists/3/scientificspeciality/03.02.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.04/4`` =
        _prefix "lists/3/scientificspeciality/03.02.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.05/4`` =
        _prefix "lists/3/scientificspeciality/03.02.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.06/4`` =
        _prefix "lists/3/scientificspeciality/03.02.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.07/4`` =
        _prefix "lists/3/scientificspeciality/03.02.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.08/4`` =
        _prefix "lists/3/scientificspeciality/03.02.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.09/4`` =
        _prefix "lists/3/scientificspeciality/03.02.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.10/4`` =
        _prefix "lists/3/scientificspeciality/03.02.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.11/4`` =
        _prefix "lists/3/scientificspeciality/03.02.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.12/4`` =
        _prefix "lists/3/scientificspeciality/03.02.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.13/4`` =
        _prefix "lists/3/scientificspeciality/03.02.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.02.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.02.14/4`` =
        _prefix "lists/3/scientificspeciality/03.02.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.03.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.03.01/4`` =
        _prefix "lists/3/scientificspeciality/03.03.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.03.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.03.02/4`` =
        _prefix "lists/3/scientificspeciality/03.03.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.03.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.03.03/4`` =
        _prefix "lists/3/scientificspeciality/03.03.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.03.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.03.04/4`` =
        _prefix "lists/3/scientificspeciality/03.03.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.03.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.03.05/4`` =
        _prefix "lists/3/scientificspeciality/03.03.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/03.03.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/03.03.06/4`` =
        _prefix "lists/3/scientificspeciality/03.03.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.01.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.01.01/4`` =
        _prefix "lists/3/scientificspeciality/05.01.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.02/4`` =
        _prefix "lists/3/scientificspeciality/05.02.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.04/4`` =
        _prefix "lists/3/scientificspeciality/05.02.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.05/4`` =
        _prefix "lists/3/scientificspeciality/05.02.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.07/4`` =
        _prefix "lists/3/scientificspeciality/05.02.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.08/4`` =
        _prefix "lists/3/scientificspeciality/05.02.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.09/4`` =
        _prefix "lists/3/scientificspeciality/05.02.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.10/4`` =
        _prefix "lists/3/scientificspeciality/05.02.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.11/4`` =
        _prefix "lists/3/scientificspeciality/05.02.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.13/4`` =
        _prefix "lists/3/scientificspeciality/05.02.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.18/4`` =
        _prefix "lists/3/scientificspeciality/05.02.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.22/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.22/4`` =
        _prefix "lists/3/scientificspeciality/05.02.22/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.02.23/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.02.23/4`` =
        _prefix "lists/3/scientificspeciality/05.02.23/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.04.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.04.02/4`` =
        _prefix "lists/3/scientificspeciality/05.04.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.04.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.04.03/4`` =
        _prefix "lists/3/scientificspeciality/05.04.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.04.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.04.06/4`` =
        _prefix "lists/3/scientificspeciality/05.04.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.04.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.04.11/4`` =
        _prefix "lists/3/scientificspeciality/05.04.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.04.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.04.12/4`` =
        _prefix "lists/3/scientificspeciality/05.04.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.04.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.04.13/4`` =
        _prefix "lists/3/scientificspeciality/05.04.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.05.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.05.03/4`` =
        _prefix "lists/3/scientificspeciality/05.05.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.05.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.05.04/4`` =
        _prefix "lists/3/scientificspeciality/05.05.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.05.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.05.06/4`` =
        _prefix "lists/3/scientificspeciality/05.05.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.06.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.06.07/4`` =
        _prefix "lists/3/scientificspeciality/05.06.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.01/4`` =
        _prefix "lists/3/scientificspeciality/05.07.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.02/4`` =
        _prefix "lists/3/scientificspeciality/05.07.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.03/4`` =
        _prefix "lists/3/scientificspeciality/05.07.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.05/4`` =
        _prefix "lists/3/scientificspeciality/05.07.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.06/4`` =
        _prefix "lists/3/scientificspeciality/05.07.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.07/4`` =
        _prefix "lists/3/scientificspeciality/05.07.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.09/4`` =
        _prefix "lists/3/scientificspeciality/05.07.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.07.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.07.10/4`` =
        _prefix "lists/3/scientificspeciality/05.07.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.08.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.08.01/4`` =
        _prefix "lists/3/scientificspeciality/05.08.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.08.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.08.03/4`` =
        _prefix "lists/3/scientificspeciality/05.08.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.08.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.08.04/4`` =
        _prefix "lists/3/scientificspeciality/05.08.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.08.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.08.05/4`` =
        _prefix "lists/3/scientificspeciality/05.08.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.08.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.08.06/4`` =
        _prefix "lists/3/scientificspeciality/05.08.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.01/4`` =
        _prefix "lists/3/scientificspeciality/05.09.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.02/4`` =
        _prefix "lists/3/scientificspeciality/05.09.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.03/4`` =
        _prefix "lists/3/scientificspeciality/05.09.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.05/4`` =
        _prefix "lists/3/scientificspeciality/05.09.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.07/4`` =
        _prefix "lists/3/scientificspeciality/05.09.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.10/4`` =
        _prefix "lists/3/scientificspeciality/05.09.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.09.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.09.12/4`` =
        _prefix "lists/3/scientificspeciality/05.09.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.01/4`` =
        _prefix "lists/3/scientificspeciality/05.11.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.03/4`` =
        _prefix "lists/3/scientificspeciality/05.11.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.06/4`` =
        _prefix "lists/3/scientificspeciality/05.11.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.07/4`` =
        _prefix "lists/3/scientificspeciality/05.11.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.08/4`` =
        _prefix "lists/3/scientificspeciality/05.11.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.10/4`` =
        _prefix "lists/3/scientificspeciality/05.11.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.13/4`` =
        _prefix "lists/3/scientificspeciality/05.11.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.14/4`` =
        _prefix "lists/3/scientificspeciality/05.11.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.15/4`` =
        _prefix "lists/3/scientificspeciality/05.11.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.16/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.16/4`` =
        _prefix "lists/3/scientificspeciality/05.11.16/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.17/4`` =
        _prefix "lists/3/scientificspeciality/05.11.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.11.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.11.18/4`` =
        _prefix "lists/3/scientificspeciality/05.11.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.12.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.12.04/4`` =
        _prefix "lists/3/scientificspeciality/05.12.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.12.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.12.07/4`` =
        _prefix "lists/3/scientificspeciality/05.12.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.12.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.12.13/4`` =
        _prefix "lists/3/scientificspeciality/05.12.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.12.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.12.14/4`` =
        _prefix "lists/3/scientificspeciality/05.12.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.01/4`` =
        _prefix "lists/3/scientificspeciality/05.13.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.05/4`` =
        _prefix "lists/3/scientificspeciality/05.13.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.06/4`` =
        _prefix "lists/3/scientificspeciality/05.13.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.10/4`` =
        _prefix "lists/3/scientificspeciality/05.13.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.11/4`` =
        _prefix "lists/3/scientificspeciality/05.13.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.12/4`` =
        _prefix "lists/3/scientificspeciality/05.13.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.15/4`` =
        _prefix "lists/3/scientificspeciality/05.13.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.17/4`` =
        _prefix "lists/3/scientificspeciality/05.13.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.18/4`` =
        _prefix "lists/3/scientificspeciality/05.13.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.19/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.19/4`` =
        _prefix "lists/3/scientificspeciality/05.13.19/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.13.20/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.13.20/4`` =
        _prefix "lists/3/scientificspeciality/05.13.20/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.01/4`` =
        _prefix "lists/3/scientificspeciality/05.14.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.02/4`` =
        _prefix "lists/3/scientificspeciality/05.14.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.03/4`` =
        _prefix "lists/3/scientificspeciality/05.14.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.04/4`` =
        _prefix "lists/3/scientificspeciality/05.14.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.08/4`` =
        _prefix "lists/3/scientificspeciality/05.14.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.12/4`` =
        _prefix "lists/3/scientificspeciality/05.14.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.14.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.14.14/4`` =
        _prefix "lists/3/scientificspeciality/05.14.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.01/4`` =
        _prefix "lists/3/scientificspeciality/05.16.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.02/4`` =
        _prefix "lists/3/scientificspeciality/05.16.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.04/4`` =
        _prefix "lists/3/scientificspeciality/05.16.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.05/4`` =
        _prefix "lists/3/scientificspeciality/05.16.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.06/4`` =
        _prefix "lists/3/scientificspeciality/05.16.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.07/4`` =
        _prefix "lists/3/scientificspeciality/05.16.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.08/4`` =
        _prefix "lists/3/scientificspeciality/05.16.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.16.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.16.09/4`` =
        _prefix "lists/3/scientificspeciality/05.16.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.01/4`` =
        _prefix "lists/3/scientificspeciality/05.17.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.02/4`` =
        _prefix "lists/3/scientificspeciality/05.17.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.03/4`` =
        _prefix "lists/3/scientificspeciality/05.17.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.04/4`` =
        _prefix "lists/3/scientificspeciality/05.17.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.06/4`` =
        _prefix "lists/3/scientificspeciality/05.17.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.07/4`` =
        _prefix "lists/3/scientificspeciality/05.17.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.08/4`` =
        _prefix "lists/3/scientificspeciality/05.17.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.11/4`` =
        _prefix "lists/3/scientificspeciality/05.17.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.17.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.17.18/4`` =
        _prefix "lists/3/scientificspeciality/05.17.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.01/4`` =
        _prefix "lists/3/scientificspeciality/05.18.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.04/4`` =
        _prefix "lists/3/scientificspeciality/05.18.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.05/4`` =
        _prefix "lists/3/scientificspeciality/05.18.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.06/4`` =
        _prefix "lists/3/scientificspeciality/05.18.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.07/4`` =
        _prefix "lists/3/scientificspeciality/05.18.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.12/4`` =
        _prefix "lists/3/scientificspeciality/05.18.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.15/4`` =
        _prefix "lists/3/scientificspeciality/05.18.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.18.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.18.17/4`` =
        _prefix "lists/3/scientificspeciality/05.18.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.19.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.19.01/4`` =
        _prefix "lists/3/scientificspeciality/05.19.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.19.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.19.02/4`` =
        _prefix "lists/3/scientificspeciality/05.19.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.19.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.19.04/4`` =
        _prefix "lists/3/scientificspeciality/05.19.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.19.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.19.05/4`` =
        _prefix "lists/3/scientificspeciality/05.19.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.20.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.20.01/4`` =
        _prefix "lists/3/scientificspeciality/05.20.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.20.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.20.02/4`` =
        _prefix "lists/3/scientificspeciality/05.20.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.20.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.20.03/4`` =
        _prefix "lists/3/scientificspeciality/05.20.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.21.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.21.01/4`` =
        _prefix "lists/3/scientificspeciality/05.21.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.21.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.21.03/4`` =
        _prefix "lists/3/scientificspeciality/05.21.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.21.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.21.05/4`` =
        _prefix "lists/3/scientificspeciality/05.21.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.01/4`` =
        _prefix "lists/3/scientificspeciality/05.22.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.06/4`` =
        _prefix "lists/3/scientificspeciality/05.22.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.07/4`` =
        _prefix "lists/3/scientificspeciality/05.22.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.08/4`` =
        _prefix "lists/3/scientificspeciality/05.22.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.10/4`` =
        _prefix "lists/3/scientificspeciality/05.22.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.13/4`` =
        _prefix "lists/3/scientificspeciality/05.22.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.14/4`` =
        _prefix "lists/3/scientificspeciality/05.22.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.17/4`` =
        _prefix "lists/3/scientificspeciality/05.22.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.22.19/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.22.19/4`` =
        _prefix "lists/3/scientificspeciality/05.22.19/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.01/4`` =
        _prefix "lists/3/scientificspeciality/05.23.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.02/4`` =
        _prefix "lists/3/scientificspeciality/05.23.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.03/4`` =
        _prefix "lists/3/scientificspeciality/05.23.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.04/4`` =
        _prefix "lists/3/scientificspeciality/05.23.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.05/4`` =
        _prefix "lists/3/scientificspeciality/05.23.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.07/4`` =
        _prefix "lists/3/scientificspeciality/05.23.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.08/4`` =
        _prefix "lists/3/scientificspeciality/05.23.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.11/4`` =
        _prefix "lists/3/scientificspeciality/05.23.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.16/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.16/4`` =
        _prefix "lists/3/scientificspeciality/05.23.16/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.17/4`` =
        _prefix "lists/3/scientificspeciality/05.23.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.19/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.19/4`` =
        _prefix "lists/3/scientificspeciality/05.23.19/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.20/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.20/4`` =
        _prefix "lists/3/scientificspeciality/05.23.20/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.21/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.21/4`` =
        _prefix "lists/3/scientificspeciality/05.23.21/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.23.22/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.23.22/4`` =
        _prefix "lists/3/scientificspeciality/05.23.22/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.25.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.25.02/4`` =
        _prefix "lists/3/scientificspeciality/05.25.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.25.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.25.03/4`` =
        _prefix "lists/3/scientificspeciality/05.25.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.25.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.25.05/4`` =
        _prefix "lists/3/scientificspeciality/05.25.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.26.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.26.01/4`` =
        _prefix "lists/3/scientificspeciality/05.26.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.26.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.26.02/4`` =
        _prefix "lists/3/scientificspeciality/05.26.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.26.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.26.03/4`` =
        _prefix "lists/3/scientificspeciality/05.26.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.26.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.26.05/4`` =
        _prefix "lists/3/scientificspeciality/05.26.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.26.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.26.06/4`` =
        _prefix "lists/3/scientificspeciality/05.26.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.26.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.26.12/4`` =
        _prefix "lists/3/scientificspeciality/05.26.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.27.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.27.02/4`` =
        _prefix "lists/3/scientificspeciality/05.27.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.27.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.27.03/4`` =
        _prefix "lists/3/scientificspeciality/05.27.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/05.27.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/05.27.06/4`` =
        _prefix "lists/3/scientificspeciality/05.27.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.01/4`` =
        _prefix "lists/3/scientificspeciality/06.01.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.02/4`` =
        _prefix "lists/3/scientificspeciality/06.01.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.03/4`` =
        _prefix "lists/3/scientificspeciality/06.01.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.04/4`` =
        _prefix "lists/3/scientificspeciality/06.01.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.05/4`` =
        _prefix "lists/3/scientificspeciality/06.01.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.06/4`` =
        _prefix "lists/3/scientificspeciality/06.01.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.07/4`` =
        _prefix "lists/3/scientificspeciality/06.01.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.08/4`` =
        _prefix "lists/3/scientificspeciality/06.01.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.01.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.01.09/4`` =
        _prefix "lists/3/scientificspeciality/06.01.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.01/4`` =
        _prefix "lists/3/scientificspeciality/06.02.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.02/4`` =
        _prefix "lists/3/scientificspeciality/06.02.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.03/4`` =
        _prefix "lists/3/scientificspeciality/06.02.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.04/4`` =
        _prefix "lists/3/scientificspeciality/06.02.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.05/4`` =
        _prefix "lists/3/scientificspeciality/06.02.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.06/4`` =
        _prefix "lists/3/scientificspeciality/06.02.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.07/4`` =
        _prefix "lists/3/scientificspeciality/06.02.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.08/4`` =
        _prefix "lists/3/scientificspeciality/06.02.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.09/4`` =
        _prefix "lists/3/scientificspeciality/06.02.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.02.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.02.10/4`` =
        _prefix "lists/3/scientificspeciality/06.02.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.03.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.03.01/4`` =
        _prefix "lists/3/scientificspeciality/06.03.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.03.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.03.02/4`` =
        _prefix "lists/3/scientificspeciality/06.03.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.03.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.03.03/4`` =
        _prefix "lists/3/scientificspeciality/06.03.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/06.04.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/06.04.01/4`` =
        _prefix "lists/3/scientificspeciality/06.04.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.02/4`` =
        _prefix "lists/3/scientificspeciality/07.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.03/4`` =
        _prefix "lists/3/scientificspeciality/07.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.06/4`` =
        _prefix "lists/3/scientificspeciality/07.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.07/4`` =
        _prefix "lists/3/scientificspeciality/07.00.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.09/4`` =
        _prefix "lists/3/scientificspeciality/07.00.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.10/4`` =
        _prefix "lists/3/scientificspeciality/07.00.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/07.00.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/07.00.15/4`` =
        _prefix "lists/3/scientificspeciality/07.00.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/08.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/08.00.01/4`` =
        _prefix "lists/3/scientificspeciality/08.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/08.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/08.00.05/4`` =
        _prefix "lists/3/scientificspeciality/08.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/08.00.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/08.00.10/4`` =
        _prefix "lists/3/scientificspeciality/08.00.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/08.00.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/08.00.12/4`` =
        _prefix "lists/3/scientificspeciality/08.00.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/08.00.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/08.00.13/4`` =
        _prefix "lists/3/scientificspeciality/08.00.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/08.00.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/08.00.14/4`` =
        _prefix "lists/3/scientificspeciality/08.00.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.01/4`` =
        _prefix "lists/3/scientificspeciality/09.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.03/4`` =
        _prefix "lists/3/scientificspeciality/09.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.04/4`` =
        _prefix "lists/3/scientificspeciality/09.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.05/4`` =
        _prefix "lists/3/scientificspeciality/09.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.07/4`` =
        _prefix "lists/3/scientificspeciality/09.00.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.08/4`` =
        _prefix "lists/3/scientificspeciality/09.00.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.11/4`` =
        _prefix "lists/3/scientificspeciality/09.00.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.13/4`` =
        _prefix "lists/3/scientificspeciality/09.00.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/09.00.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/09.00.14/4`` =
        _prefix "lists/3/scientificspeciality/09.00.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.01.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.01.01/4`` =
        _prefix "lists/3/scientificspeciality/10.01.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.01.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.01.02/4`` =
        _prefix "lists/3/scientificspeciality/10.01.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.01.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.01.03/4`` =
        _prefix "lists/3/scientificspeciality/10.01.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.01.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.01.08/4`` =
        _prefix "lists/3/scientificspeciality/10.01.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.01.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.01.09/4`` =
        _prefix "lists/3/scientificspeciality/10.01.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.01.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.01.10/4`` =
        _prefix "lists/3/scientificspeciality/10.01.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.01/4`` =
        _prefix "lists/3/scientificspeciality/10.02.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.02/4`` =
        _prefix "lists/3/scientificspeciality/10.02.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.03/4`` =
        _prefix "lists/3/scientificspeciality/10.02.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.04/4`` =
        _prefix "lists/3/scientificspeciality/10.02.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.05/4`` =
        _prefix "lists/3/scientificspeciality/10.02.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.14/4`` =
        _prefix "lists/3/scientificspeciality/10.02.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.19/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.19/4`` =
        _prefix "lists/3/scientificspeciality/10.02.19/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.20/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.20/4`` =
        _prefix "lists/3/scientificspeciality/10.02.20/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.21/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.21/4`` =
        _prefix "lists/3/scientificspeciality/10.02.21/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/10.02.22/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/10.02.22/4`` =
        _prefix "lists/3/scientificspeciality/10.02.22/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.01/4`` =
        _prefix "lists/3/scientificspeciality/12.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.02/4`` =
        _prefix "lists/3/scientificspeciality/12.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.03/4`` =
        _prefix "lists/3/scientificspeciality/12.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.04/4`` =
        _prefix "lists/3/scientificspeciality/12.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.05/4`` =
        _prefix "lists/3/scientificspeciality/12.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.06/4`` =
        _prefix "lists/3/scientificspeciality/12.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.07/4`` =
        _prefix "lists/3/scientificspeciality/12.00.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.08/4`` =
        _prefix "lists/3/scientificspeciality/12.00.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.09/4`` =
        _prefix "lists/3/scientificspeciality/12.00.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.10/4`` =
        _prefix "lists/3/scientificspeciality/12.00.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.11/4`` =
        _prefix "lists/3/scientificspeciality/12.00.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.12/4`` =
        _prefix "lists/3/scientificspeciality/12.00.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.13/4`` =
        _prefix "lists/3/scientificspeciality/12.00.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.14/4`` =
        _prefix "lists/3/scientificspeciality/12.00.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/12.00.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/12.00.15/4`` =
        _prefix "lists/3/scientificspeciality/12.00.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/13.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/13.00.01/4`` =
        _prefix "lists/3/scientificspeciality/13.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/13.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/13.00.02/4`` =
        _prefix "lists/3/scientificspeciality/13.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/13.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/13.00.03/4`` =
        _prefix "lists/3/scientificspeciality/13.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/13.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/13.00.04/4`` =
        _prefix "lists/3/scientificspeciality/13.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/13.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/13.00.05/4`` =
        _prefix "lists/3/scientificspeciality/13.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/13.00.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/13.00.08/4`` =
        _prefix "lists/3/scientificspeciality/13.00.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.01/4`` =
        _prefix "lists/3/scientificspeciality/14.01.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.02/4`` =
        _prefix "lists/3/scientificspeciality/14.01.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.03/4`` =
        _prefix "lists/3/scientificspeciality/14.01.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.04/4`` =
        _prefix "lists/3/scientificspeciality/14.01.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.05/4`` =
        _prefix "lists/3/scientificspeciality/14.01.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.06/4`` =
        _prefix "lists/3/scientificspeciality/14.01.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.07/4`` =
        _prefix "lists/3/scientificspeciality/14.01.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.08/4`` =
        _prefix "lists/3/scientificspeciality/14.01.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.09/4`` =
        _prefix "lists/3/scientificspeciality/14.01.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.10/4`` =
        _prefix "lists/3/scientificspeciality/14.01.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.11/4`` =
        _prefix "lists/3/scientificspeciality/14.01.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.12/4`` =
        _prefix "lists/3/scientificspeciality/14.01.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.13/4`` =
        _prefix "lists/3/scientificspeciality/14.01.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.14/4`` =
        _prefix "lists/3/scientificspeciality/14.01.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.15/4`` =
        _prefix "lists/3/scientificspeciality/14.01.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.16/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.16/4`` =
        _prefix "lists/3/scientificspeciality/14.01.16/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.17/4`` =
        _prefix "lists/3/scientificspeciality/14.01.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.18/4`` =
        _prefix "lists/3/scientificspeciality/14.01.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.19/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.19/4`` =
        _prefix "lists/3/scientificspeciality/14.01.19/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.20/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.20/4`` =
        _prefix "lists/3/scientificspeciality/14.01.20/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.21/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.21/4`` =
        _prefix "lists/3/scientificspeciality/14.01.21/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.22/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.22/4`` =
        _prefix "lists/3/scientificspeciality/14.01.22/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.23/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.23/4`` =
        _prefix "lists/3/scientificspeciality/14.01.23/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.24/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.24/4`` =
        _prefix "lists/3/scientificspeciality/14.01.24/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.25/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.25/4`` =
        _prefix "lists/3/scientificspeciality/14.01.25/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.26/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.26/4`` =
        _prefix "lists/3/scientificspeciality/14.01.26/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.27/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.27/4`` =
        _prefix "lists/3/scientificspeciality/14.01.27/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.28/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.28/4`` =
        _prefix "lists/3/scientificspeciality/14.01.28/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.29/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.29/4`` =
        _prefix "lists/3/scientificspeciality/14.01.29/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.01.30/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.01.30/4`` =
        _prefix "lists/3/scientificspeciality/14.01.30/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.02.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.02.01/4`` =
        _prefix "lists/3/scientificspeciality/14.02.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.02.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.02.02/4`` =
        _prefix "lists/3/scientificspeciality/14.02.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.02.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.02.03/4`` =
        _prefix "lists/3/scientificspeciality/14.02.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.02.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.02.04/4`` =
        _prefix "lists/3/scientificspeciality/14.02.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.02.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.02.05/4`` =
        _prefix "lists/3/scientificspeciality/14.02.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.02.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.02.06/4`` =
        _prefix "lists/3/scientificspeciality/14.02.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.01/4`` =
        _prefix "lists/3/scientificspeciality/14.03.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.02/4`` =
        _prefix "lists/3/scientificspeciality/14.03.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.03/4`` =
        _prefix "lists/3/scientificspeciality/14.03.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.04/4`` =
        _prefix "lists/3/scientificspeciality/14.03.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.05/4`` =
        _prefix "lists/3/scientificspeciality/14.03.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.06/4`` =
        _prefix "lists/3/scientificspeciality/14.03.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.07/4`` =
        _prefix "lists/3/scientificspeciality/14.03.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.08/4`` =
        _prefix "lists/3/scientificspeciality/14.03.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.09/4`` =
        _prefix "lists/3/scientificspeciality/14.03.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.10/4`` =
        _prefix "lists/3/scientificspeciality/14.03.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.03.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.03.11/4`` =
        _prefix "lists/3/scientificspeciality/14.03.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.04.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.04.01/4`` =
        _prefix "lists/3/scientificspeciality/14.04.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.04.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.04.02/4`` =
        _prefix "lists/3/scientificspeciality/14.04.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/14.04.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/14.04.03/4`` =
        _prefix "lists/3/scientificspeciality/14.04.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.01/4`` =
        _prefix "lists/3/scientificspeciality/17.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.02/4`` =
        _prefix "lists/3/scientificspeciality/17.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.03/4`` =
        _prefix "lists/3/scientificspeciality/17.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.04/4`` =
        _prefix "lists/3/scientificspeciality/17.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.05/4`` =
        _prefix "lists/3/scientificspeciality/17.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.06/4`` =
        _prefix "lists/3/scientificspeciality/17.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/17.00.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/17.00.09/4`` =
        _prefix "lists/3/scientificspeciality/17.00.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.01/4`` =
        _prefix "lists/3/scientificspeciality/19.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.02/4`` =
        _prefix "lists/3/scientificspeciality/19.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.03/4`` =
        _prefix "lists/3/scientificspeciality/19.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.04/4`` =
        _prefix "lists/3/scientificspeciality/19.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.05/4`` =
        _prefix "lists/3/scientificspeciality/19.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.06/4`` =
        _prefix "lists/3/scientificspeciality/19.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.07/4`` =
        _prefix "lists/3/scientificspeciality/19.00.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.10/4`` =
        _prefix "lists/3/scientificspeciality/19.00.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.12/4`` =
        _prefix "lists/3/scientificspeciality/19.00.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/19.00.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/19.00.13/4`` =
        _prefix "lists/3/scientificspeciality/19.00.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/22.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/22.00.01/4`` =
        _prefix "lists/3/scientificspeciality/22.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/22.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/22.00.03/4`` =
        _prefix "lists/3/scientificspeciality/22.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/22.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/22.00.04/4`` =
        _prefix "lists/3/scientificspeciality/22.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/22.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/22.00.05/4`` =
        _prefix "lists/3/scientificspeciality/22.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/22.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/22.00.06/4`` =
        _prefix "lists/3/scientificspeciality/22.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/22.00.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/22.00.08/4`` =
        _prefix "lists/3/scientificspeciality/22.00.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/23.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/23.00.01/4`` =
        _prefix "lists/3/scientificspeciality/23.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/23.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/23.00.02/4`` =
        _prefix "lists/3/scientificspeciality/23.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/23.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/23.00.03/4`` =
        _prefix "lists/3/scientificspeciality/23.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/23.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/23.00.04/4`` =
        _prefix "lists/3/scientificspeciality/23.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/23.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/23.00.05/4`` =
        _prefix "lists/3/scientificspeciality/23.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/23.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/23.00.06/4`` =
        _prefix "lists/3/scientificspeciality/23.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/24.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/24.00.01/4`` =
        _prefix "lists/3/scientificspeciality/24.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/24.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/24.00.03/4`` =
        _prefix "lists/3/scientificspeciality/24.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.01/4`` =
        _prefix "lists/3/scientificspeciality/25.00.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.02/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.02/4`` =
        _prefix "lists/3/scientificspeciality/25.00.02/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.03/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.03/4`` =
        _prefix "lists/3/scientificspeciality/25.00.03/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.04/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.04/4`` =
        _prefix "lists/3/scientificspeciality/25.00.04/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.05/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.05/4`` =
        _prefix "lists/3/scientificspeciality/25.00.05/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.06/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.06/4`` =
        _prefix "lists/3/scientificspeciality/25.00.06/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.07/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.07/4`` =
        _prefix "lists/3/scientificspeciality/25.00.07/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.08/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.08/4`` =
        _prefix "lists/3/scientificspeciality/25.00.08/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.09/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.09/4`` =
        _prefix "lists/3/scientificspeciality/25.00.09/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.10/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.10/4`` =
        _prefix "lists/3/scientificspeciality/25.00.10/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.11/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.11/4`` =
        _prefix "lists/3/scientificspeciality/25.00.11/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.12/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.12/4`` =
        _prefix "lists/3/scientificspeciality/25.00.12/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.13/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.13/4`` =
        _prefix "lists/3/scientificspeciality/25.00.13/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.14/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.14/4`` =
        _prefix "lists/3/scientificspeciality/25.00.14/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.15/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.15/4`` =
        _prefix "lists/3/scientificspeciality/25.00.15/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.16/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.16/4`` =
        _prefix "lists/3/scientificspeciality/25.00.16/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.17/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.17/4`` =
        _prefix "lists/3/scientificspeciality/25.00.17/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.18/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.18/4`` =
        _prefix "lists/3/scientificspeciality/25.00.18/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.19/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.19/4`` =
        _prefix "lists/3/scientificspeciality/25.00.19/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.20/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.20/4`` =
        _prefix "lists/3/scientificspeciality/25.00.20/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.21/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.21/4`` =
        _prefix "lists/3/scientificspeciality/25.00.21/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.22/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.22/4`` =
        _prefix "lists/3/scientificspeciality/25.00.22/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.23/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.23/4`` =
        _prefix "lists/3/scientificspeciality/25.00.23/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.24/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.24/4`` =
        _prefix "lists/3/scientificspeciality/25.00.24/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.25/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.25/4`` =
        _prefix "lists/3/scientificspeciality/25.00.25/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.26/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.26/4`` =
        _prefix "lists/3/scientificspeciality/25.00.26/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.27/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.27/4`` =
        _prefix "lists/3/scientificspeciality/25.00.27/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.28/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.28/4`` =
        _prefix "lists/3/scientificspeciality/25.00.28/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.29/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.29/4`` =
        _prefix "lists/3/scientificspeciality/25.00.29/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.30/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.30/4`` =
        _prefix "lists/3/scientificspeciality/25.00.30/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.31/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.31/4`` =
        _prefix "lists/3/scientificspeciality/25.00.31/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.32/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.32/4`` =
        _prefix "lists/3/scientificspeciality/25.00.32/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.33/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.33/4`` =
        _prefix "lists/3/scientificspeciality/25.00.33/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.34/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.34/4`` =
        _prefix "lists/3/scientificspeciality/25.00.34/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.35/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.35/4`` =
        _prefix "lists/3/scientificspeciality/25.00.35/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/25.00.36/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/25.00.36/4`` =
        _prefix "lists/3/scientificspeciality/25.00.36/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/scientificspeciality/27.05.01/4"></see>
    /// </summary>
    let ``lists/3/scientificspeciality/27.05.01/4`` =
        _prefix "lists/3/scientificspeciality/27.05.01/4"

    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/29.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/29.00.00`` = _prefix "lists/3/ugsn/29.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/01.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/01.00.00`` = _prefix "lists/3/ugsn/01.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/36.0.00"></see>
    /// </summary>
    let ``lists/3/ugsn/36.0.00`` = _prefix "lists/3/ugsn/36.0.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/01.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/01.06.01/4`` = _prefix "lists/3/speciality/01.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/02.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/02.00.00`` = _prefix "lists/3/ugsn/02.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/46.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/46.00.00`` = _prefix "lists/3/ugsn/46.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/02.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/02.06.01/4`` = _prefix "lists/3/speciality/02.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/03.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/03.00.00`` = _prefix "lists/3/ugsn/03.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/03.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/03.06.01/4`` = _prefix "lists/3/speciality/03.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/12.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/12.00.00`` = _prefix "lists/3/ugsn/12.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/04.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/04.00.00`` = _prefix "lists/3/ugsn/04.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/04.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/04.06.01/4`` = _prefix "lists/3/speciality/04.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/05.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/05.00.00`` = _prefix "lists/3/ugsn/05.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/44.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/44.00.00`` = _prefix "lists/3/ugsn/44.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/05.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/05.06.01/4`` = _prefix "lists/3/speciality/05.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/06.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/06.00.00`` = _prefix "lists/3/ugsn/06.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/06.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/06.06.01/4`` = _prefix "lists/3/speciality/06.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/07.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/07.00.00`` = _prefix "lists/3/ugsn/07.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/07.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/07.06.01/4`` = _prefix "lists/3/speciality/07.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/08.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/08.00.00`` = _prefix "lists/3/ugsn/08.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/08.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/08.06.01/4`` = _prefix "lists/3/speciality/08.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/09.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/09.00.00`` = _prefix "lists/3/ugsn/09.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/09.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/09.06.01/4`` = _prefix "lists/3/speciality/09.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/10.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/10.00.00`` = _prefix "lists/3/ugsn/10.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/10.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/10.06.01/4`` = _prefix "lists/3/speciality/10.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/11.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/11.00.00`` = _prefix "lists/3/ugsn/11.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/11.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/11.06.01/4`` = _prefix "lists/3/speciality/11.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/72.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/72.00.00`` = _prefix "lists/3/ugsn/72.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/12.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/12.06.01/4`` = _prefix "lists/3/speciality/12.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/13.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/13.00.00`` = _prefix "lists/3/ugsn/13.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/13.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/13.06.01/4`` = _prefix "lists/3/speciality/13.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/14.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/14.00.00`` = _prefix "lists/3/ugsn/14.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/14.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/14.06.01/4`` = _prefix "lists/3/speciality/14.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/15.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/15.00.00`` = _prefix "lists/3/ugsn/15.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/15.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/15.06.01/4`` = _prefix "lists/3/speciality/15.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/16.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/16.00.00`` = _prefix "lists/3/ugsn/16.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/16.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/16.06.01/4`` = _prefix "lists/3/speciality/16.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/17.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/17.00.00`` = _prefix "lists/3/ugsn/17.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/18.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/18.00.00`` = _prefix "lists/3/ugsn/18.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/18.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/18.06.01/4`` = _prefix "lists/3/speciality/18.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/19.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/19.00.00`` = _prefix "lists/3/ugsn/19.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/19.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/19.06.01/4`` = _prefix "lists/3/speciality/19.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/20.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/20.00.00`` = _prefix "lists/3/ugsn/20.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/20.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/20.06.01/4`` = _prefix "lists/3/speciality/20.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/21.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/21.00.00`` = _prefix "lists/3/ugsn/21.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/21.06.01/4`` = _prefix "lists/3/speciality/21.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/21.06.02/4"></see>
    /// </summary>
    let ``lists/3/speciality/21.06.02/4`` = _prefix "lists/3/speciality/21.06.02/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/22.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/22.00.00`` = _prefix "lists/3/ugsn/22.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/22.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/22.06.01/4`` = _prefix "lists/3/speciality/22.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/23.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/23.00.00`` = _prefix "lists/3/ugsn/23.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/23.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/23.06.01/4`` = _prefix "lists/3/speciality/23.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/24.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/24.00.00`` = _prefix "lists/3/ugsn/24.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/24.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/24.06.01/4`` = _prefix "lists/3/speciality/24.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/25.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/25.00.00`` = _prefix "lists/3/ugsn/25.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/25.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/25.06.01/4`` = _prefix "lists/3/speciality/25.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/26.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/26.00.00`` = _prefix "lists/3/ugsn/26.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/26.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/26.06.01/4`` = _prefix "lists/3/speciality/26.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/27.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/27.00.00`` = _prefix "lists/3/ugsn/27.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/27.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/27.06.01/4`` = _prefix "lists/3/speciality/27.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/28.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/28.00.00`` = _prefix "lists/3/ugsn/28.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/28.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/28.06.01/4`` = _prefix "lists/3/speciality/28.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/29.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/29.06.01/4`` = _prefix "lists/3/speciality/29.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/30.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/30.06.01/4`` = _prefix "lists/3/speciality/30.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/30.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/30.00.00`` = _prefix "lists/3/ugsn/30.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/31.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/31.06.01/4`` = _prefix "lists/3/speciality/31.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/31.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/31.00.00`` = _prefix "lists/3/ugsn/31.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/32.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/32.00.00`` = _prefix "lists/3/ugsn/32.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/32.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/32.06.01/4`` = _prefix "lists/3/speciality/32.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/33.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/33.06.01/4`` = _prefix "lists/3/speciality/33.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/33.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/33.00.00`` = _prefix "lists/3/ugsn/33.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/34.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/34.00.00`` = _prefix "lists/3/ugsn/34.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/35.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/35.00.00`` = _prefix "lists/3/ugsn/35.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/35.06.01/4`` = _prefix "lists/3/speciality/35.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.06.02/4"></see>
    /// </summary>
    let ``lists/3/speciality/35.06.02/4`` = _prefix "lists/3/speciality/35.06.02/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.06.03/4"></see>
    /// </summary>
    let ``lists/3/speciality/35.06.03/4`` = _prefix "lists/3/speciality/35.06.03/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/35.06.04/4"></see>
    /// </summary>
    let ``lists/3/speciality/35.06.04/4`` = _prefix "lists/3/speciality/35.06.04/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/36.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/36.00.00`` = _prefix "lists/3/ugsn/36.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/36.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/36.06.01/4`` = _prefix "lists/3/speciality/36.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/37.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/37.00.00`` = _prefix "lists/3/ugsn/37.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/37.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/37.06.01/4`` = _prefix "lists/3/speciality/37.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/38.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/38.00.00`` = _prefix "lists/3/ugsn/38.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/38.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/38.06.01/4`` = _prefix "lists/3/speciality/38.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/39.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/39.00.00`` = _prefix "lists/3/ugsn/39.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/39.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/39.06.01/4`` = _prefix "lists/3/speciality/39.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/40.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/40.00.00`` = _prefix "lists/3/ugsn/40.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/40.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/40.06.01/4`` = _prefix "lists/3/speciality/40.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/41.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/41.00.00`` = _prefix "lists/3/ugsn/41.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/41.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/41.06.01/4`` = _prefix "lists/3/speciality/41.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/42.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/42.00.00`` = _prefix "lists/3/ugsn/42.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/42.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/42.06.01/4`` = _prefix "lists/3/speciality/42.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/43.0.00"></see>
    /// </summary>
    let ``lists/3/ugsn/43.0.00`` = _prefix "lists/3/ugsn/43.0.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/43.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/43.00.00`` = _prefix "lists/3/ugsn/43.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/44.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/44.06.01/4`` = _prefix "lists/3/speciality/44.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/45.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/45.00.00`` = _prefix "lists/3/ugsn/45.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/45.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/45.06.01/4`` = _prefix "lists/3/speciality/45.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/46.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/46.06.01/4`` = _prefix "lists/3/speciality/46.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/47.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/47.00.00`` = _prefix "lists/3/ugsn/47.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/47.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/47.06.01/4`` = _prefix "lists/3/speciality/47.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/48.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/48.00.00`` = _prefix "lists/3/ugsn/48.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/48.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/48.06.01/4`` = _prefix "lists/3/speciality/48.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/49.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/49.00.00`` = _prefix "lists/3/ugsn/49.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/49.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/49.06.01/4`` = _prefix "lists/3/speciality/49.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/50.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/50.00.00`` = _prefix "lists/3/ugsn/50.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/50.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/50.06.01/4`` = _prefix "lists/3/speciality/50.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/51.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/51.00.00`` = _prefix "lists/3/ugsn/51.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/51.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/51.06.01/4`` = _prefix "lists/3/speciality/51.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/52.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/52.00.00`` = _prefix "lists/3/ugsn/52.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/53.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/53.00.00`` = _prefix "lists/3/ugsn/53.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/54.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/54.00.00`` = _prefix "lists/3/ugsn/54.00.00"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/speciality/56.06.01/4"></see>
    /// </summary>
    let ``lists/3/speciality/56.06.01/4`` = _prefix "lists/3/speciality/56.06.01/4"
    /// <summary>
    ///   <see href="http://sparql.sstu.ru:3030/speciality/lists/3/ugsn/56.00.00"></see>
    /// </summary>
    let ``lists/3/ugsn/56.00.00`` = _prefix "lists/3/ugsn/56.00.00"

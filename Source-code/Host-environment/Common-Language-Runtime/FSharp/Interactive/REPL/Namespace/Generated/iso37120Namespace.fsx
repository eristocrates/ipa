#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module iso37120 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.eil.utoronto.ca/ISO37120.owl#" "iso37120"

    /// <summary>
    ///   <para>rdfs:label : Number of firefighters per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#10.1">iso37120:10.1</a>
    /// </summary>
    let ``_10.1`` = _prefixId.prefix "10.1"
    /// <summary>
    ///   <para>rdfs:label : Number of fire related deaths per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#10.2">iso37120:10.2</a>
    /// </summary>
    let ``_10.2`` = _prefixId.prefix "10.2"
    /// <summary>
    ///   <para>rdfs:label : Number of natural disaster related deaths per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#10.3">iso37120:10.3</a>
    /// </summary>
    let ``_10.3`` = _prefixId.prefix "10.3"
    /// <summary>
    ///   <para>rdfs:label : Number of volunteer and part-time firefighters per 100 000 population (support- ing indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#10.4">iso37120:10.4</a>
    /// </summary>
    let ``_10.4`` = _prefixId.prefix "10.4"
    /// <summary>
    ///   <para>rdfs:label : Response time for emergency response services from initial call (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#10.5">iso37120:10.5</a>
    /// </summary>
    let ``_10.5`` = _prefixId.prefix "10.5"
    /// <summary>
    ///   <para>rdfs:label : Response time for fire department from initial call (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#10.6">iso37120:10.6</a>
    /// </summary>
    let ``_10.6`` = _prefixId.prefix "10.6"
    /// <summary>
    ///   <para>rdfs:label : Voter participation in last municipal election (as a percentage of eligible voters) (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#11.1">iso37120:11.1</a>
    /// </summary>
    let ``_11.1`` = _prefixId.prefix "11.1"
    /// <summary>
    ///   <para>rdfs:label : Women as a percentage of total elected to city-level office (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#11.2">iso37120:11.2</a>
    /// </summary>
    let ``_11.2`` = _prefixId.prefix "11.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of women employed in the city government workforce (supporting indi- cator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#11.3">iso37120:11.3</a>
    /// </summary>
    let ``_11.3`` = _prefixId.prefix "11.3"
    /// <summary>
    ///   <para>rdfs:label : Number of convictions for corruption and/or bribery by city officials per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#11.4">iso37120:11.4</a>
    /// </summary>
    let ``_11.4`` = _prefixId.prefix "11.4"
    /// <summary>
    ///   <para>rdfs:label : Citizens’ representation: number of local officials elected to office per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#11.5">iso37120:11.5</a>
    /// </summary>
    let ``_11.5`` = _prefixId.prefix "11.5"
    /// <summary>
    ///   <para>rdfs:label : Number of registered voters as a percentage of the voting age population (support- ing indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#11.6">iso37120:11.6</a>
    /// </summary>
    let ``_11.6`` = _prefixId.prefix "11.6"
    /// <summary>
    ///   <para>rdfs:label : Average life expectancy (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.1">iso37120:12.1</a>
    /// </summary>
    let ``_12.1`` = _prefixId.prefix "12.1"
    /// <summary>
    ///   <para>rdfs:label : Number of in-patient hospital beds per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.2">iso37120:12.2</a>
    /// </summary>
    let ``_12.2`` = _prefixId.prefix "12.2"
    /// <summary>
    ///   <para>rdfs:label : Number of physicians per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.3">iso37120:12.3</a>
    /// </summary>
    let ``_12.3`` = _prefixId.prefix "12.3"
    /// <summary>
    ///   <para>rdfs:label : Under age five mortality per 1 000 live births (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.4">iso37120:12.4</a>
    /// </summary>
    let ``_12.4`` = _prefixId.prefix "12.4"
    /// <summary>
    ///   <para>rdfs:label : Number of nursing and midwifery personnel per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.5">iso37120:12.5</a>
    /// </summary>
    let ``_12.5`` = _prefixId.prefix "12.5"
    /// <summary>
    ///   <para>rdfs:label : Number of mental health practitioners per 100 000 population (supporting indica- tor)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.6">iso37120:12.6</a>
    /// </summary>
    let ``_12.6`` = _prefixId.prefix "12.6"
    /// <summary>
    ///   <para>rdfs:label : Suicide rate per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#12.7">iso37120:12.7</a>
    /// </summary>
    let ``_12.7`` = _prefixId.prefix "12.7"
    /// <summary>
    ///   <para>rdfs:label : Square meters of public indoor recreation space per capita (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#13.1">iso37120:13.1</a>
    /// </summary>
    let ``_13.1`` = _prefixId.prefix "13.1"
    /// <summary>
    ///   <para>rdfs:label : Square meters of public outdoor recreation space per capita (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#13.2">iso37120:13.2</a>
    /// </summary>
    let ``_13.2`` = _prefixId.prefix "13.2"
    /// <summary>
    ///   <para>rdfs:label : Number of police officers per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#14.1">iso37120:14.1</a>
    /// </summary>
    let ``_14.1`` = _prefixId.prefix "14.1"
    /// <summary>
    ///   <para>rdfs:label : Number of homicides per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#14.2">iso37120:14.2</a>
    /// </summary>
    let ``_14.2`` = _prefixId.prefix "14.2"
    /// <summary>
    ///   <para>rdfs:label : Crimes against property per 100 000 (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#14.3">iso37120:14.3</a>
    /// </summary>
    let ``_14.3`` = _prefixId.prefix "14.3"
    /// <summary>
    ///   <para>rdfs:label : Response time for police department from initial call (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#14.4">iso37120:14.4</a>
    /// </summary>
    let ``_14.4`` = _prefixId.prefix "14.4"
    /// <summary>
    ///   <para>rdfs:label : Violent crime rate per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#14.5">iso37120:14.5</a>
    /// </summary>
    let ``_14.5`` = _prefixId.prefix "14.5"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population living in slums (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#15.1">iso37120:15.1</a>
    /// </summary>
    let ``_15.1`` = _prefixId.prefix "15.1"
    /// <summary>
    ///   <para>rdfs:label : Number of homeless per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#15.2">iso37120:15.2</a>
    /// </summary>
    let ``_15.2`` = _prefixId.prefix "15.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of households that exist without registered legal titles (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#15.3">iso37120:15.3</a>
    /// </summary>
    let ``_15.3`` = _prefixId.prefix "15.3"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population with regular solid waste collection (residential) (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.1">iso37120:16.1</a>
    /// </summary>
    let ``_16.1`` = _prefixId.prefix "16.1"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s hazardous waste that is recycled (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.10">iso37120:16.10</a>
    /// </summary>
    let ``_16.10`` = _prefixId.prefix "16.10"
    /// <summary>
    ///   <para>rdfs:label : Total collected municipal solid waste per capita (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.2">iso37120:16.2</a>
    /// </summary>
    let ``_16.2`` = _prefixId.prefix "16.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s solid waste that is recycled (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.3">iso37120:16.3</a>
    /// </summary>
    let ``_16.3`` = _prefixId.prefix "16.3"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s solid waste that is disposed of in a sanitary landfill (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.4">iso37120:16.4</a>
    /// </summary>
    let ``_16.4`` = _prefixId.prefix "16.4"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s solid waste that is disposed of in an incinerator (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.5">iso37120:16.5</a>
    /// </summary>
    let ``_16.5`` = _prefixId.prefix "16.5"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s solid waste that is burned openly (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.6">iso37120:16.6</a>
    /// </summary>
    let ``_16.6`` = _prefixId.prefix "16.6"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s solid waste that is disposed of in an open dump (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.7">iso37120:16.7</a>
    /// </summary>
    let ``_16.7`` = _prefixId.prefix "16.7"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s solid waste that is disposed of by other means (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.8">iso37120:16.8</a>
    /// </summary>
    let ``_16.8`` = _prefixId.prefix "16.8"
    /// <summary>
    ///   <para>rdfs:label : Hazardous Waste Generation per capita (tonnes) (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#16.9">iso37120:16.9</a>
    /// </summary>
    let ``_16.9`` = _prefixId.prefix "16.9"
    /// <summary>
    ///   <para>rdfs:label : Number of internet connections per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#17.1">iso37120:17.1</a>
    /// </summary>
    let ``_17.1`` = _prefixId.prefix "17.1"
    /// <summary>
    ///   <para>rdfs:label : Number of cell phone connections per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#17.2">iso37120:17.2</a>
    /// </summary>
    let ``_17.2`` = _prefixId.prefix "17.2"
    /// <summary>
    ///   <para>rdfs:label : Number of landline phone connections per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#17.3">iso37120:17.3</a>
    /// </summary>
    let ``_17.3`` = _prefixId.prefix "17.3"
    /// <summary>
    ///   <para>rdfs:label : Kilometres of high capacity public transport system per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.1">iso37120:18.1</a>
    /// </summary>
    let ``_18.1`` = _prefixId.prefix "18.1"
    /// <summary>
    ///   <para>rdfs:label : Kilometres of light passenger public transport system per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.2">iso37120:18.2</a>
    /// </summary>
    let ``_18.2`` = _prefixId.prefix "18.2"
    /// <summary>
    ///   <para>rdfs:label : Annual number of public transport trips per capita (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.3">iso37120:18.3</a>
    /// </summary>
    let ``_18.3`` = _prefixId.prefix "18.3"
    /// <summary>
    ///   <para>rdfs:label : Number of personal automobiles per capita (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.4">iso37120:18.4</a>
    /// </summary>
    let ``_18.4`` = _prefixId.prefix "18.4"
    /// <summary>
    ///   <para>rdfs:label : Percentage of commuters using a travel mode to work other than a personal vehicle (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.5">iso37120:18.5</a>
    /// </summary>
    let ``_18.5`` = _prefixId.prefix "18.5"
    /// <summary>
    ///   <para>rdfs:label : Number of two-wheel motorized vehicles per capita (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.6">iso37120:18.6</a>
    /// </summary>
    let ``_18.6`` = _prefixId.prefix "18.6"
    /// <summary>
    ///   <para>rdfs:label : Kilometres of bicycle paths and lanes per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.7">iso37120:18.7</a>
    /// </summary>
    let ``_18.7`` = _prefixId.prefix "18.7"
    /// <summary>
    ///   <para>rdfs:label : Transportation fatalities per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.8">iso37120:18.8</a>
    /// </summary>
    let ``_18.8`` = _prefixId.prefix "18.8"
    /// <summary>
    ///   <para>rdfs:label : Commercial air connectivity (number of non-stop commercial air destinations) (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#18.9">iso37120:18.9</a>
    /// </summary>
    let ``_18.9`` = _prefixId.prefix "18.9"
    /// <summary>
    ///   <para>rdfs:label : Green area (hectares) per 100 000 population (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#19.1">iso37120:19.1</a>
    /// </summary>
    let ``_19.1`` = _prefixId.prefix "19.1"
    /// <summary>
    ///   <para>rdfs:label : Annual number of trees planted per 100 000 population (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#19.2">iso37120:19.2</a>
    /// </summary>
    let ``_19.2`` = _prefixId.prefix "19.2"
    /// <summary>
    ///   <para>rdfs:label : Areal size of informal settlements as a percentage of city area (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#19.3">iso37120:19.3</a>
    /// </summary>
    let ``_19.3`` = _prefixId.prefix "19.3"
    /// <summary>
    ///   <para>rdfs:label : Jobs/housing ratio (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#19.4">iso37120:19.4</a>
    /// </summary>
    let ``_19.4`` = _prefixId.prefix "19.4"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population served by wastewater collection (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#20.1">iso37120:20.1</a>
    /// </summary>
    let ``_20.1`` = _prefixId.prefix "20.1"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s wastewater that has received no treatment (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#20.2">iso37120:20.2</a>
    /// </summary>
    let ``_20.2`` = _prefixId.prefix "20.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s wastewater receiving primary treatment (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#20.3">iso37120:20.3</a>
    /// </summary>
    let ``_20.3`` = _prefixId.prefix "20.3"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s wastewater receiving secondary treatment (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#20.4">iso37120:20.4</a>
    /// </summary>
    let ``_20.4`` = _prefixId.prefix "20.4"
    /// <summary>
    ///   <para>rdfs:label : Percentage of the city’s wastewater receiving tertiary treatment (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#20.5">iso37120:20.5</a>
    /// </summary>
    let ``_20.5`` = _prefixId.prefix "20.5"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population with potable water supply service (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.1">iso37120:21.1</a>
    /// </summary>
    let ``_21.1`` = _prefixId.prefix "21.1"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population with sustainable access to an improved water source (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.2">iso37120:21.2</a>
    /// </summary>
    let ``_21.2`` = _prefixId.prefix "21.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of population with access to improved sanitation (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.3">iso37120:21.3</a>
    /// </summary>
    let ``_21.3`` = _prefixId.prefix "21.3"
    /// <summary>
    ///   <para>rdfs:label : Total domestic water consumption per capita (litres/day) (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.4">iso37120:21.4</a>
    /// </summary>
    let ``_21.4`` = _prefixId.prefix "21.4"
    /// <summary>
    ///   <para>rdfs:label : Total water consumption per capita (litres/day) (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.5">iso37120:21.5</a>
    /// </summary>
    let ``_21.5`` = _prefixId.prefix "21.5"
    /// <summary>
    ///   <para>rdfs:label : Average annual hours of water service interruption per household (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.6">iso37120:21.6</a>
    /// </summary>
    let ``_21.6`` = _prefixId.prefix "21.6"
    /// <summary>
    ///   <para>rdfs:label : Percentage of water loss (unaccounted for water) (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#21.7">iso37120:21.7</a>
    /// </summary>
    let ``_21.7`` = _prefixId.prefix "21.7"
    /// <summary>
    ///   <para>rdfs:label : City’s unemployment rate (core indicator)</para>
    ///   <para>dcterms:description : A city’s unemployment rate shall be calculated as the number of working-age city residents who during the survey reference period were not in paid employment or self-employment, but available for work, and seeking work (numerator) divided by the total labour force (denominator). The result shall be multiplied by 100 and expressed as a percentage.
    ///
    /// Unemployment shall refer to individuals without work, actively seeking work in a recent past period (past four weeks), and currently available for work. Persons who did not look for work but have a future labour market stake (arrangements for a future job start) are counted as unemployed (International Labour Organization). Discouraged workers or hidden unemployed shall refer to persons who are not actively seeking work because they believe the prospects of finding it are extremely poor or they have restricted labour mobility, face discrimination, and/or structural, social, and cultural barriers – are not counted as unemployed or as part of the labour force. Not actively seeking work shall refer to people who have not taken active steps to seek work (i.e. job searches, interviews, informational meetings etc.) during a specified recent period (usually the past four weeks).
    ///
    /// Labour Force shall refer to the sum of the total persons employed and unemployedwhare legally eligible to work.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.1">iso37120:5.1</a>
    /// </summary>
    let ``_5.1`` = _prefixId.prefix "5.1"
    /// <summary>
    ///   <para>rdfs:label : Assessed value of commercial and industrial properties as a percentage of total as- sessed value of all properties (core indicator)</para>
    ///   <para>dcterms:description : The assessed value of commercial and industrial properties as a percentage of total assessed value of all properties shall be expressed as the total assessed value of commercial and industrial properties (numerator) divided by the total assessed value of all properties (denominator). The result shall then be multiplied by 100 and expressed as a percentage.
    ///
    /// Commercial and industrial properties shall refer to those which have been designated by the city for commercial and industrial use.
    ///
    /// NOTE Property assessment methods may vary from one jurisdiction or country to another, including the market-oriented method, the profit-oriented method and the cost-oriented method.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.2">iso37120:5.2</a>
    /// </summary>
    let ``_5.2`` = _prefixId.prefix "5.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population living in poverty  (core indicator)</para>
    ///   <para>dcterms:description : The percentage of city population living in poverty shall be calculated as the number of people living below the poverty threshold (numerator) divided by the total current population of the city (denominator). The result shall then be multiplied by 100 and expressed as a percentage.
    ///
    /// The total number of persons in the city living below the poverty threshold shall first be determined by multiplying the number of city households living at or below the poverty threshold by the current average number of persons per household for that city.
    ///
    /// NOTE The poverty threshold for each country is recorded by the World Bank, which can be viewed through its website at: www.worldbank.org (search for PovertyNet) or directly on the PovertyNet website at: www. povertynet.org[34] where, the poverty threshold for households is specified as persons unable to adequately provide themselves over a 12 month period with water, food, shelter, and other basic needs for a healthy life.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.3">iso37120:5.3</a>
    /// </summary>
    let ``_5.3`` = _prefixId.prefix "5.3"
    /// <summary>
    ///   <para>rdfs:label : Percentage of persons in full-time employment  (supporting indicator)</para>
    ///   <para>dcterms:description : The percentage of persons in full-time employment shall be calculated as the number of persons in full- time employment (numerator) divided by the total city population (denominator). The result shall then be multiplied by 100 and expressed as a percentage.
    ///
    /// The number of persons residing in the city in full-time employment shall include those that are self- employed and shall only include the residents that work a minimum of 35 hours a week in one job and who are of legal working age.
    ///
    /// NOTE 1 City population has been used as the denominator for this indicator instead of workforce given that population will be known for most cities. This indicator is dependent on the government agency charged with the responsibility of collecting relevant employment and population data and the precise nature of the available data.
    ///
    /// Applying current average persons per household figure to all households can lower distinctions between household size in poor and more affluent households.
    ///
    /// NOTE 2 Employment is a formal labour market concept which is often complicated in developing countries with a large informal sector of the city economy.
    ///
    /// NOTE 3 The Social Responsibility core subjects on Human Rights and Labour Practices from ISO 26000 can be considered, and are particularly useful in regards to child labour.
    ///
    /// NOTE 4 The International Labour Organization (ILO) Fundamental Principles and Rights at Work (FPRW) include the elimination of child labour alongside the right to freedom of association and collective bargaining, elimination of forced labour, and the elimination of discrimination in employment or occupation. These fundamental principles and rights at work are mutually interdependent. Violation of one category of rights at work often has an adverse impact on the respect and realization of the others. Vice versa, recognition, promotion and implementation of one category of rights can have a beneficial impact on the respect and realization of the others.
    ///
    /// Over the years the international community has developed a framework of international standards which seek to protect children from child labour, in particular the two important ILO Conventions on the subject and more generally the UN Convention on the Rights of the Child.[45] Whilst some progress
    /// is being made in reducing child labour, in too many cases the rights contained in these international standards are still not fully applied in practice and enforced. Users of this standard are encouraged to keep these principles in mind.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.4">iso37120:5.4</a>
    /// </summary>
    let ``_5.4`` = _prefixId.prefix "5.4"
    /// <summary>
    ///   <para>rdfs:label : Youth unemployment rate  (supporting indicator)</para>
    ///   <para>dcterms:description : Youth unemployment rate shall be calculated as the total number of unemployed youth (numerator) divided by the youth labour force (denominator). The result shall be multiplied by 100 and expressed as a percentage.
    /// 5.5.2 Supporting indicator requirements
    ///
    /// Unemployed youth shall refer to individuals above the legal working age and under 24 years of age who are without work, actively seeking work in a recent past period (past four weeks), and currently available for work. Youth who did not look for work but have a future labour market stake (arrangements for a future job start) are counted as unemployed (International Labour Organization). Discouraged workers or hidden unemployed shall not be counted as unemployed or as part of the labour force. Not actively seeking work shall refer to people who have not taken active steps to seek work (i.e. job searches, interviews, informational meetings etc.) during a specified recent period (usually the past four weeks).
    ///
    /// Youth labour force shall refer to all persons above the legal working age and under 24 years of age, who are either employed or unemployed over a specified reference period.
    ///
    /// NOTE Countries vary somewhat in their operational definitions of youth, in particular, the lower age limit for young people is usually determined by the minimum age for leaving school, where this exists.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.5">iso37120:5.5</a>
    /// </summary>
    let ``_5.5`` = _prefixId.prefix "5.5"
    /// <summary>
    ///   <para>rdfs:label : Number of businesses per 100 000 population (supporting indicator)</para>
    ///   <para>dcterms:description : The number of businesses per 100 000 population shall be calculated as the total number of businesses in a city (numerator) divided by one 100 000th of the city’s total population (denominator). The result shall be expressed as the number of businesses per 100 000 population.
    ///
    /// Businesses shall refer to companies or enterprises. The enterprise is the smallest combination of legal unit, that is, an organizational unit producing goods or services. Business can either be categorized as simple (one operating entity) or complex (multiple operating entities).</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.6">iso37120:5.6</a>
    /// </summary>
    let ``_5.6`` = _prefixId.prefix "5.6"
    /// <summary>
    ///   <para>rdfs:label : Number of new patents per 100 000 population per year (supporting indicator)</para>
    ///   <para>dcterms:description : The number of new patents per 100 000 population per year shall be calculated as the total number of new patents issued to resident persons and corporations of the city (numerator) divided by one 100 000th of the city’s total population (denominator). The result shall be expressed as the number of patents registered per 100 000 population.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#5.7">iso37120:5.7</a>
    /// </summary>
    let ``_5.7`` = _prefixId.prefix "5.7"
    /// <summary>
    ///   <para>rdfs:label : Percentage of female school-aged population enrolled in schools (core indicator)</para>
    ///   <para>dcterms:description : The percentage of female school-aged population enrolled in schools
    /// shall be calculated as the number of female school- aged population
    /// enrolled at primary and secondary levels in public and private schools
    /// (numerator) divided by the total number of female school-aged population
    /// (denominator). The result shall then be multiplied by 100 and expressed
    /// as a percentage.
    ///
    /// The definitions of primary and secondary school detailed in Clauses 3.5
    /// and 3.6 shall apply.
    ///
    /// The proportion of enrolment in public and private schools should be
    /// reported, and cities shall note if private school data are included. In
    /// many cities, private schools are a significant component of education in
    /// the city. Private schools shall be recognized as providing real, bona
    /// fide education; many ministries or departments of education have a
    /// program that recognizes such schools. Enrolment in religious schools and
    /// home schools should be included if they are recognized.
    ///
    /// One part-time enrolment of a half-day or more shall be counted as a
    /// full-time enrolment.
    ///
    /// If the geographies of school districts and the city are different, best
    /// judgment should be used to related enrolment data to the city boundaries.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.1">iso37120:6.1</a>
    /// </summary>
    let ``_6.1`` = _prefixId.prefix "6.1"
    /// <summary>
    ///   <para>rdfs:label : Percentage of students completing primary education: survival rate  (core indicator)</para>
    ///   <para>dcterms:description : The percentage of students completing primary education or survival rate
    /// shall be calculated as the total number of students belonging to a
    /// school-cohort who complete the final grade of primary education
    /// (numerator) divided by the total number of students belonging to a
    /// school-cohort, i.e. those originally enrolled in the first grade of
    /// primary education (denominator). The result shall then be multiplied by
    /// 100 and expressed as a percentage. The survival rate of primary
    /// education shall be expressed as the percentage of a cohort of students
    /// enrolled in the first grade of primary education who reached the final
    /// grade of primary education.
    ///
    /// Survival rates for the private education sector should be reported, if
    /// known. The user of this International Standard shall note if private
    /// school data are included.
    ///
    /// NOTE 1 This indicator measures students belonging to a school-cohort who
    /// has reached each successive grade of primary education without failing
    /// or moving to another jurisdiction.
    ///
    /// NOTE 2 This methodology is adapted from UNESCO Education Indicator
    /// Technical Guidelines.[4]
    ///
    /// EXAMPLE If the city reporting year is 2012 and primary education lasts
    /// five years, report the percentage of students that entered primary
    /// education in 2006 and reached the final grade of primary education in
    /// 2011.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.2">iso37120:6.2</a>
    /// </summary>
    let ``_6.2`` = _prefixId.prefix "6.2"
    /// <summary>
    ///   <para>rdfs:label : Percentage of students completing secondary education: survival rate  (core indicator)</para>
    ///   <para>dcterms:description : The percentage of students completing secondary education or survival
    /// rate shall be calculated as the total number of students belonging to a
    /// school-cohort who complete the final grade of secondary education
    /// (numerator) divided by the total number of students belonging to a
    /// school-cohort, i.e. those originally enrolled in the first grade of
    /// secondary education (denominator). The result shall then be multiplied
    /// by 100 and expressed as a percentage. The survival rate of secondary
    /// education shall be expressed as the percentage of a cohort of students
    /// enrolled in the first grade of secondary education who reached the final
    /// grade of secondary education.
    ///
    /// Survival rates for the private education sector should be reported, if
    /// known. The user of this International Standard shall note if private
    /// school data are included.
    ///
    /// NOTE 1 This indicator measures students belonging to a school-cohort who
    /// has reached each successive grade of secondary education without failing
    /// or moving to another jurisdiction.
    ///
    /// NOTE 2 This methodology is adapted from UNESCO Education Indicator
    /// Technical Guidelines.
    ///
    /// EXAMPLE If the city reporting year is 2012 and secondary education lasts
    /// seven years, report the percentage of students that entered secondary
    /// education in 2004 and reached the final grade of secondary education in
    /// 2011.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.3">iso37120:6.3</a>
    /// </summary>
    let ``_6.3`` = _prefixId.prefix "6.3"
    /// <summary>
    ///   <para>rdfs:label : Primary Education Student/Teacher Ratio  (core indicator)</para>
    ///   <para>dcterms:description : ISO 37120 definition in 1st Edition, 15 May 2014.
    ///
    /// The student/teacher ratio shall be expressed as the number of enrolled
    /// primary school students (numerator) divided by the number of full-time
    /// equivalent primary school classroom teachers (denominator). The result
    /// shall be expressed as the number of students per teacher.
    ///
    /// Private educational facilities shall not be included in the
    /// student/teacher ratio.
    ///
    /// One part-time student enrolment shall be counted as one full-time
    /// enrolment; in other words a student who attends school for half a day
    /// should be counted as a full-time enrolment. If a city reports full-time
    /// equivalent (FTE) enrolment (where two half day students equal one full
    /// student enrolment), this shall be noted.
    ///
    /// The number of classroom teachers and other instructional staff (e.g.
    /// teachers’ aides, guidance counsellors), shall not include administrators
    /// or other non-teaching staff. Kindergarten or pre-school teachers and
    /// staff shall not be included.
    ///
    /// The number of teachers shall be counted in fifth time increments, for
    /// example, a teacher working one day per week should be counted as 0,2
    /// teachers, and a teacher working three days a week should be counted as
    /// 0,6 teachers.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.4">iso37120:6.4</a>
    /// </summary>
    let ``_6.4`` = _prefixId.prefix "6.4"
    /// <summary>
    ///   <para>rdfs:label : Percentage of male school-aged population enrolled in schools  (supporting indicator)</para>
    ///   <para>dcterms:description : The percentage of male school-aged population enrolled at primary and
    /// secondary levels in public and private schools (numerator) divided by
    /// the total number of male school-aged population (denominator). The
    /// result shall then be multiplied by 100 and expressed as a percentage.
    ///
    /// The definitions of primary and secondary school detailed in 3.5 and 3.6
    /// shall apply.
    ///
    /// Enrolment in public and private schools should be reported, and cities
    /// shall note if private school data are included. In many cities, private
    /// schools are a significant component of education in the city. Private
    /// schools shall be recognized as providing real, bona fide education; many
    /// ministries or departments of education have a program that recognizes
    /// such schools. Enrolment in religious schools and home schools should be
    /// included if they are recognized.
    ///
    /// One part-time enrolment of a half-day or more shall be counted as a
    /// full-time enrolment.
    ///
    /// If the geographies of school districts and the city are different, best
    /// judgment should be used to relate enrolment data to the city boundaries.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.5">iso37120:6.5</a>
    /// </summary>
    let ``_6.5`` = _prefixId.prefix "6.5"
    /// <summary>
    ///   <para>rdfs:label : Percentage of school-aged population enrolled in schools (supporting indicator)</para>
    ///   <para>dcterms:description : The percentage of school-aged population enrolled in schools shall be
    /// calculated as the number of school- aged population enrolled in primary
    /// and secondary levels in public and private schools (numerator) divided
    /// by the total number of the school-aged population (denominator). The
    /// result shall then be multiplied by 100 and expressed as a percentage.
    ///
    /// Enrolment in public and private schools should be reported, and cities
    /// shall note in the comment section if private school data are included.
    /// In many cities, private schools are a significant component of education
    /// in the city. Private schools shall be recognized as providing real, bona
    /// fide education; many ministries or departments of education have a
    /// program that recognizes such schools. Enrolment in religious schools and
    /// home schools should be included if they are recognized.
    ///
    /// Part-time enrolment of a half-day or more shall be counted as a
    /// full-time enrolment.
    ///
    /// If the geographies of school districts and the city are different, best
    /// judgement should be used to relate enrolment data to the city boundaries.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.6">iso37120:6.6</a>
    /// </summary>
    let ``_6.6`` = _prefixId.prefix "6.6"
    /// <summary>
    ///   <para>rdfs:label : Number of higher education degrees per 100 000 population (supporting indicator)</para>
    ///   <para>dcterms:description : The number of higher education (tertiary education) degrees per 100 000 population shall be calculated as the number of people holding higher education degrees (numerator) divided by one 100 000th of the city’s total population. The result shall be expressed as the number of higher degrees per 100 000 population.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#6.7">iso37120:6.7</a>
    /// </summary>
    let ``_6.7`` = _prefixId.prefix "6.7"
    /// <summary>
    ///   <para>rdfs:label : Total residential electrical energy use per capita (kWh/year)  (core indicator)</para>
    ///   <para>dcterms:description : Total residential electrical energy use per capita shall be calculated as the total residential electrical usage of a city in kilowatt hours (numerator) divided by the total population of the city (denominator). The result shall be expressed as the total residential electrical use per capita in kilowatt hours/year.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.1">iso37120:7.1</a>
    /// </summary>
    let ``_7.1`` = _prefixId.prefix "7.1"
    /// <summary>
    ///   <para>rdfs:label : Percentage of city population with authorized electrical service  (core indicator)</para>
    ///   <para>dcterms:description : The percentage of city population with authorized electrical service shall be calculated as the number of persons in the city with lawful connection to the electrical supply system (numerator) divided by the total population of the city (denominator). The result shall then be multiplied by 100 and expressed as a percentage.
    ///
    /// The number of city households lawfully connected to the electricity grid shall be multiplied by the current average city household size to determine the number of city residents with lawful connection to the electricity supply system (the electricity grid).
    ///
    /// NOTE Most electricity supply authorities distinguish billing accounts to residential and non residential establishments. Residential establishments in most cities equate to households (although in some condominiums, the body corporate holds the account for multiple households).</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.2">iso37120:7.2</a>
    /// </summary>
    let ``_7.2`` = _prefixId.prefix "7.2"
    /// <summary>
    ///   <para>rdfs:label : Energy consumption of public buildings per year (kWh/m2) (core indicator)</para>
    ///   <para>dcterms:description : Energy consumption of public buildings shall be calculated per year as the total use of electricity at final consumption stage by public buildings (kWh) within a city (numerator) divided by total floor space of these buildings in square meters (m2) (denominator). The result shall be expressed as the total energy consumption of public buildings per year in kilowatt hours per square meter.
    ///
    /// NOTE Public buildings are government owned buildings such as government offices, hospitals and schools.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.3">iso37120:7.3</a>
    /// </summary>
    let ``_7.3`` = _prefixId.prefix "7.3"
    /// <summary>
    ///   <para>rdfs:label : The percentage of total energy derived from renewable sources, as a share of the city’s total energy consumption  (core indicator)</para>
    ///   <para>dcterms:description : The share of a city’s total energy consumption derived from renewable sources shall be calculated as the total consumption of electricity generated from renewable sources (numerator) divided by total energy consumption (denominator). The result shall then be multiplied by 100 and expressed as a percentage. Consumption of renewable sources should include geothermal, solar, wind, hydro, tide and wave energy, and combustibles, such as biomass.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.4">iso37120:7.4</a>
    /// </summary>
    let ``_7.4`` = _prefixId.prefix "7.4"
    /// <summary>
    ///   <para>rdfs:label : Total electrical energy use per capita (kWh/year) (supporting indicator)</para>
    ///   <para>dcterms:description : Total electrical energy use per capita shall be calculated as the total electrical usage of a city in kilowatt hours including residential and non-residential use (numerator) divided by the total population of the city (denominator). The result shall be expressed as the total electrical use per capita in kilowatt hours/year.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.5">iso37120:7.5</a>
    /// </summary>
    let ``_7.5`` = _prefixId.prefix "7.5"
    /// <summary>
    ///   <para>rdfs:label : Average number of electrical interruptions per customer per year (supporting indicator)</para>
    ///   <para>dcterms:description : The average number of electrical interruptions per customer per year shall be calculated as the total number of customer interruptions (numerator) divided by the total number of customers served (denominator). The result shall be expressed as the average number of electrical interruptions per customer per year.
    ///
    /// Electrical interruptions shall include both residential and non-residential.
    /// It is normal to expect interruptions in service for a number of reasons including scheduled maintenance and equipment breakdown. To establish the opportunity to have a reasonable comparison between energy providers, major storms and weather events should be excluded due to their unpredictability and randomness since they are difficult to predict, prevent or mitigate against.
    ///
    /// NOTE This indicator is affected by the age, standard of maintenance and reliability of the infrastructure that constitutes the electricity grid and the electricity transmission capacity that services the grid. The ability of both the grid and its electricity transmission capacity to provide supply on demand and to cope with peak loads is also an important consideration.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.6">iso37120:7.6</a>
    /// </summary>
    let ``_7.6`` = _prefixId.prefix "7.6"
    /// <summary>
    ///   <para>rdfs:label : Average length of electrical interruptions (in hours)  (supporting indicator)</para>
    ///   <para>dcterms:description : The average length of electrical interruptions shall be calculated as the sum of the duration of all customer interruptions in hours (numerator) divided by the total number of customer interruptions (denominator). The result shall be expressed as the average length of electrical interruptions in hours.
    ///
    /// Electrical interruptions shall include both residential and non-residential.
    /// It is normal to expect interruptions in service for a number of reasons including scheduled maintenance and equipment breakdown. To establish the opportunity to have a reasonable comparison between energy providers, major storms and weather events shall be excluded due to their unpredictability as they are difficult to prevent or mitigate against.
    ///
    /// NOTE This indicator is affected by the age, standard of maintenance and reliability of the infrastructure that constitutes the electricity grid and the electricity transmission capacity that services the grid. The ability of both the grid and its electricity transmission capacity to provide supply on demand and to cope with peak loads is also an important consideration.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#7.7">iso37120:7.7</a>
    /// </summary>
    let ``_7.7`` = _prefixId.prefix "7.7"
    /// <summary>
    ///   <para>rdfs:label : Fine particulate matter (PM2.5) concentration  (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.1">iso37120:8.1</a>
    /// </summary>
    let ``_8.1`` = _prefixId.prefix "8.1"
    /// <summary>
    ///   <para>rdfs:label : Particulate matter (PM10) concentration (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.2">iso37120:8.2</a>
    /// </summary>
    let ``_8.2`` = _prefixId.prefix "8.2"
    /// <summary>
    ///   <para>rdfs:label : Greenhouse gas emissions measured in tonnes per capita (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.3">iso37120:8.3</a>
    /// </summary>
    let ``_8.3`` = _prefixId.prefix "8.3"
    /// <summary>
    ///   <para>rdfs:label : NO2 (nitrogen dioxide) concentration (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.4">iso37120:8.4</a>
    /// </summary>
    let ``_8.4`` = _prefixId.prefix "8.4"
    /// <summary>
    ///   <para>rdfs:label : SO2 (sulphur dioxide) concentration (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.5">iso37120:8.5</a>
    /// </summary>
    let ``_8.5`` = _prefixId.prefix "8.5"
    /// <summary>
    ///   <para>rdfs:label : O3 (Ozone) concentration (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.6">iso37120:8.6</a>
    /// </summary>
    let ``_8.6`` = _prefixId.prefix "8.6"
    /// <summary>
    ///   <para>rdfs:label : Noise pollution (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.7">iso37120:8.7</a>
    /// </summary>
    let ``_8.7`` = _prefixId.prefix "8.7"
    /// <summary>
    ///   <para>rdfs:label : Percentage change in number of native species (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#8.8">iso37120:8.8</a>
    /// </summary>
    let ``_8.8`` = _prefixId.prefix "8.8"
    /// <summary>
    ///   <para>rdfs:label : Debt service ratio (debt service expenditure as a percentage of a municipality’s own-source revenue) (core indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#9.1">iso37120:9.1</a>
    /// </summary>
    let ``_9.1`` = _prefixId.prefix "9.1"
    /// <summary>
    ///   <para>rdfs:label : Capital spending as a percentage of total expenditures (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#9.2">iso37120:9.2</a>
    /// </summary>
    let ``_9.2`` = _prefixId.prefix "9.2"
    /// <summary>
    ///   <para>rdfs:label : Own-source revenue as a percentage of total revenues (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#9.3">iso37120:9.3</a>
    /// </summary>
    let ``_9.3`` = _prefixId.prefix "9.3"
    /// <summary>
    ///   <para>rdfs:label : Tax collected as a percentage of tax billed (supporting indicator)</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#9.4">iso37120:9.4</a>
    /// </summary>
    let ``_9.4`` = _prefixId.prefix "9.4"
    /// <summary>
    ///   <para>rdfs:label : Economy Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Economy">iso37120:Economy</a>
    /// </summary>
    let Economy = _prefixId.prefix "Economy"
    /// <summary>
    ///   <para>rdfs:label : Education Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Education">iso37120:Education</a>
    /// </summary>
    let Education = _prefixId.prefix "Education"
    /// <summary>
    ///   <para>rdfs:label : Energy Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Energy">iso37120:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : Environment Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Environment">iso37120:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:label : Finance Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Finance">iso37120:Finance</a>
    /// </summary>
    let Finance = _prefixId.prefix "Finance"
    /// <summary>
    ///   <para>rdfs:label : Fire and Emergency Response Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#FireAndEmergencyResponse">iso37120:FireAndEmergencyResponse</a>
    /// </summary>
    let FireAndEmergencyResponse = _prefixId.prefix "FireAndEmergencyResponse"
    /// <summary>
    ///   <para>rdfs:label : Governance Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Governance">iso37120:Governance</a>
    /// </summary>
    let Governance = _prefixId.prefix "Governance"
    /// <summary>
    ///   <para>rdfs:label : Health Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Health">iso37120:Health</a>
    /// </summary>
    let Health = _prefixId.prefix "Health"
    let ISO37120DataProperty = _prefixId.prefix "ISO37120DataProperty"
    let ISO37120_Indicator = _prefixId.prefix "ISO37120_Indicator"
    /// <summary>
    ///   <para>rdfs:label : Recreation Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Recreation">iso37120:Recreation</a>
    /// </summary>
    let Recreation = _prefixId.prefix "Recreation"
    /// <summary>
    ///   <para>rdfs:label : Safety Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Safety">iso37120:Safety</a>
    /// </summary>
    let Safety = _prefixId.prefix "Safety"
    /// <summary>
    ///   <para>rdfs:label : Shelter Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Shelter">iso37120:Shelter</a>
    /// </summary>
    let Shelter = _prefixId.prefix "Shelter"
    /// <summary>
    ///   <para>rdfs:label : Solid Waste Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#SolidWaste">iso37120:SolidWaste</a>
    /// </summary>
    let SolidWaste = _prefixId.prefix "SolidWaste"

    /// <summary>
    ///   <para>rdfs:label : Telecommunications and Innovation Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#TelecommunicationAndInnovation">iso37120:TelecommunicationAndInnovation</a>
    /// </summary>
    let TelecommunicationAndInnovation =
        _prefixId.prefix "TelecommunicationAndInnovation"

    /// <summary>
    ///   <para>rdfs:label : Transportation Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Transportation">iso37120:Transportation</a>
    /// </summary>
    let Transportation = _prefixId.prefix "Transportation"
    /// <summary>
    ///   <para>rdfs:label : Urban Planning Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#UrbanPlanning">iso37120:UrbanPlanning</a>
    /// </summary>
    let UrbanPlanning = _prefixId.prefix "UrbanPlanning"
    /// <summary>
    ///   <para>rdfs:label : Waste Water Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#Wastewater">iso37120:Wastewater</a>
    /// </summary>
    let Wastewater = _prefixId.prefix "Wastewater"
    /// <summary>
    ///   <para>rdfs:label : Water and Sanitation Indicators</para>
    ///   <a href="http://ontology.eil.utoronto.ca/ISO37120.owl#WaterAndSanitation">iso37120:WaterAndSanitation</a>
    /// </summary>
    let WaterAndSanitation = _prefixId.prefix "WaterAndSanitation"
    let indicator_value = _prefixId.prefix "indicator_value"

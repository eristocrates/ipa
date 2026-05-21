declare variable $target_databaseNames := 
(
  
  "USRNAME",
"EMPID",
"AUTHCODE",
"DATAGRP",
"USRKEY",
"NTUSRNAME",
"ROLEADMIN",
"ADDBY",
"ADDDTTM",
"MODBY",
"MODDTTM",
"PASSEXPDTTM",
"LOGINATTEMPTS",
"EXPDAYS",
"UNIQUEPWD",
"ISREPORTAUTHOR",
"DISPLAYNAME",
"ALTERNATEID",
"LICENSENAME",
"LICENSETYPE",
"LICENSECONTENT",
"LICENSEKEY",
"ENCRYPTCONTENT"


);

let $results :=
  for $element in //*
    let $databaseName := $element/@databaseName 
    where $databaseName = $target_databaseNames
    order by $databaseName
    return `{$element/@name} : {$databaseName}`

return distinct-values($results)
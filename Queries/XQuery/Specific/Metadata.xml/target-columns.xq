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
for $element in //*
  where $element/@databaseName = $target_databaseNames
  return $element
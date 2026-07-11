for $table in //table
let $tableName := string($table/@name)
where 
  $table/parent::element()/@name = "AssetManagement.Storm"
  and
  starts-with($table/@databaseName, "COMP")
  and $table/column[contains(text/@description,"ilter")]
return  $table/@name
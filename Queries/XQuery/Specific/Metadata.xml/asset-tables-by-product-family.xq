for $table in //table
let $tableName := string($table/@name)
where 
  $table/parent::element()/@name = "AssetManagement.Storm"
  and
  fn:starts-with($table/@databaseName, "COMP")
return `{$tableName},`
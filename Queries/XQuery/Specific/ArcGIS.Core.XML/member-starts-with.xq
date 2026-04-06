for $member in //member
  where $member
  (:where starts-with(string($member/@name), "F:ArcGIS.Core.CIM.esriFieldType"):)
  return $member
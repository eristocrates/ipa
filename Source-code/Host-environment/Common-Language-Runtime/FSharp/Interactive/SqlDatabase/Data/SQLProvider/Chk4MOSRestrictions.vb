if oServiceRequest.RequestType.RequestType = "16"  or oServiceRequest.RequestType.RequestType = "17" or oServiceRequest.RequestType.RequestType = "18" then


  Dim foundError as String = "N"
  
  Dim lCount as Integer
  
  
  'First check for Open WO of same activity 
  
  
  Dim res as Hansen.Core.Result
  
  Dim oProvider As Hansen.Core.Data.CDBProvider
  
  Dim mySql As String
  
  DIM alertString As String
  
  
  Dim parms As Hansen.Core.Data.DBParameterCollection
  
  Dim ds As System.Data.DataSet = New System.Data.DataSet
  
  
  ' Get the provider info from the current records business object
  
  Dim SR= CType(oServiceRequest, Hansen.Core.Business.IComponent)
  
  oProvider = SR.GetProvider()
  
  
  'create SQL statement
  
  
  mySql  = "Select Top 1 IsNull(opta,'') as opta, IsNull(optb,'') as optb, optd, addrkey from Property.Address ad where  ad.addrkey  = '" & Microsoft.VisualBasic.Trim(oServiceRequest.Address.AddressKey) & "'"
  
   
  
  ' Run SQL statement
  
  res = Hansen.Core.DataServices.ExecSQL(oProvider, mySql, parms, ds)
  
  
  lCount=ds.Tables(0).Rows.count()
  
  
  if  lCount = 1 then
  
  
  if ds.Tables(0).Rows(0).Item("opta") = "NO-SPRAY" then
  
      foundError = "1"
  
      alertString = "THIS ADDRESS IS NO-SPRAY <br><br>" & alertString
  
      oServiceRequest.Comments = "ALERT - THIS ADDRESS IS NO-SPRAY <br><br>" & oServiceRequest.Comments
  
  end if 
  
  
  if ds.Tables(0).Rows(0).Item("optb") = "DO-CALL"  then
  
      foundError = "2"
  
      alertString = "MUST CALL BEFORE SPRAY   <br><br>" & alertString
  
      oServiceRequest.Comments = "ALERT - MUST CALL BEFORE SPRAY  <br><br>" & oServiceRequest.Comments
  
  end if 
  
  
  if ds.Tables(0).Rows(0).Item("optb") = "LETTER"  then
  
      foundError = "2"
  
      alertString = "LETTER 48 HOURS BEFORE SPRAY REQUIRED  <br><br>" & alertString
  
      oServiceRequest.Comments = "ALERT - LETTER 48 HOURS BEFORE SPRAY REQUIRED <br><br>" & oServiceRequest.Comments
  
  end if 
  
  
  
  if oServiceRequest.RequestType.RequestType = "16" or oServiceRequest.RequestType.RequestType = "18"  then
  
  
  mySql  = "Select Top 1 opta, optb, optd, stname, stno, addrkey from Property.Address ad where  ad.addrkey  <> '" & Microsoft.VisualBasic.Trim(oServiceRequest.Address.AddressKey) & "' and stname = (select stname from property.address where  addrkey  = '" & Microsoft.VisualBasic.Trim(oServiceRequest.Address.AddressKey) & "' )  and opta = 'NO-SPRAY'"
  
   
  
  ' Run SQL statement
  
  res = Hansen.Core.DataServices.ExecSQL(oProvider, mySql, parms, ds)
  
  
  lCount=ds.Tables(0).Rows.count()
  
  
     if  lCount = 1 then
  
         foundError = "3"
  
         alertString = "ALERT - NO-SPRAY ADDRESSES ON THIS STREET  <br><br>" & alertString
  
         oServiceRequest.Comments = "NO-SPRAY ADDRESSES ON THIS STREET  <br><br>" & oServiceRequest.Comments
  
     end if 
  
  end if
  
  
  if oServiceRequest.RequestType.RequestType = "16" then
  
  
  mySql  = "Select Top 1 opta, optb, optd, stname, stno, addrkey from Property.Address ad where  ad.addrkey  <> '" & Microsoft.VisualBasic.Trim(oServiceRequest.Address.AddressKey) & "' and stname = (select stname from property.address where  addrkey  = '" & Microsoft.VisualBasic.Trim(oServiceRequest.Address.AddressKey) & "' )  and optb =  'DO-CALL'"
  
   
  
  ' Run SQL statement
  
  res = Hansen.Core.DataServices.ExecSQL(oProvider, mySql, parms, ds)
  
  
  lCount=ds.Tables(0).Rows.count()
  
  
     if  lCount = 1 then
  
         foundError = "4"
  
         alertString = "ALERT - CALL BEFORE ADDRESSES ON THIS STREET  <br><br>" & alertString
  
         oServiceRequest.Comments = "ALERT - CALL BEFORE ADDRESSES ON THIS STREET  <br><br>" & oServiceRequest.Comments
  
     end if 
  
  end if
  
  
    if foundError <> "N" then
  
       Dim rMessage as Result
  
  
        rMessage = New Result(0,ResultSeverity.UserWarning, "One or more ALERTs have been found<br><br>" & alertString)
  
       return rMessage
  
    end if
  
  end if
  
  
  End if
  
  
  
  
  'Stephen Lenzo
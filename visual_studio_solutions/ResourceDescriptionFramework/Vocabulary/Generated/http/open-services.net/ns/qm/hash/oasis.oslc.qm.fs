namespace Oasis.oslc.qm.Namespace
module qm =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://open-services.net/ns/qm#" (Some "https://docs.oasis-open-projects.org/oslc-op/qm/v2.1/os/quality-management-vocab.ttl") (Some "oasis.oslc.qm") None
    let TestCase = {_prefixID with _localName = "TestCase"}
    let TestExecutionRecord = {_prefixID with _localName = "TestExecutionRecord"}
    let TestPlan = {_prefixID with _localName = "TestPlan"}
    let TestResult = {_prefixID with _localName = "TestResult"}
    let TestScript = {_prefixID with _localName = "TestScript"}
    let affectedByChangeRequest = {_prefixID with _localName = "affectedByChangeRequest"}
    let blockedByChangeRequest = {_prefixID with _localName = "blockedByChangeRequest"}
    let executesTestScript = {_prefixID with _localName = "executesTestScript"}
    let executionInstructions = {_prefixID with _localName = "executionInstructions"}
    let producedByTestExecutionRecord = {_prefixID with _localName = "producedByTestExecutionRecord"}
    let relatedChangeRequest = {_prefixID with _localName = "relatedChangeRequest"}
    let reportsOnTestCase = {_prefixID with _localName = "reportsOnTestCase"}
    let reportsOnTestPlan = {_prefixID with _localName = "reportsOnTestPlan"}
    let runsOnTestEnvironment = {_prefixID with _localName = "runsOnTestEnvironment"}
    let runsTestCase = {_prefixID with _localName = "runsTestCase"}
    let status = {_prefixID with _localName = "status"}
    let testsChangeRequest = {_prefixID with _localName = "testsChangeRequest"}
    let usesTestCase = {_prefixID with _localName = "usesTestCase"}
    let usesTestScript = {_prefixID with _localName = "usesTestScript"}
    let validatesRequirement = {_prefixID with _localName = "validatesRequirement"}
    let validatesRequirementCollection = {_prefixID with _localName = "validatesRequirementCollection"}
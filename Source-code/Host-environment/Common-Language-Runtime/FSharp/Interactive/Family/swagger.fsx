module https.dev_int_api_gw.centene.com.fhir.v4.providerdirectory

module swagger =
    let openapi = "3.0.1"

    let servers =
        [| {| url = "https://dev-int-api-gw.centene.com/fhir/v4/providerdirectory" |} |]

    let tags =
        [| {| name = "HealthcareService" |}
           {| name = "InsurancePlan" |}
           {| name = "Location" |}
           {| name = "Organization" |}
           {| name = "OrganizationAffiliation" |}
           {| name = "Practitioner" |}
           {| name = "PractitionerRole" |}
           {| name = "Endpoint" |}
           {| name = "metadata" |} |]

    module info =
        let title = "Provider Directory"
        let description = "Provider directory endpoints for FHIR resources"
        let version = "1.0"

    module paths =
        module metadata =
            module get =
                let summary = "CapailityStatement"
                let description = "Capability Statement"
                let operationId = "getMetadata"
                let tags = [| "metadata" |]

                module responses =
                    module _200 =
                        let description = "Success"

        module InsurancePlan =
            module get =
                let summary =
                    "Search all resources of type InsurancePlan based on a set of criteria"

                let operationId = "searchInsurancePlan"
                let tags = [| "InsurancePlan" |]

                let parameters =
                    [| {| name = "administered-by"
                          ``in`` = "query"
                          description = Some "Product administrator"
                          ``x-consoleDefault`` = None |}
                       {| name = "coverage-area"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "identifier"
                          ``in`` = "query"
                          description =
                           Some "Any identifier for the organization (not the accreditation issuer\'s identifier)"
                          ``x-consoleDefault`` = None |}
                       {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "name"
                          ``in`` = "query"
                          description = Some "A portion of the organization\'s name or alias"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:contains"
                          ``in`` = "query"
                          description = Some "Contains a portion of the organization\'s name or alias"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:exact"
                          ``in`` = "query"
                          description = Some "An exact organization\'s name or alias"
                          ``x-consoleDefault`` = None |}
                       {| name = "owned-by"
                          ``in`` = "query"
                          description = Some "An organization of which this organization forms a part"
                          ``x-consoleDefault`` = None |}
                       {| name = "plan-type"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "plan-type:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "type"
                          ``in`` = "query"
                          description = Some "A code for the type of organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "identifier:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "type:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/InsurancePlan-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module InsurancePlan'id =
            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readInsurancePlan"
                let tags = [| "InsurancePlan" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/InsurancePlan"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Endpoint'id =
            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readEndpoint"
                let tags = [| "Endpoint" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Endpoint"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Endpoint =
            module get =
                let summary = "Search all resources of type Endpoint based on a set of criteria"
                let operationId = "searchEndpoint"
                let tags = [| "Endpoint" |]

                let parameters =
                    [| {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "organization"
                          ``in`` = "query"
                          description = Some "The organization that provides this Endpoint Service"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Endpoint-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module HealthcareService =
            let summary = "manage the collection of resources of type HealthcareService"

            let description =
                "Access to services to manage the collection of all resources of type HealthcareService"

            module get =
                let summary =
                    "Search all resources of type HealthcareService based on a set of criteria"

                let operationId = "searchHealthcareService"
                let tags = [| "HealthcareService" |]

                let parameters =
                    [| {| name = "coverage-area"
                          ``in`` = "query"
                          description = Some "Location(s) service is intended for/available to"
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "location"
                          ``in`` = "query"
                          description = Some "The location of the Healthcare Service"
                          ``x-consoleDefault`` = None |}
                       {| name = "name"
                          ``in`` = "query"
                          description = Some "A portion of the Healthcare service name"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:contains"
                          ``in`` = "query"
                          description = Some "Contains a portion of the Healthcare service name"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:exact"
                          ``in`` = "query"
                          description = Some "An exact Healthcare service name"
                          ``x-consoleDefault`` = None |}
                       {| name = "organization"
                          ``in`` = "query"
                          description = Some "The organization that provides this Healthcare Service"
                          ``x-consoleDefault`` = None |}
                       {| name = "service-category"
                          ``in`` = "query"
                          description = Some "Service Category of the Healthcare Service"
                          ``x-consoleDefault`` = None |}
                       {| name = "service-category:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "service-type"
                          ``in`` = "query"
                          description = Some "The type of service provided by this healthcare service"
                          ``x-consoleDefault`` = None |}
                       {| name = "service-type:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "specialty"
                          ``in`` = "query"
                          description = Some "The specialty of the service provided by this healthcare service"
                          ``x-consoleDefault`` = None |}
                       {| name = "specialty:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "endpoint"
                          ``in`` = "query"
                          description = Some "Search for HealthcareServices with specified endpoint"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_revinclude"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/HealthcareService-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module HealthcareService'id =
            let summary = "Read resource instance of type HealthcareService"

            let description =
                "Access to services to manage the state of a single resource of type HealthcareService"

            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readHealthcareService"
                let tags = [| "HealthcareService" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/HealthcareService"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module OrganizationAffiliation =
            let summary = "manage the collection of resources of type OrganizationAffiliation"

            let description =
                "Access to services to manage the collection of all resources of type OrganizationAffiliation"

            module get =
                let summary =
                    "Search all resources of type OrganizationAffiliation based on a set of criteria"

                let operationId = "searchOrganizationAffiliation"
                let tags = [| "OrganizationAffiliation" |]

                let parameters =
                    [| {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "location"
                          ``in`` = "query"
                          description = Some "The location(s) at which the role occurs"
                          ``x-consoleDefault`` = None |}
                       {| name = "network"
                          ``in`` = "query"
                          description =
                           Some
                               "Health insurance provider network in which the participatingOrganization provides the role\'s services (if defined) at the indicated locations (if defined)"
                          ``x-consoleDefault`` = None |}
                       {| name = "participating-organization"
                          ``in`` = "query"
                          description = Some "The organization that provides services to the primary organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "primary-organization"
                          ``in`` = "query"
                          description =
                           Some "The organization that receives the services from the participating organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "role"
                          ``in`` = "query"
                          description = Some "Definition of the role the participatingOrganization plays"
                          ``x-consoleDefault`` = None |}
                       {| name = "service"
                          ``in`` = "query"
                          description = Some "Healthcare services provided through the role"
                          ``x-consoleDefault`` = None |}
                       {| name = "specialty"
                          ``in`` = "query"
                          description =
                           Some "Specific specialty of the participatingOrganization in the context of the role"
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "endpoint"
                          ``in`` = "query"
                          description = Some "Search for OrganizationAffiliations with specified endpoint"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/OrganizationAffiliation-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module OrganizationAffiliation'id =
            let summary = "Read resource instance of type OrganizationAffiliation"

            let description =
                "Access to services to manage the state of a single resource of type OrganizationAffiliation"

            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readOrganizationAffiliation"
                let tags = [| "OrganizationAffiliation" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/OrganizationAffiliation"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Organization =
            let summary = "manage the collection of resources of type Organization"

            let description =
                "Access to services to manage the collection of all resources of type Organization"

            module get =
                let summary = "Search all resources of type Organization based on a set of criteria"
                let operationId = "searchOrganization"
                let tags = [| "Organization" |]

                let parameters =
                    [| {| name = "coverage-area"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "type"
                          ``in`` = "query"
                          description = Some "A code for the type of organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "type:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "partof"
                          ``in`` = "query"
                          description = Some "An organization of which this organization forms a part"
                          ``x-consoleDefault`` = None |}
                       {| name = "address"
                          ``in`` = "query"
                          description =
                           Some
                               "A server defined search that may match any of the string fields in the Address, including line, city, district, state, country, postalCode, and/or text"
                          ``x-consoleDefault`` = None |}
                       {| name = "address:contains"
                          ``in`` = "query"
                          description =
                           Some
                               "A server defined search that contains a match any of the string fields in the Address, including line, city, district, state, country, postalCode, and/or text"
                          ``x-consoleDefault`` = None |}
                       {| name = "address:exact"
                          ``in`` = "query"
                          description =
                           Some
                               "A server defined search that is an exact match of the string fields in the Address, including line, city, district, state, country, postalCode, and text"
                          ``x-consoleDefault`` = None |}
                       {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "name"
                          ``in`` = "query"
                          description = Some "A portion of the organization\'s name or alias"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:exact"
                          ``in`` = "query"
                          description = Some "An exact part of the organization\'s name or alias"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:contains"
                          ``in`` = "query"
                          description = Some "Contains a portion of the organization\'s name or alias"
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "endpoint"
                          ``in`` = "query"
                          description = Some "Search for Organizations with specified endpoint"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_revinclude"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Organization-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Organization'id =
            let summary = "Read resource instance of type Organization"

            let description =
                "Access to services to manage the state of a single resource of type Organization"

            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readOrganization"
                let tags = [| "Organization" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Organization"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module PractitionerRole =
            let summary = "manage the collection of resources of type PractitionerRole"

            let description =
                "Access to services to manage the collection of all resources of type PractitionerRole"

            module get =
                let summary =
                    "Search all resources of type PractitionerRole based on a set of criteria"

                let operationId = "searchPractitionerRole"
                let tags = [| "PractitionerRole" |]

                let parameters =
                    [| {| name = "location"
                          ``in`` = "query"
                          description = Some "One of the locations at which this practitioner provides care"
                          ``x-consoleDefault`` = None |}
                       {| name = "network"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "organization"
                          ``in`` = "query"
                          description =
                           Some "The identity of the organization the practitioner represents / acts on behalf of"
                          ``x-consoleDefault`` = None |}
                       {| name = "practitioner"
                          ``in`` = "query"
                          description =
                           Some "Practitioner that is able to provide the defined services for the organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "role"
                          ``in`` = "query"
                          description = Some "The practitioner can perform this role at for the organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "service"
                          ``in`` = "query"
                          description =
                           Some
                               "The list of healthcare services that this worker provides for this role\'s Organization/Location(s)"
                          ``x-consoleDefault`` = None |}
                       {| name = "specialty"
                          ``in`` = "query"
                          description = Some "The practitioner has this specialty at an organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "endpoint"
                          ``in`` = "query"
                          description = Some "Search for PractitionerRoles with specified endpoint"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/PractitionerRole-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module PractitionerRole'id =
            let summary = "Read resource instance of type PractitionerRole"

            let description =
                "Access to services to manage the state of a single resource of type PractitionerRole"

            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readPractitionerRole"
                let tags = [| "PractitionerRole" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/PractitionerRole"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Practitioner =
            let summary = "manage the collection of resources of type Practitioner"

            let description =
                "Access to services to manage the collection of all resources of type Practitioner"

            module get =
                let summary = "Search all resources of type Practitioner based on a set of criteria"
                let operationId = "searchPractitioner"
                let tags = [| "Practitioner" |]

                let parameters =
                    [| {| name = "family"
                          ``in`` = "query"
                          description = Some "A portion of the family name"
                          ``x-consoleDefault`` = None |}
                       {| name = "family:contains"
                          ``in`` = "query"
                          description = Some "Contains a portion of the family name"
                          ``x-consoleDefault`` = None |}
                       {| name = "family:exact"
                          ``in`` = "query"
                          description = Some "An exact family name"
                          ``x-consoleDefault`` = None |}
                       {| name = "given"
                          ``in`` = "query"
                          description = Some "A portion of the given name"
                          ``x-consoleDefault`` = None |}
                       {| name = "given:contains"
                          ``in`` = "query"
                          description = Some "Contains a portion of the given name"
                          ``x-consoleDefault`` = None |}
                       {| name = "given:exact"
                          ``in`` = "query"
                          description = Some "Exact given name"
                          ``x-consoleDefault`` = None |}
                       {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "name"
                          ``in`` = "query"
                          description =
                           Some
                               "A server defined search that may match any of the string fields in the HumanName, including family, give, prefix, suffix, suffix, and/or text"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:contains"
                          ``in`` = "query"
                          description =
                           Some
                               "A server defined search that contains a match any of the string fields in the HumanName, including family, give, prefix, suffix, suffix, and/or text"
                          ``x-consoleDefault`` = None |}
                       {| name = "name:exact"
                          ``in`` = "query"
                          description =
                           Some
                               "A server defined search that is an exact match of the string fields in the HumanName, including family, give, prefix, suffix, suffix, and text"
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "_revinclude"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Practitioner-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Practitioner'id =
            let summary = "Read resource instance of type Practitioner"

            let description =
                "Access to services to manage the state of a single resource of type Practitioner"

            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readPractitioner"
                let tags = [| "Practitioner" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Practitioner"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Location =
            let summary = "manage the collection of resources of type Location"

            let description =
                "Access to services to manage the collection of all resources of type Location"

            module get =
                let summary = "Search all resources of type Location based on a set of criteria"
                let operationId = "searchLocation"
                let tags = [| "Location" |]

                let parameters =
                    [| {| name = "address"
                          ``in`` = "query"
                          description = Some "A (part of the) address of the location"
                          ``x-consoleDefault`` = None |}
                       {| name = "address:contains"
                          ``in`` = "query"
                          description = Some "Contains an address of the location"
                          ``x-consoleDefault`` = None |}
                       {| name = "address:exact"
                          ``in`` = "query"
                          description = Some "An exact specified address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-city"
                          ``in`` = "query"
                          description = Some "A city specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-city:exact"
                          ``in`` = "query"
                          description = Some "An exact city specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-city:contains"
                          ``in`` = "query"
                          description = Some "Contains a city specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-postalcode"
                          ``in`` = "query"
                          description = Some "A postal code specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-postalcode:contains"
                          ``in`` = "query"
                          description = Some "Contains postal code specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-postalcode:exact"
                          ``in`` = "query"
                          description = Some "Exact postal code specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-state"
                          ``in`` = "query"
                          description = Some "A state specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-state:contains"
                          ``in`` = "query"
                          description = Some "Contains state specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "address-state:exact"
                          ``in`` = "query"
                          description = Some "An exact state specified in an address"
                          ``x-consoleDefault`` = None |}
                       {| name = "_id"
                          ``in`` = "query"
                          description = Some "The ID of the resource"
                          ``x-consoleDefault`` = None |}
                       {| name = "organization"
                          ``in`` = "query"
                          description = Some "Searches for locations that are managed by the provided organization"
                          ``x-consoleDefault`` = None |}
                       {| name = "partof"
                          ``in`` = "query"
                          description = Some "A location of which this location is a part"
                          ``x-consoleDefault`` = None |}
                       {| name = "type"
                          ``in`` = "query"
                          description = Some "A code for the type of location"
                          ``x-consoleDefault`` = None |}
                       {| name = "type:text"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_lastUpdated"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "endpoint"
                          ``in`` = "query"
                          description = Some "Search for Locations with specified endpoint"
                          ``x-consoleDefault`` = None |}
                       {| name = "_include"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_revinclude"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = Some "application/json" |}
                       {| name = "_source"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_next"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |}
                       {| name = "_page"
                          ``in`` = "query"
                          description = None
                          ``x-consoleDefault`` = None |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Location-search"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

        module Location'id =
            let summary = "Read resource instance of type Location"

            let description =
                "Access to services to manage the state of a single resource of type Location"

            module get =
                let summary = "Read the current state of the resource"
                let operationId = "readLocation"
                let tags = [| "Location" |]

                let parameters =
                    [| {| name = "id"
                          ``in`` = "path"
                          required = true |} |]

                let security = [| {| Basic = ([||] : obj array) |} |]

                module responses =
                    module _200 =
                        let description = "Success"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/Location"

                    module _400 =
                        let description = "Bad request"

                        module content =
                            module asterisk_solidus_asterisk =
                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "invalid" |} |]

                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                    module _401 =
                        let description = "Unauthorized"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Unauthorized" |} |]

                    module _403 =
                        let description = "Forbidden"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "forbidden" |} |]

                    module _404 =
                        let description = "Not Found"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Found" |} |]

                    module _500 =
                        let description = "InternalServerError"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "fatal"
                                              code = "exception" |} |]

                    module _429 =
                        let description = "Too Many Requests"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Too Many Requests" |} |]

                    module _501 =
                        let description = "Not Implemented"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Not Implemented" |} |]

                    module _502 =
                        let description = "Bad gateway"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Bad gateway" |} |]

                    module _503 =
                        let description = "Service Unavailable"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Service Unavailable" |} |]

                    module _504 =
                        let description = "Gateway Timeout"

                        module content =
                            module asterisk_solidus_asterisk =
                                module schema =
                                    let ``$ref`` = "#/components/schemas/GeneralError"

                                module example =
                                    let resourceType = "OperationOutcome"

                                    let issue =
                                        [| {| severity = "error"
                                              code = "Gateway Timeout" |} |]

    module components =
        module schemas =
            module GeneralError =
                let ``type`` = "object"
                let required = [| "resourceType"; "issue" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module issue =
                        let ``type`` = "object"
                        let required = [| "severity"; "code"; "details" |]

                        module properties =
                            module severity =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module code =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module details =
                                let ``type`` = "string"
                                let minLength = 1.0m

            module OperationOutcome =
                let ``type`` = "object"

            module InsurancePlan =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "administeredBy"
                       "coverageArea"
                       "id"
                       "language"
                       "meta"
                       "name"
                       "network"
                       "ownedBy"
                       "plan"
                       "resourceType"
                       "status"
                       "text"
                       "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module status =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module type_ =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "display"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module display =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module name =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module ownedBy =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module administeredBy =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module coverageArea =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module network =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module plan =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module type_ =
                                    let ``type`` = "object"
                                    let required = [| "coding" |]

                                    module properties =
                                        module coding =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "code"; "display"; "system" |]

                                                module properties =
                                                    module system =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module code =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module display =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

            module InsurancePlan_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "administeredBy"
                                           "coverageArea"
                                           "id"
                                           "language"
                                           "meta"
                                           "name"
                                           "network"
                                           "ownedBy"
                                           "plan"
                                           "resourceType"
                                           "status"
                                           "text"
                                           "type" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module status =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module type_ =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "display"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module display =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module name =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module ownedBy =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module administeredBy =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module coverageArea =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module network =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module plan =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module type_ =
                                                        let ``type`` = "object"
                                                        let required = [| "coding" |]

                                                        module properties =
                                                            module coding =
                                                                let ``type`` = "array"
                                                                let minItems = 1.0m
                                                                let uniqueItems = true

                                                                module items =
                                                                    let ``type`` = "object"
                                                                    let required = [| "code"; "display"; "system" |]

                                                                    module properties =
                                                                        module system =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                                                        module code =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                                                        module display =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

            module HealthcareService =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "active"
                       "category"
                       "extension"
                       "id"
                       "language"
                       "location"
                       "meta"
                       "providedBy"
                       "resourceType"
                       "specialty"
                       "text" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module extension =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "url" |]

                            module properties =
                                module extension =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "url" |]

                                        module properties =
                                            module url =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module valueCodeableConcept =
                                                let ``type`` = "object"
                                                let required = [| "coding" |]

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module active =
                        let ``type`` = "boolean"

                    module providedBy =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module category =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module specialty =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "display"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module display =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module location =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

            module HealthcareService_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "active"
                                           "category"
                                           "extension"
                                           "id"
                                           "language"
                                           "location"
                                           "meta"
                                           "providedBy"
                                           "resourceType"
                                           "specialty"
                                           "text" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module extension =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "url" |]

                                                module properties =
                                                    module extension =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "url" |]

                                                            module properties =
                                                                module url =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module valueCodeableConcept =
                                                                    let ``type`` = "object"
                                                                    let required = [| "coding" |]

                                                                    module properties =
                                                                        module coding =
                                                                            let ``type`` = "array"
                                                                            let minItems = 1.0m
                                                                            let uniqueItems = true

                                                                            module items =
                                                                                let ``type`` = "object"
                                                                                let required = [| "code"; "system" |]

                                                                                module properties =
                                                                                    module system =
                                                                                        let ``type`` = "string"
                                                                                        let minLength = 1.0m

                                                                                    module code =
                                                                                        let ``type`` = "string"
                                                                                        let minLength = 1.0m

                                                    module url =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module active =
                                            let ``type`` = "boolean"

                                        module providedBy =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module category =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module specialty =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "display"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module display =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module location =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

            module OrganizationAffiliation =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "active"
                       "code"
                       "healthcareService"
                       "id"
                       "language"
                       "location"
                       "meta"
                       "network"
                       "organization"
                       "participatingOrganization"
                       "resourceType"
                       "text" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module active =
                        let ``type`` = "boolean"

                    module organization =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module participatingOrganization =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module network =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module code =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module location =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module healthcareService =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

            module OrganizationAffiliation_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "active"
                                           "code"
                                           "healthcareService"
                                           "id"
                                           "language"
                                           "location"
                                           "meta"
                                           "network"
                                           "organization"
                                           "participatingOrganization"
                                           "resourceType"
                                           "text" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module active =
                                            let ``type`` = "boolean"

                                        module organization =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module participatingOrganization =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module network =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module code =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module location =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module healthcareService =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

            module Organization =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "active"
                       "contact"
                       "extension"
                       "id"
                       "language"
                       "meta"
                       "name"
                       "partOf"
                       "resourceType"
                       "text"
                       "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module extension =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "url" |]

                            module properties =
                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module valueReference =
                                    let ``type`` = "object"
                                    let required = [| "reference" |]

                                    module properties =
                                        module reference =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                    module active =
                        let ``type`` = "boolean"

                    module type_ =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "display"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module display =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module name =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module partOf =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module contact =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module name =
                                    let ``type`` = "object"
                                    let required = [| "family"; "given" |]

                                    module properties =
                                        module family =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module given =
                                            let ``type`` = "array"

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    begin end

                                module telecom =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"

                                        module properties =
                                            module extension =
                                                let ``type`` = "array"
                                                let minItems = 1.0m
                                                let uniqueItems = true

                                                module items =
                                                    let ``type`` = "object"
                                                    let required = [| "url" |]

                                                    module properties =
                                                        module url =
                                                            let ``type`` = "string"
                                                            let minLength = 1.0m

                                                        module valueReference =
                                                            let ``type`` = "object"
                                                            let required = [| "reference" |]

                                                            module properties =
                                                                module reference =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

            module Organization_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "active"
                                           "contact"
                                           "extension"
                                           "id"
                                           "language"
                                           "meta"
                                           "name"
                                           "partOf"
                                           "resourceType"
                                           "text"
                                           "type" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module extension =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "url" |]

                                                module properties =
                                                    module url =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module valueReference =
                                                        let ``type`` = "object"
                                                        let required = [| "reference" |]

                                                        module properties =
                                                            module reference =
                                                                let ``type`` = "string"
                                                                let minLength = 1.0m

                                        module active =
                                            let ``type`` = "boolean"

                                        module type_ =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "display"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module display =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module name =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module partOf =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module contact =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module name =
                                                        let ``type`` = "object"
                                                        let required = [| "family"; "given" |]

                                                        module properties =
                                                            module family =
                                                                let ``type`` = "string"
                                                                let minLength = 1.0m

                                                            module given =
                                                                let ``type`` = "array"

                                                                module items =
                                                                    let ``type`` = "object"

                                                                    module properties =
                                                                        begin end

                                                    module telecom =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"

                                                            module properties =
                                                                module extension =
                                                                    let ``type`` = "array"
                                                                    let minItems = 1.0m
                                                                    let uniqueItems = true

                                                                    module items =
                                                                        let ``type`` = "object"
                                                                        let required = [| "url" |]

                                                                        module properties =
                                                                            module url =
                                                                                let ``type`` = "string"
                                                                                let minLength = 1.0m

                                                                            module valueReference =
                                                                                let ``type`` = "object"
                                                                                let required = [| "reference" |]

                                                                                module properties =
                                                                                    module reference =
                                                                                        let ``type`` = "string"
                                                                                        let minLength = 1.0m

            module PractitionerRole =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "active"
                       "code"
                       "extension"
                       "healthcareService"
                       "id"
                       "language"
                       "location"
                       "meta"
                       "organization"
                       "resourceType"
                       "specialty"
                       "text" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module extension =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "url" |]

                            module properties =
                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module valueReference =
                                    let ``type`` = "object"
                                    let required = [| "reference" |]

                                    module properties =
                                        module reference =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                    module active =
                        let ``type`` = "boolean"

                    module organization =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module code =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module specialty =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "display"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module display =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module location =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module healthcareService =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

            module PractitionerRole_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "active"
                                           "code"
                                           "extension"
                                           "healthcareService"
                                           "id"
                                           "language"
                                           "location"
                                           "meta"
                                           "organization"
                                           "resourceType"
                                           "specialty"
                                           "text" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module extension =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "url" |]

                                                module properties =
                                                    module url =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module valueReference =
                                                        let ``type`` = "object"
                                                        let required = [| "reference" |]

                                                        module properties =
                                                            module reference =
                                                                let ``type`` = "string"
                                                                let minLength = 1.0m

                                        module active =
                                            let ``type`` = "boolean"

                                        module organization =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module code =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module specialty =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "display"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module display =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module location =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module healthcareService =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

            module Practitioner =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "active"
                       "communication"
                       "extension"
                       "id"
                       "identifier"
                       "language"
                       "meta"
                       "name"
                       "qualification"
                       "resourceType"
                       "text" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module extension =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "url" |]

                            module properties =
                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module valueCodeableConcept =
                                    let ``type`` = "object"
                                    let required = [| "coding" |]

                                    module properties =
                                        module coding =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "code"; "system" |]

                                                module properties =
                                                    module system =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module code =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                    module identifier =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "system"; "value" |]

                            module properties =
                                module system =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module value =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module active =
                        let ``type`` = "boolean"

                    module name =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "family"; "text" |]

                            module properties =
                                module text =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module family =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module given =
                                    let ``type`` = "array"

                                    module items =
                                        let ``type`` = "object"

                                        module properties =
                                            begin end

                    module qualification =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module extension =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "url" |]

                                        module properties =
                                            module extension =
                                                let ``type`` = "array"
                                                let minItems = 1.0m
                                                let uniqueItems = true

                                                module items =
                                                    let ``type`` = "object"
                                                    let required = [| "url"; "valueCode" |]

                                                    module properties =
                                                        module url =
                                                            let ``type`` = "string"
                                                            let minLength = 1.0m

                                                        module valueCode =
                                                            let ``type`` = "string"
                                                            let minLength = 1.0m

                                            module url =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                module code =
                                    let ``type`` = "object"
                                    let required = [| "coding"; "text" |]

                                    module properties =
                                        module coding =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "display" |]

                                                module properties =
                                                    module display =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module text =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                module issuer =
                                    let ``type`` = "object"
                                    let required = [| "display" |]

                                    module properties =
                                        module display =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                    module communication =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

            module Practitioner_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "active"
                                           "communication"
                                           "extension"
                                           "id"
                                           "identifier"
                                           "language"
                                           "meta"
                                           "name"
                                           "qualification"
                                           "resourceType"
                                           "text" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module extension =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "url" |]

                                                module properties =
                                                    module url =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module valueCodeableConcept =
                                                        let ``type`` = "object"
                                                        let required = [| "coding" |]

                                                        module properties =
                                                            module coding =
                                                                let ``type`` = "array"
                                                                let minItems = 1.0m
                                                                let uniqueItems = true

                                                                module items =
                                                                    let ``type`` = "object"
                                                                    let required = [| "code"; "system" |]

                                                                    module properties =
                                                                        module system =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                                                        module code =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                        module identifier =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "system"; "value" |]

                                                module properties =
                                                    module system =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module value =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module active =
                                            let ``type`` = "boolean"

                                        module name =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "family"; "text" |]

                                                module properties =
                                                    module text =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module family =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module given =
                                                        let ``type`` = "array"

                                                        module items =
                                                            let ``type`` = "object"

                                                            module properties =
                                                                begin end

                                        module qualification =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module extension =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "url" |]

                                                            module properties =
                                                                module extension =
                                                                    let ``type`` = "array"
                                                                    let minItems = 1.0m
                                                                    let uniqueItems = true

                                                                    module items =
                                                                        let ``type`` = "object"
                                                                        let required = [| "url"; "valueCode" |]

                                                                        module properties =
                                                                            module url =
                                                                                let ``type`` = "string"
                                                                                let minLength = 1.0m

                                                                            module valueCode =
                                                                                let ``type`` = "string"
                                                                                let minLength = 1.0m

                                                                module url =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                    module code =
                                                        let ``type`` = "object"
                                                        let required = [| "coding"; "text" |]

                                                        module properties =
                                                            module coding =
                                                                let ``type`` = "array"
                                                                let minItems = 1.0m
                                                                let uniqueItems = true

                                                                module items =
                                                                    let ``type`` = "object"
                                                                    let required = [| "display" |]

                                                                    module properties =
                                                                        module display =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                                            module text =
                                                                let ``type`` = "string"
                                                                let minLength = 1.0m

                                                    module issuer =
                                                        let ``type`` = "object"
                                                        let required = [| "display" |]

                                                        module properties =
                                                            module display =
                                                                let ``type`` = "string"
                                                                let minLength = 1.0m

                                        module communication =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

            module Location =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "address"
                       "extension"
                       "hoursOfOperation"
                       "id"
                       "language"
                       "managingOrganization"
                       "meta"
                       "name"
                       "position"
                       "resourceType"
                       "status"
                       "telecom"
                       "text"
                       "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module extension =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "url" |]

                            module properties =
                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module valueCodeableConcept =
                                    let ``type`` = "object"
                                    let required = [| "coding" |]

                                    module properties =
                                        module coding =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "code"; "system" |]

                                                module properties =
                                                    module system =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module code =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                    module status =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module name =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module type_ =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module telecom =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "rank"; "system"; "value" |]

                            module properties =
                                module extension =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "url" |]

                                        module properties =
                                            module extension =
                                                let ``type`` = "array"
                                                let minItems = 1.0m
                                                let uniqueItems = true

                                                module items =
                                                    let ``type`` = "object"
                                                    let required = [| "url"; "valueCode" |]

                                                    module properties =
                                                        module url =
                                                            let ``type`` = "string"
                                                            let minLength = 1.0m

                                                        module valueCode =
                                                            let ``type`` = "string"
                                                            let minLength = 1.0m

                                            module url =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                module system =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module value =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module rank =
                                    let ``type`` = "number"

                    module address =
                        let ``type`` = "object"
                        let required = [| "city"; "line"; "postalCode"; "state" |]

                        module properties =
                            module line =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                            module city =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module state =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module postalCode =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module position =
                        let ``type`` = "object"
                        let required = [| "latitude"; "longitude" |]

                        module properties =
                            module longitude =
                                let ``type`` = "number"

                            module latitude =
                                let ``type`` = "number"

                    module managingOrganization =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module hoursOfOperation =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module daysOfWeek =
                                    let ``type`` = "array"

                                    module items =
                                        let ``type`` = "object"

                                        module properties =
                                            begin end

            module Location_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "address"
                                           "extension"
                                           "hoursOfOperation"
                                           "id"
                                           "language"
                                           "managingOrganization"
                                           "meta"
                                           "name"
                                           "position"
                                           "resourceType"
                                           "status"
                                           "telecom"
                                           "text"
                                           "type" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module extension =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "url" |]

                                                module properties =
                                                    module url =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module valueCodeableConcept =
                                                        let ``type`` = "object"
                                                        let required = [| "coding" |]

                                                        module properties =
                                                            module coding =
                                                                let ``type`` = "array"
                                                                let minItems = 1.0m
                                                                let uniqueItems = true

                                                                module items =
                                                                    let ``type`` = "object"
                                                                    let required = [| "code"; "system" |]

                                                                    module properties =
                                                                        module system =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                                                        module code =
                                                                            let ``type`` = "string"
                                                                            let minLength = 1.0m

                                        module status =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module name =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module type_ =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module telecom =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "rank"; "system"; "value" |]

                                                module properties =
                                                    module extension =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "url" |]

                                                            module properties =
                                                                module extension =
                                                                    let ``type`` = "array"
                                                                    let minItems = 1.0m
                                                                    let uniqueItems = true

                                                                    module items =
                                                                        let ``type`` = "object"
                                                                        let required = [| "url"; "valueCode" |]

                                                                        module properties =
                                                                            module url =
                                                                                let ``type`` = "string"
                                                                                let minLength = 1.0m

                                                                            module valueCode =
                                                                                let ``type`` = "string"
                                                                                let minLength = 1.0m

                                                                module url =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                    module system =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module value =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                                    module rank =
                                                        let ``type`` = "number"

                                        module address =
                                            let ``type`` = "object"
                                            let required = [| "city"; "line"; "postalCode"; "state" |]

                                            module properties =
                                                module line =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                                module city =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module state =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module postalCode =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module position =
                                            let ``type`` = "object"
                                            let required = [| "latitude"; "longitude" |]

                                            module properties =
                                                module longitude =
                                                    let ``type`` = "number"

                                                module latitude =
                                                    let ``type`` = "number"

                                        module managingOrganization =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module hoursOfOperation =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module daysOfWeek =
                                                        let ``type`` = "array"

                                                        module items =
                                                            let ``type`` = "object"

                                                            module properties =
                                                                begin end

            module Endpoint =
                let ``type`` = "object"
                let description = ""

                let required =
                    [| "active"
                       "category"
                       "extension"
                       "id"
                       "language"
                       "location"
                       "meta"
                       "providedBy"
                       "resourceType"
                       "specialty"
                       "text" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated"; "profile" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module profile =
                                let ``type`` = "array"

                                module items =
                                    let ``type`` = "object"

                                    module properties =
                                        begin end

                    module language =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module text =
                        let ``type`` = "object"
                        let required = [| "div"; "status" |]

                        module properties =
                            module status =
                                let ``type`` = "string"
                                let minLength = 1.0m

                            module div =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module extension =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "url" |]

                            module properties =
                                module extension =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "url" |]

                                        module properties =
                                            module url =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module valueCodeableConcept =
                                                let ``type`` = "object"
                                                let required = [| "coding" |]

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module active =
                        let ``type`` = "boolean"

                    module providedBy =
                        let ``type`` = "object"
                        let required = [| "reference" |]

                        module properties =
                            module reference =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module category =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module specialty =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"

                            module properties =
                                module coding =
                                    let ``type`` = "array"
                                    let minItems = 1.0m
                                    let uniqueItems = true

                                    module items =
                                        let ``type`` = "object"
                                        let required = [| "code"; "display"; "system" |]

                                        module properties =
                                            module system =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module code =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                                            module display =
                                                let ``type`` = "string"
                                                let minLength = 1.0m

                    module location =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "reference" |]

                            module properties =
                                module reference =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

            module Endpoint_search =
                let ``type`` = "object"
                let description = ""
                let required = [| "entry"; "id"; "link"; "meta"; "resourceType"; "total"; "type" |]

                module properties =
                    module resourceType =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module id =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module meta =
                        let ``type`` = "object"
                        let required = [| "lastUpdated" |]

                        module properties =
                            module lastUpdated =
                                let ``type`` = "string"
                                let minLength = 1.0m

                    module type_ =
                        let ``type`` = "string"
                        let minLength = 1.0m

                    module total =
                        let ``type`` = "number"

                    module link =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "relation"; "url" |]

                            module properties =
                                module relation =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module url =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                    module entry =
                        let ``type`` = "array"
                        let minItems = 1.0m
                        let uniqueItems = true

                        module items =
                            let ``type`` = "object"
                            let required = [| "fullUrl" |]

                            module properties =
                                module fullUrl =
                                    let ``type`` = "string"
                                    let minLength = 1.0m

                                module resource =
                                    let ``type`` = "object"

                                    let required =
                                        [| "active"
                                           "category"
                                           "extension"
                                           "id"
                                           "language"
                                           "location"
                                           "meta"
                                           "providedBy"
                                           "resourceType"
                                           "specialty"
                                           "text" |]

                                    module properties =
                                        module resourceType =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module id =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module meta =
                                            let ``type`` = "object"
                                            let required = [| "lastUpdated"; "profile" |]

                                            module properties =
                                                module lastUpdated =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module profile =
                                                    let ``type`` = "array"

                                                    module items =
                                                        let ``type`` = "object"

                                                        module properties =
                                                            begin end

                                        module language =
                                            let ``type`` = "string"
                                            let minLength = 1.0m

                                        module text =
                                            let ``type`` = "object"
                                            let required = [| "div"; "status" |]

                                            module properties =
                                                module status =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                                module div =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module extension =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "url" |]

                                                module properties =
                                                    module extension =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "url" |]

                                                            module properties =
                                                                module url =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module valueCodeableConcept =
                                                                    let ``type`` = "object"
                                                                    let required = [| "coding" |]

                                                                    module properties =
                                                                        module coding =
                                                                            let ``type`` = "array"
                                                                            let minItems = 1.0m
                                                                            let uniqueItems = true

                                                                            module items =
                                                                                let ``type`` = "object"
                                                                                let required = [| "code"; "system" |]

                                                                                module properties =
                                                                                    module system =
                                                                                        let ``type`` = "string"
                                                                                        let minLength = 1.0m

                                                                                    module code =
                                                                                        let ``type`` = "string"
                                                                                        let minLength = 1.0m

                                                    module url =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

                                        module active =
                                            let ``type`` = "boolean"

                                        module providedBy =
                                            let ``type`` = "object"
                                            let required = [| "reference" |]

                                            module properties =
                                                module reference =
                                                    let ``type`` = "string"
                                                    let minLength = 1.0m

                                        module category =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module specialty =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"

                                                module properties =
                                                    module coding =
                                                        let ``type`` = "array"
                                                        let minItems = 1.0m
                                                        let uniqueItems = true

                                                        module items =
                                                            let ``type`` = "object"
                                                            let required = [| "code"; "display"; "system" |]

                                                            module properties =
                                                                module system =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module code =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                                                module display =
                                                                    let ``type`` = "string"
                                                                    let minLength = 1.0m

                                        module location =
                                            let ``type`` = "array"
                                            let minItems = 1.0m
                                            let uniqueItems = true

                                            module items =
                                                let ``type`` = "object"
                                                let required = [| "reference" |]

                                                module properties =
                                                    module reference =
                                                        let ``type`` = "string"
                                                        let minLength = 1.0m

        module securitySchemes =
            module Basic =
                let ``type`` = "http"
                let scheme = "basic"

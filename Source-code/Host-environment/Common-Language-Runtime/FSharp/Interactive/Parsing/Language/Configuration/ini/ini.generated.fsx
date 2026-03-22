// last modified 1 April 2001 by John Doe
module ini =
    module owner =
        let name = "John Doe"
        let organization = "Acme Widgets Inc."
    // use IP address in case network name resolution is not working
    module database =
        let server = "192.0.2.62"
        let port = 143
        let file = "payroll.dat"

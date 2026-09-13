Package: Cambia.UriExtensions
Author: Steve Lautenschlager
Website: www.CambiaResearch.com
Platform: .NET 4.0 C# Class Library

Summary:
    * This package provides extension methods to the existing .NET Uri class which make extracting, modifying and 
      building URIs and their parts easier than ever.

Features: 
    * Extract parts and part combinations in consistent formats
    * Represent URLs in various standard forms
    * Get, set, drop query items
    * Get, set, drop path items
    * Get, set, drop page number items
    * Drop part methods - a set of fluent methods for dropping parts from the URI including user info, path, query, port etc.
        Can chain with other Drop and Set methods.
    * Set part methods - a set of fluent methods for setting parts of a URI including sheme, user info, host, port, path, 
        query, query items, fragments.  Can chain with other Drop and Set methods in a fluent way.
    * Extensive unit testing for high reliability

Documentation:
    * The .NET Uri Class and the Cambia.UriExtensions Nuget Package
        * https://www.cambiaresearch.com/articles/730004


LICENSE:
--------

The author retains copyright and grants you the right to use based on the following license:

    MS-Pl - Microsoft Public License

Allows for commerical use, modification, distribution, sublicensing.
Details: https://www.tldrlegal.com/l/mspl


CONTACT:
--------

Send comments, issues or feature requests to steve@cambiaresearch.com or submit via the contact form:
http://www.cambiaresearch.com/contact


CHANGE LOG:
-----------

v2.1.0 - 20180430 - Added fluency to most method calls on UriPath so that method calls can be chained.
V2.0.2 - 20160930 - The AntiXss Nuget dependency was not correctly linked.  Fixed.
V2.0.1 - 20160923 - Signed assembly with a strong name.
V2.0.0 - 20160923 - Changed query items to ALWAYS be case sensitive.  This is a potentially breaking change! Hence the new major version number.
                    Added UriPath class for working with segments and Path Items.
                    Added Path Item Uri extension methods
                    Added Page Uri extension methods to set, drop, ensure, get page number.  Special case of 
                      path item and query item. (See documentation URL for details.)
V1.0.3 - 20160916 - Fixed name of DLL.  No code changes.
V1.0.1 - 20160914 - First version




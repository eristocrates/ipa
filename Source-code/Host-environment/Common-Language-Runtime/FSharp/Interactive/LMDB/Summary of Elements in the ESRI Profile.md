# Appendix D—Summary of Elements in the ESRI Profile

The following table summarizes the elements in the ESRI Profile. It presents the long and short names of the elements in a hierarchical list. Additional columns indicate the elements whose values can be automatically synchronized by ArcCatalog, the elements whose values can be manually defined using editors provided with ArcCatalog, and which of the stylesheets provided with ArcCatalog can be used to examine the element's value(s). This table does not show production information such as whether or not an element is mandatory or how many times an element may be repeated. More detailed information about synchronization can be found in the technical paper Synchronization in ArcCatalog, which is available from ESRI's Online Support Center.

## Columns 1 and 2: Long Name and Short Name

Columns 1 and 2 contain the long and short names of each metadata element as defined in the FGDC standard and the ESRI Profile. Short names are used as the XML tags to represent the element in the metadata XML document that is created and maintained by ArcCatalog. These elements are arranged hierarchically to make their organization easier to follow. The compound elements Citation Information, Time Period Information, and Contact Information are reused in several places; they appear in a separate table.

- FGDC-defined elements are black.
- FGDC-defined elements that have been modified by the ESRI Profile are orange.
- ESRI-defined elements are light blue.
- Compound elements are bold. Compound elements contain individual elements.
- Individual elements are not bold. Individual elements contain values.
- A green asterisk (\*) in column 1 indicates that use of the element has changed between different versions of ArcCatalog.

## Column 3: Synchronized

Synchronization is the process by which ArcCatalog will automatically update an item's metadata with information derived from the item itself. Values in this column indicate whether or not the element's value can be synchronized.

- S: element's value can be synchronized. If these elements are removed, they will be added again the next time the metadata is synchronized.
- H: ArcCatalog adds hints to the metadata for the mandatory elements defined in the FGDC standard. The first time the metadata is synchronized, these elements are added to the metadata. They are only added if the element does not already exist in the metadata. If these elements are removed, they won't be added again. The value for these elements is a description of the information that should be added.
- Values for all other elements must be entered manually.

1. Hints are added to the metadata for mandatory elements. If there is more than one option for specifying the mandatory element, the hint is placed in one of the options. A different option may be used; if so, the hint should be removed from the element where it was added.

- The Time Period of Content element must contain date information. One of three options may be used to define the dates. The hint is placed in the Single Date/Time element.
- The Metadata Contact element must contain either the name of the person or organization to contact. Which one to use depends on whether the person or the organization is the primary contact. The hint is placed in the Contact Organization within the Contact Organization Primary element.

2. Bounding Coordinates are mandatory in FGDC standard. If the bounding coordinates can't be synchronized, either because the coordinate system is undefined or because the item is nonspatial, hints are placed within the elements.
3. The values of these elements were synchronized by ArcCatalog 8, but they are no longer synchronized in version 8.1 or later.

- SDE Connection Info and Network Resource Name in Distribution Information. This information is now recorded in the Online Linkage element as part of the item's Citation.
- Digital Transfer Information elements in Distribution Information. When we stopped synchronizing the above elements we also stopped synchronizing the elements Format Name, File Decompression Technique, and Access Instructions.
- Parameters describing some ESRI-supported projections that are not defined in the FGDC standard were placed into ESRI-defined group elements in version 8, but in versions 8.1 and later these elements are no longer used.

4. The values of these elements are synchronized by ArcCatalog in versions 8.1 and later but were not in version 8.

- Standard Attribute Definition and Attribute Definition Source will be added for ESRI-defined attribute columns, such as Shape and FID, and coverage columns such as FNODE and <coverage>#.
- Unrepresentable Domain element is also added for the attributes described above except for <coverage>- ID, which is by definition a user-defined ID column.
- With versions 8.1 and later, ESRI-supported projections that are not defined in the FGDC standard are described by placing the individual projection parameter elements into the FGDC-defined generic element Map Projection Parameters.
- At version 8.1 ESRI added support for some FGDC-defined projections; however, with 8.1 and later versions their parameter elements are placed into the Map Projection Parameters element rather than the appropriate specific group element for those projections.

## Column 4: Editable

Values in this column indicate whether or not the element's value can be edited manually.

- Y: element's value can be edited using the FGDC metadata editor provided by ArcCatalog.
- N: element's value is visible in the FGDC metadata editor but not editable.
- P: element's value can be edited using the Metadata Properties dialog box.
- All other elements are not visible in the FGDC metadata editor or the Metadata Properties dialog box provided with ArcCatalog.

## Column 5: Visible in Stylesheet

Values in this column indicate which stylesheets can be used to look at the element's value.

a. The contents of the Data element within the Enclosure element only appear in the FGDC and FGDC ESRI stylesheets if the enclosure is an image (i.e., if the Image check box was checked when the enclosure was added).
b. Geospatial Data Presentation Form is shown in the FGDC FAQ stylesheet separately from the rest of the dataset's Citation.
c. When viewing a Larger Work Citation in the FGDC FAQ stylesheet, the same citation elements will appear for the larger work as for the regular citation. That is, the following elements will not be shown for the larger work: Publication Time, File or Table Name, and Edition. As indicated above, Geospatial Data Presentation Form is not shown as part of the citation in this stylesheet.

- G: element's value can be viewed using the FGDC Geography Network stylesheet.
- Q: element's value can be viewed using the FGDC FAQ stylesheet.
- E: element's value can be viewed using the FGDC ESRI stylesheet.
- F: element's value can be viewed using the FGDC stylesheet.
- C: element's value can be viewed using the FGDC Classic stylesheet.
- All elements can be viewed using the XML stylesheet.

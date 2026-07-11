// https://www.w3.org/TR/xmlschema-0/
// just a sketch


// [<AttributeUsage(AttributeTargets.Method)>]
// type countryAttribute() =
//     inherit Attribute()
//     member val name = "country" with get, set
//     member val xsd_type = "NMTOKEN" with get, set
//     member val fixed_value = "US" with get, set
//
//
//
// (typeof<USAddress>
//     .GetMethod("country")
//     .GetCustomAttributes(true)[0]
// :?> countryAttribute)
//     .fixed_value


open System
open System.Reflection


#r "nuget: FSharp.UMX"
open FSharp.UMX

// Example
// The Purchase Order, po.xml
(*
<?xml version="1.0"?>
<purchaseOrder orderDate="1999-10-20">
   <shipTo country="US">
      <name>Alice Smith</name>
      <street>123 Maple Street</street>
      <city>Mill Valley</city>
      <state>CA</state>
      <zip>90952</zip>
   </shipTo>
   <billTo country="US">
      <name>Robert Smith</name>
      <street>8 Oak Avenue</street>
      <city>Old Town</city>
      <state>PA</state>
      <zip>95819</zip>
   </billTo>
   <comment>Hurry, my lawn is going wild!</comment>
   <items>
      <item partNum="872-AA">
         <productName>Lawnmower</productName>
         <quantity>1</quantity>
         <USPrice>148.95</USPrice>
         <comment>Confirm this is electric</comment>
      </item>
      <item partNum="926-AA">
         <productName>Baby Monitor</productName>
         <quantity>1</quantity>
         <USPrice>39.98</USPrice>
         <shipDate>1999-05-21</shipDate>
      </item>
   </items>
</purchaseOrder>
*)


// Example
// The Purchase Order Schema, po.xsd
(*
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema">

  <xsd:annotation>
    <xsd:documentation xml:lang="en">
     Purchase order schema for Example.com.
     Copyright 2000 Example.com. All rights reserved.
    </xsd:documentation>
  </xsd:annotation>

  <xsd:element name="purchaseOrder" type="PurchaseOrderType"/>

  <xsd:element name="comment" type="xsd:string"/>

  <xsd:complexType name="PurchaseOrderType">
    <xsd:sequence>
      <xsd:element name="shipTo" type="USAddress"/>
      <xsd:element name="billTo" type="USAddress"/>
      <xsd:element ref="comment" minOccurs="0"/>
      <xsd:element name="items"  type="Items"/>
    </xsd:sequence>
    <xsd:attribute name="orderDate" type="xsd:date"/>
  </xsd:complexType>

  <xsd:complexType name="USAddress">
    <xsd:sequence>
      <xsd:element name="name"   type="xsd:string"/>
      <xsd:element name="street" type="xsd:string"/>
      <xsd:element name="city"   type="xsd:string"/>
      <xsd:element name="state"  type="xsd:string"/>
      <xsd:element name="zip"    type="xsd:decimal"/>
    </xsd:sequence>
    <xsd:attribute name="country" type="xsd:NMTOKEN"
                   fixed="US"/>
  </xsd:complexType>

  <xsd:complexType name="Items">
    <xsd:sequence>
      <xsd:element name="item" minOccurs="0" maxOccurs="unbounded">
        <xsd:complexType>
          <xsd:sequence>
            <xsd:element name="productName" type="xsd:string"/>
            <xsd:element name="quantity">
              <xsd:simpleType>
                <xsd:restriction base="xsd:positiveInteger">
                  <xsd:maxExclusive value="100"/>
                </xsd:restriction>
              </xsd:simpleType>
            </xsd:element>
            <xsd:element name="USPrice"  type="xsd:decimal"/>
            <xsd:element ref="comment"   minOccurs="0"/>
            <xsd:element name="shipDate" type="xsd:date" minOccurs="0"/>
          </xsd:sequence>
          <xsd:attribute name="partNum" type="SKU" use="required"/>
        </xsd:complexType>
      </xsd:element>
    </xsd:sequence>
  </xsd:complexType>

  <!-- Stock Keeping Unit, a code for identifying products -->
  <xsd:simpleType name="SKU">
    <xsd:restriction base="xsd:string">
      <xsd:pattern value="\d{3}-[A-Z]{2}"/>
    </xsd:restriction>
  </xsd:simpleType>

</xsd:schema>
*)

type purchaseOrder = PurchaseOrderType
and [<Measure>] comment

and PurchaseOrderType =

    {

      shipTo: USAddress
      billTo: USAddress
      comment: string<comment> option
      items: Items
      orderDate: DateOnly

     }

and USAddress =
    {

      name: string<name>
      street: string<street>
      city: string<city>
      state: string<state>
      zip: decimal<zip>

     }
    member this.country: string<NMTOKEN> = % "US"

and [<Measure>] name
and [<Measure>] street
and [<Measure>] city
and [<Measure>] state
and [<Measure>] zip
and [<Measure>] NMTOKEN
and Items = Item array

and Item =
    {

      productName: string<productName>
      quantity: int<positiveInteger>
      USPrice: decimal<USPrice>
      comment: string<comment> option
      shipDate: DateOnly option
      partNum: string<SKU>

     }

and [<Measure>] productName
and [<Measure>] USPrice
and [<Measure>] positiveInteger
and [<Measure>] SKU









[<RequireQualifiedAccess>]
type Occurrence_Constraint =
    | minOccurs of int
    | maxOccurs of int
    | unbounded

[<RequireQualifiedAccess>]
type Value_Constraint<'Value> =
    | fixed_value of 'Value
    | default_value of 'Value

let alice's_address =
    {


      name = % "Alice Smith"
      street = % "123 Maple Street"
      city = % "Mill Valley"
      state = % "CA"
      zip = % 90952M

    }

let robert's_address =
    {


      name = % "Robert Smith"
      street = % "8 Oak Avenue"
      city = % "Old Town"
      state = % "PA"
      zip = % 95819M

    }

let Lawnmower =
    {

      partNum = % "872-AA"
      productName = % "Lawnmower"
      quantity = % 1
      USPrice = % 148.95M
      shipDate = None
      comment = Some(% "Confirm this is electric")

    }

let Baby_Monitor =
    {

      partNum = % "926-AA"
      productName = % "Baby Monitor"
      quantity = % 1
      USPrice = % 39.98M
      shipDate = Some(new DateOnly(1999, 5, 21))
      comment = None

    }

let test_order =

    {

      orderDate = new DateOnly(1999, 10, 20)
      shipTo = alice's_address
      billTo = robert's_address
      comment = Some(% "Hurry, my lawn is going wild!")
      items = [| Lawnmower; Baby_Monitor |]

    }

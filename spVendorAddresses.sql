USE [AdventureWorks2014]

go

CREATE PROC [dbo].[spVendorAddresses]
AS
select v.Name, v.PreferredVendorStatus ,a.AddressLine1, a.AddressLine2, a.City, sp.Name [State], cr.CountryRegionCode [Country], a.PostalCode
 from Purchasing.Vendor v
inner join Person.BusinessEntity be
on v.BusinessEntityID = be.BusinessEntityID
inner join
Person.BusinessEntityAddress bea
on bea.BusinessEntityID = be.BusinessEntityID
inner join
Person.[Address] a
on a.AddressID = bea.AddressID
inner join
Person.StateProvince sp
on sp.StateProvinceID = a.StateProvinceID
inner join
Person.CountryRegion cr 
on cr.CountryRegionCode = sp.CountryRegionCode

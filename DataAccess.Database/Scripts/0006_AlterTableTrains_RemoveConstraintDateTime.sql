USE RailwayManagerDb
BEGIN

ALTER TABLE Trains 
DROP CONSTRAINT DF__Trains__ArrivalD__2A4B4B5E;

ALTER TABLE Trains 
DROP CONSTRAINT DF__Trains__Departur__29572725;

ALTER TABLE Trains 
DROP CONSTRAINT DF__Trains__Duration__2B3F6F97

END
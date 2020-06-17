use NLHospital
go

--drop existing tables
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Admissions'
         )
  DROP TABLE Admissions;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Patients'
         )
  DROP TABLE Patients;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Logins'
         )
  DROP TABLE Logins;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Employees'
         )
  DROP TABLE Employees;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Beds'
         )
  DROP TABLE Beds;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Ward'
         )
  DROP TABLE Ward;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'BedType'
         )
  DROP TABLE BedType;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'ExtraRates'
         )
  DROP TABLE ExtraRates;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'EmployeeType'
         )
  DROP TABLE EmployeeType;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Specialities'
         )
  DROP TABLE Specialities;
--

--drop existing views
IF EXISTS(
  SELECT *
  FROM sys.views
  WHERE name = N'HospitalizedPatients'
         )
  DROP view HospitalizedPatients;
--
IF EXISTS(
  SELECT *
  FROM sys.views
  WHERE name = N'ScheduledSurgeries'
         )
  DROP view ScheduledSurgeries;
--
IF EXISTS(
  SELECT *
  FROM sys.views
  WHERE name = N'AdmissionsDetails'
         )
  DROP view AdmissionsDetails;
--
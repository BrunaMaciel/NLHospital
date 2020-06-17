-- BRUNA DE FREITAS MACIEL

IF NOT EXISTS(SELECT * FROM sys.databases
          WHERE name = N'NLHospital')
	CREATE DATABASE "NLHospital"
GO

USE NLHospital
go

create table Ward (
Name nvarchar(15) constraint pk_Ward primary key
);

create table BedType (
BedType nvarchar(15) constraint pk_BedType primary key
);

create table Beds (
ID nvarchar(4) constraint pk_Beds primary key,
BedType nvarchar(15) constraint fk_BedType references BedType (BedType) not null,
Ward nvarchar(15) constraint fk_BedWard references Ward (Name) not null,
Occupied bit not null
);

create table ExtraRates(
Name nvarchar(30) constraint pk_ExtraRates primary key,
DailyRate money not null
);

create table Patients(
HealthNumber nvarchar(15) constraint pk_Patients primary key,
FirstName nvarchar(30) not null,
LastName nvarchar(30) not null,
Birth datetime,
Gender char constraint ck_Gender check (Gender='F' OR Gender='M'),
Phone nvarchar(10),
Address nvarchar(50),
PostalCode nvarchar(7),
City nvarchar(30),
Province nvarchar(2),
InsuranceNumber nvarchar(15),
InsuranceCompany nvarchar(15),
NextOfKin nvarchar(30),
NextOfKinRelationship nvarchar(10)
);

create table EmployeeType(
Name nvarchar(15) constraint pk_EmployeeType primary key ,
);

create table Specialties(
Name nvarchar(15) constraint pk_EmployeeSpecialities primary key ,
);

create table Employees(
ID int constraint pk_Employees primary key ,
FName nvarchar(30) not null,
LName nvarchar(30) not null,
EType nvarchar(15) constraint fk_EType references EmployeeType (Name) not null,
Specialty nvarchar(15) constraint fk_EWard references Specialities (Name),
);

create table Logins(
Username nvarchar(20) constraint pk_Logins primary key,
Password nvarchar(30) not null,
EmployeeID int constraint fk_LoginEmployees references Employees (ID) not null
);

create table Admissions(
ID int constraint pk_Admissions primary key ,
PatientID nvarchar(15) constraint fk_AdmissionsPatient references Patients (HealthNumber) not null,
DoctorID int constraint fk_AdmissionsDoctor references Employees (ID),
Bed nvarchar(4) constraint fk_AdmissionsBed references Beds (ID) not null,
Ward nvarchar(15) constraint fk_AdmissionsWard references Ward(Name) not null,
AdmissionDate datetime not null,
SurgeryDate datetime,
DischargeDate datetime,
TV bit,
Phone bit,
SemiPrivate bit,
Private bit
);
use NLHospital
go

--WARD--
insert into Ward values ('Surgery');
insert into Ward values ('Pediatrics');
insert into Ward values ('Intensive Care');
insert into Ward values ('Cardiology');
insert into Ward values ('Maternity');
insert into Ward values ('Neurology');
go

--BedTypes--
insert into BedType values ('Ward');
insert into BedType values ('Semi-private');
insert into BedType values ('Private');


--Beds--
insert into Beds values ('S01', 'Ward', 'Surgery', 1);
insert into Beds values ('S02', 'Ward', 'Surgery', 0);
insert into Beds values ('S03', 'Semi-private', 'Surgery', 0);
insert into Beds values ('S04', 'Private', 'Surgery', 0);

insert into Beds values ('P01', 'Ward', 'Pediatrics', 1);
insert into Beds values ('P02', 'Ward', 'Pediatrics', 1);
insert into Beds values ('P03', 'Semi-private', 'Pediatrics', 0);
insert into Beds values ('P04', 'Private', 'Pediatrics', 0);

insert into Beds values ('I01', 'Ward', 'Intensive Care', 1);
insert into Beds values ('I02', 'Ward', 'Intensive Care', 1);
insert into Beds values ('I03', 'Semi-private', 'Intensive Care', 1);
insert into Beds values ('I04', 'Private', 'Intensive Care', 1);

insert into Beds values ('C01', 'Ward', 'Cardiology', 1);
insert into Beds values ('C02', 'Ward', 'Cardiology', 0);
insert into Beds values ('C03', 'Semi-private', 'Cardiology', 1);
insert into Beds values ('C04', 'Private', 'Cardiology', 0);

insert into Beds values ('M01', 'Ward', 'Maternity', 1);
insert into Beds values ('M02', 'Ward', 'Maternity', 0);
insert into Beds values ('M03', 'Semi-private', 'Maternity', 1);
insert into Beds values ('M04', 'Private', 'Maternity', 1);

insert into Beds values ('N01', 'Ward', 'Neurology', 1);
insert into Beds values ('N02', 'Ward', 'Neurology', 0);
insert into Beds values ('N03', 'Semi-private', 'Neurology', 1);
insert into Beds values ('N04', 'Private', 'Neurology', 1);

--ExtraRates--
insert into ExtraRates values ('Semi-private', 267);
insert into ExtraRates values ('Private', 571);
insert into ExtraRates values ('TV', 42.5);
insert into ExtraRates values ('Phone', 7.5);

--Patients--
insert into Patients values (1000,'Indiana','Jones','28-05-1981','M','5555555555','01-234 Street','A1B2C3','Montreal','QC','','Not insured','Julio Jones','Brother');
insert into Patients values (1001,'Bond','James','28-05-1962','M','5556666666','56-789 Street','D4E5F6','Montreal','QC','123456','Company A','','');
insert into Patients values (1002,'Solo','Han','28-05-1977','M','5557777777','12-345 Street','G7H8I9','Montreal','QC','7890123','Company B','Chewie','Friend');
insert into Patients values (1003,'Pulain','Amélie','28-05-2001','F','5558888888','67-890 Street','J0K1L2','Montreal','QC','456789','Company A','Jean Pierre','Father');
insert into Patients values (1004,'Everdeen','Katniss','28-05-2012','F','5557777777','12-345 Street','G7H8I9','Montreal','QC','1478523','Company B','Han Solo','Father');


--EmployeeType--
insert into EmployeeType values ('Doctor');
insert into EmployeeType values ('Nurse');
insert into EmployeeType values ('Admin');
insert into EmployeeType values ('Admission');

--Specialties--
insert into Specialties values ('General');
insert into Specialties values ('Pediatrics');
insert into Specialties values ('Cardiology');
insert into Specialties values ('Maternity');
insert into Specialties values ('Neurology');

--Employees--
insert into Employees values (1000,'Sarah','Connor','Doctor', 'Pediatrics');
insert into Employees values (1001,'Ace','Ventura','Nurse','General');
insert into Employees values (1002,'Bilbo ','Baggins','Admin','General');
insert into Employees values (1003,'Jason','Bourne','Admission','General');
insert into Employees values (1004,'Lisbeth','Salander','Doctor', 'Neurology');
insert into Employees values (1005,'Ethan','Hunt','Doctor', 'Cardiology');

--Logins--
insert into Logins values ('connorS','1234',1000);
insert into Logins values ('venturaA','1234',1001);
insert into Logins values ('baggingsB','1234',1002);
insert into Logins values ('bourneJ','1234',1003);
insert into Logins values ('salanderL','1234',1004);
insert into Logins values ('huntE','1234',1005);

--Admissions--
insert into Admissions (ID, PatientID, DoctorID,Bed,Ward,AdmissionDate,SurgeryDate, TV, Phone, SemiPrivate, Private)
values (1000,1000,1005,'S01','Surgery','28-05-2020','06-08-2020',0,0,0,0);
insert into Admissions (ID, PatientID, DoctorID,Bed,Ward,AdmissionDate, DischargeDate, TV, Phone, SemiPrivate, Private)
values (1001,1001,1005,'S02','Surgery','28-05-2020','29-05-2020',0,0,0,0);
insert into Admissions (ID, PatientID, DoctorID,Bed,Ward,AdmissionDate, DischargeDate, TV, Phone, SemiPrivate, Private)
values (1002,1002,1004,'N01','Neurology','01-01-2020','10-01-2020',1,1,0,0);
insert into Admissions (ID, PatientID, DoctorID,Bed,Ward,AdmissionDate, TV, Phone, SemiPrivate, Private)
values (1003,1003,1004,'N03','Neurology','01-01-2020',1,1,1,0);
insert into Admissions (ID, PatientID, DoctorID,Bed,Ward,AdmissionDate, TV, Phone, SemiPrivate, Private)
values (1004,1004,1000,'P04','Pediatrics','15-05-2020',1,1,0,1);



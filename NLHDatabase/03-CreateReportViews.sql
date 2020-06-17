use NLHospital
go

create view HospitalizedPatients as
select Admissions.ID as 'Admission ID', HealthNumber as 'Health Number', Patients.FirstName +' '+Patients.LastName as 'Name',
		Bed, Ward, AdmissionDate as 'Admission Date', DoctorID as 'Doctor ID', Employees.FName + ' '+Employees.LName as 'Doctor',
		SurgeryDate as 'Surgery Date'
from Admissions
join Patients on PatientID=HealthNumber
join Employees on Admissions.DoctorID=Employees.ID
where DischargeDate is null
go

create view AdmissionsDetails as
select Admissions.ID as 'Admission ID', HealthNumber as 'Health Number', Patients.FirstName +' '+Patients.LastName as 'Name',
		Bed, Ward, AdmissionDate as 'Admission Date', DoctorID as 'Doctor ID', Employees.FName + ' '+Employees.LName as 'Doctor',
		SurgeryDate as 'Surgery Date',DischargeDate as "Discharge Date" ,TV,Admissions.Phone
from Admissions
join Patients on PatientID=HealthNumber
join Employees on Admissions.DoctorID=Employees.ID
go

create view ScheduledSurgeries as
select Admissions.ID as 'Admission ID', HealthNumber as 'Health Number', Patients.FirstName +' '+Patients.LastName as 'Name',
		Bed, Ward, AdmissionDate as 'Admission Date', DoctorID as 'Doctor ID', Employees.FName + ' '+Employees.LName as 'Doctor',
		SurgeryDate as 'Surgery Date'
from Admissions
join Patients on PatientID=HealthNumber
join Employees on Admissions.DoctorID=Employees.ID
where DischargeDate is null AND SurgeryDate >= GETDATE()
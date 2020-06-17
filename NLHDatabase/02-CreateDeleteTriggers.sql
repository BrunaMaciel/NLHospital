use NLHospital
go

create trigger Patients_bd_trg
on Patients
instead of delete
as
print 'delete on Patients table disallowed'
go

create trigger Admissions_bd_trg
on Admissions
instead of delete
as
print 'delete on Admissions table disallowed'
go
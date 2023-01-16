Create table employee(id int primary key identity(1,1),name varchar(200), PhoneNumber bigint, Address varchar(200),Department varchar(200),Gender char,Basic_Pay bigint,
Deduction bigint, Taxable_pay bigint,Tax bigint,Net_Pay bigint,start_date date );

insert into employee values('Mahesh',7829303710,'Kolar','IT','M',2000,1000,180000,2000,250000,'10-11-2022');

create database Assignment_5
use Assignment_5


--1. Stored Procedure to Generate Employee Payslip
create table emp(empid int primary key, empname varchar(50), salary decimal(10,2));

insert into emp values
(101, 'Kumar', 30000),
(102, 'Arun', 25000),
(103, 'Aadhi', 40000),
(104, 'Dharani', 35000),
(105, 'Vijay', 28000);


create procedure sp_Generatepayslip( @empid int)
as
begin
    declare
        @empname varchar(50),
        @salary decimal(10,2),
        @hra decimal(10,2),
        @da decimal(10,2),
        @pf decimal(10,2),
        @it decimal(10,2),
        @deductions decimal(10,2),
        @grosssalary decimal(10,2),
        @netsalary decimal(10,2);

    select 
        @empname = empname,
        @salary = salary
    from emp
    where empid = @empid;

    if @salary is null
    begin
        print 'employee not found';
        return;
    end

    set @hra = @salary * 0.10;
    set @da  = @salary * 0.20;
    set @pf  = @salary * 0.08;
    set @it  = @salary * 0.05;

    set @deductions  = @pf + @it;
    set @grosssalary = @salary + @hra + @da;
    set @netsalary   = @grosssalary - @deductions;

    print '--------------------------------------';
    print '           employee payslip            ';
    print '--------------------------------------';
    print 'employee id     : ' + cast(@empid as varchar);
    print 'employee name   : ' + @empname;
    print '--------------------------------------';
    print 'basic salary    : ' + cast(@salary as varchar);
    print 'hra (10%)       : ' + cast(@hra as varchar);
    print 'da (20%)        : ' + cast(@da as varchar);
    print '--------------------------------------';
    print 'gross salary    : ' + cast(@grosssalary as varchar);
    print '--------------------------------------';
    print 'pf (8%)         : ' + cast(@pf as varchar);
    print 'it (5%)         : ' + cast(@it as varchar);
    print 'total deduction : ' + cast(@deductions as varchar);
    print '--------------------------------------';
    print 'net salary      : ' + cast(@netsalary as varchar);
    print '--------------------------------------';

    select
        @empid as empid,
        @empname as empname,
        @salary as basicsalary,
        @hra as hra,
        @da as da,
        @grosssalary as grosssalary,
        @pf as pf,
        @it as it,
        @deductions as totaldeductions,
        @netsalary as netsalary;
end;

select * from emp;

exec sp_Generatepayslip 101;
exec sp_generatepayslip 103;


--2. Trigger to Restrict EMP Table Manipulation on Holidays

create table holiday(holiday_date date primary key, holiday_name varchar(50));

insert into holiday values
('2026-08-23','My Birthday'),
('2026-01-26', 'Republic day'),
('2026-08-15', 'Independence day'),
('2026-10-20', 'Diwali'),
('2026-12-25', 'Christmas');

insert into holiday values('2026-05-01','Labour Day');
select * from holiday

create trigger trg_restrictemp_onholiday
on emp
after insert, update, delete
as
begin
    declare @holidayname varchar(50);
    select @holidayname = holiday_name
    from holiday
    where holiday_date = cast(getdate() as date);

    if @holidayname is not null
    begin
        raiserror (
            'due to %s you cannot manipulate data',
            16, 1, @holidayname
        );
        rollback transaction;
    end
end;

select cast(getdate() as date);

insert into holiday values
(cast(getdate() as date), 'test holiday');

select * from holiday;

update emp set salary = 36000 where empid = 101;
--Msg 50000, Level 16, State 1, Procedure trg_restrictemp_onholiday, Line 13 [Batch Start Line 129]
--due to test holiday you cannot manipulate data
--Msg 3609, Level 16, State 1, Line 130
--The transaction ended in the trigger. The batch has been aborted




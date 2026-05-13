create database EmployeeManagement;

use EmployeeManagement;

-- 2.Employee_details table
create table employee_details (
    empno int primary key,
    empname varchar(50) not null,
    empsal numeric(10,2) check (empsal >= 25000),
    emptype char(1) check (emptype in ('F', 'P'))
);

--Procedure 1
create procedure add_employee
    @empname varchar(50),
    @empsal numeric(10,2),
    @emptype char(1)
as
begin
    declare @new_empno int;
    select @new_empno = isnull(max(empno), 0) + 1 
    from employee_details;
    -- insert 
    insert into employee_details (empno, empname, empsal, emptype)
    values (@new_empno, @empname, @empsal, @emptype);
end;

exec add_employee 'John Wick', 80000, 'F';

select * from employee_details;

--Procedure 2
create procedure update_salary
    @empid int,
    @updated_salary numeric(10,2) output
as
begin
    -- update salary
    update employee_details
    set empsal = empsal + 100
    where empno = @empid;

    -- return updated salary
    select @updated_salary = empsal
    from employee_details
    where empno = @empid;
end;

--updated salary for emp1
declare @newsal numeric(10,2);

exec update_salary 
    @empid = 2, 
    @updated_salary = @newsal output;

select @newsal as updated_salary;

--updated salary for emp2
declare @newsal numeric(10,2);

exec update_salary 
    @empid = 3,
    @updated_salary = @newsal output;

select @newsal as updated_sal;
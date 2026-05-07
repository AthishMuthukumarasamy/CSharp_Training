create database CodeChallenge_6
use CodeChallenge_6

--QUERY 1
--Display birthday day of the week
select datename(weekday,'2004-08-23') as DayofWeek;

--QUERY 2
--Display your age in days
select datediff(day, '2004-08-23', getdate()) as AgeInDays;

use Assignment_2
select * from emp

--QUERY 3
--Display all employees information those who joined before 5 years in the current month
select *
from emp
where year(hiredate) <= year(getdate()) - 5 and month(hiredate) = month(getdate());

--QUERY 4
--Operations in Single transaction
create table employee2
(
    empno int,
    ename varchar(20),
    sal int,
    doj date
);

begin transaction;
-- a. insert 3 rows
insert into employee2 values (10, 'arun', 25000, '2021-06-15');
insert into employee2 values (20, 'bala', 35000, '2020-08-20');
insert into employee2 values (30, 'charan', 28000, '2019-02-10');
select * from employee2;

-- b. update second row salary with 15% increment
update employee2
set sal = sal + (sal * 15 / 100)
where empno = 20;
select * from employee2;

-- c. delete first row
delete from employee2
where empno = 10;
select * from employee2;

-- recall deleted row (re-insert)
insert into employee2 values (10, 'arun', 25000, '2021-06-15');
select * from employee2;

commit transaction;
select * from employee2;

--QUERY 5
use Assignment_2;
create or alter function fn_bonus
(
    @deptno int,
    @sal int
)
returns int
as
begin
    declare @bonus int;
    if (@deptno = 10)
        set @bonus = @sal * 15 / 100;
    else if (@deptno = 20)
        set @bonus = @sal * 20 / 100;
    else
        set @bonus = @sal * 5 / 100;

    return @bonus;
end;

select empno, ename, sal, deptno, dbo.fn_bonus(deptno, sal) as bonus from emp;


--QUERY 6
create procedure sp_updatesal_sales
as
begin
    update emp
    set sal = sal + 500
    where deptno = (select deptno from dept where dname = 'sales') and sal < 1500;
    print 'Salary updated for Sales dept employees with salary < 1500';

end;

select * from emp





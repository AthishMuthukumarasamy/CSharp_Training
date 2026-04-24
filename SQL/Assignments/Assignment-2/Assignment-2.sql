create database Assignment_2
use Assignment_2

create table dept (
    deptno int primary key,
    dname  varchar(14),
    loc    varchar(13)
);

-- emp table
create table emp (
    empno int primary key,
    ename varchar(10),
    job varchar(9),
    mgr int null,
    hiredate date,
    sal int,
    comm int null,
    deptno int,
    constraint fk_emp_dept foreign key (deptno)
        references dept(deptno)
);

--insert into dept
insert into dept (deptno, dname, loc)
values
(10, 'accounting', 'new york'),
(20, 'research',   'dallas'),
(30, 'sales',      'chicago'),
(40, 'operations', 'boston');

--insert into emp
insert into emp
(empno, ename, job, mgr, hiredate, sal, comm, deptno)
values
(7369,'smith','clerk',7902,'1980-12-17',800,null,20),
(7499,'allen','salesman',7698,'1981-02-20',1600,300,30),
(7521,'ward','salesman',7698,'1981-02-22',1250,500,30),
(7566,'jones','manager',7839,'1981-04-02',2975,null,20),
(7654,'martin','salesman',7698,'1981-09-28',1250,1400,30),
(7698,'blake','manager',7839,'1981-05-01',2850,null,30),
(7782,'clark','manager',7839,'1981-06-09',2450,null,10),
(7788,'scott','analyst',7566,'1987-04-19',3000,null,20),
(7839,'king','president',null,'1981-11-17',5000,null,10),
(7844,'turner','salesman',7698,'1981-09-08',1500,0,30),
(7876,'adams','clerk',7788,'1987-05-23',1100,null,20),
(7900,'james','clerk',7698,'1981-12-03',950,null,30),
(7902,'ford','analyst',7566,'1981-12-03',3000,null,20),
(7934,'miller','clerk',7782,'1982-01-23',1300,null,10);

select * from dept;
select * from emp;

--1.List all employees whose name begins with 'A'
select *
from emp
where ename like 'A%';

--2.Select all those employees who don't have a manager
select *
from emp
where mgr is null;

--3. Employee name, number and salary for employees earning between 1200 and 1400
select ename, empno, sal
from emp
where sal between 1200 and 1400;

--4. Give all employees in the RESEARCH department a 10% pay rise
--a)before update
select *
from emp
where deptno = (
    select deptno
    from dept
    where dname = 'RESEARCH'
);
--b)update
update emp
set sal = sal * 1.10
where deptno = (
    select deptno
    from dept
    where dname = 'RESEARCH'
);
--c)after update
select *
from emp
where deptno = (
    select deptno
    from dept
    where dname = 'RESEARCH'
);

--5. Find the number of CLERKS employed
select count(*) as number_of_clerks
from emp
where job = 'CLERK';

--6. Average salary and number of employees for each job
select job,
       avg(sal) as avg_salary,
       count(*) as total_employees
from emp
group by job;

--7. Employees with the lowest and highest salary
select *
from emp
where sal = (select min(sal) from emp)
   or sal = (select max(sal) from emp);

--8. Departments that don't have any employees
select *
from dept
where deptno not in (
    select distinct deptno
    from emp
);

--9. Analysts earning more than 1200 in department 20, ordered by name
select ename, sal
from emp
where job = 'ANALYST'
  and sal > 1200
  and deptno = 20
order by ename asc;

--10. Department name & number with total salary paid
select d.deptno, d.dname, sum(e.sal) as total_salary
from dept d
join emp e on d.deptno = e.deptno
group by d.deptno, d.dname;

--11. Salary of both MILLER and SMITH
select ename, sal
from emp
where ename in ('MILLER','SMITH');

--12. Employees whose names begin with ‘A’ or ‘M’
select *
from emp
where ename like 'A%'
   or ename like 'M%';

--13. Compute yearly salary of SMITH
select ename, sal * 12 as yearly_salary
from emp
where ename = 'SMITH';

--14. Employees whose salary is NOT between 1500 and 2850
select ename, sal
from emp
where sal not between 1500 and 2850;

--15. Managers who have more than 2 employees reporting to them
select mgr, count(*) as number_of_employees
from emp
where mgr is not null
group by mgr
having count(*) > 2;

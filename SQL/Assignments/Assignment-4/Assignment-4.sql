create database Assignment_4
use Assignment_4

-- 1. Factorial Program

declare @num int = 3;        
declare @fact int = 1;      
while @num > 0
begin
	set @fact = @fact * @num;
	set @num = @num - 1;
end
select @fact as factorial;

-- 2. Stored Procedure

create procedure Multi_Table(@num int, @limit int)
as
begin
	declare @i int = 1;
	while @i <= @limit
	begin
		select @num as Number,
			   @i as Multiplier,
		       @num * @i as Ans;
		set @i = @i + 1;
	end
end;

exec Multi_Table 3, 10;

--Status of the student

create table student
(
    sid int,
    sname varchar(20)
);

create table marks
(
    mid int,
    sid int,
    score int
);

insert into student values
(1, 'jack'),
(2, 'rithvik'),
(3, 'jaspreeth'),
(4, 'praveen'),
(5, 'bisa'),
(6, 'suraj');

insert into marks values
(1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13);

select * from student
select * from marks

create function Student_status(@score int)
returns varchar(10)

as
begin
    declare @status varchar(10);
    if @score >= 50
        set @status = 'pass';
    else
        set @status = 'fail';
    return @status;
end;

-- To display the data
select s.sid, s.sname, m.score, dbo.Student_status(m.score) as status
from student s
join marks m
on s.sid = m.sid;
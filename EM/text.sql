create user abdullah identified by a;
create user abd identified by a;
create user fawzi identified by f;
grant dba to abdullah;
grant dba to abd;
create role manger;
grant create table, create view , create sequence to manger;
grant manger to abdullah;
create role emplloyed;
create role supervisor;
grant select any table to supervisor ;

grant create session to manger;
grant create session to emplloyed;
grant create session to supervisor;
grant manger to abd;
grant supervisor to abd;
grant emplloyed to abd;
grant emplloyed to fawzi;
grant supervisor to fawzi;
 
create table type_jop (
jop_id number (10) not null ,
jop_name varchar2(15) not null,
constraint jop_id primary key(jop_id) );

create table emp_test (emp_id number (10) not null ,emp_name varchar2(20) not null
 , emp_phone number(12) ,emp_addres varchar2(40),jop_id number (10) not null ,
 constraint emp_id_pk primary key(emp_id) , 
constraint type_jop_fk foreign key (jop_id) references type_jop (jop_id));

create table vaction (
id_vac number(10) not null  primary key,    
id_emp number(10) not null,
star date not null,
end_vac date not null,
reason varchar2(20) not null,
constraint empfk foreign key (id_emp) references emp_test (emp_id)
);

create table absicen  (
id_absatt number(10) not null  primary key ,    
id_emp number(10) not null,
day_date date ,
abs_reas varchar2(50),
constraint audi_empfk foreign key (id_emp) references emp_test (emp_id)
);


 
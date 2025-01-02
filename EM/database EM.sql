create table emp (
id number not null primary key,
name varchar2(20) not null,
phone number not null,
addr varchar2(20),
email varchar2(20)
);

create table vac (
id_vac number not null,    
id_emp number not null,
star date not null,
end date not null,
reason varchar2(20) not null,
constraint emp foreign key (id_emp) references emp (id)
);

create table abs_att (
id_absatt number not null,    
id_emp number not null,
day_date date ,
att_date varchar2(20),
att_status varchar2(20) not null,
abs_reas varchar(50),
constraint audi_emp foreign key (id_emp) references emp (id)
);

--table driver
create table driver(
	driver_id int primary key,
	driver_name text not null,
	driver_surname text not null,
	driver_class int not null,
	driver_experience int not null
);
alter table driver add column car_id int; --references car(car_id);
alter table driver add constraint fk_car_driver_id foreign key(car_id) references car(car_id);
alter table driver add column employee_id int; --references employee(employee_id);
alter table driver add constraint fk_employee_driver_id foreign key(employee_id) references employee(employee_id);
select * from driver;
drop table driver cascade;
delete from driver where driver_id between 25 and 600;
--table car
create table car(
	car_id int primary key,
	car_mark text not null,
	car_model text not null,
	car_number text not null,
	car_load int not null,
	car_cargo_type text not null,
	car_condition int not null
);
select * from car;
drop table car cascade;
--table client
create table client(
	client_id int primary key,
	client_surname text not null,
	client_address text not null,
	client_phone text not null,
	client_order_date date not null,
	client_cargo text not null,
	client_destination_order text not null,
	client_price int not null
);
drop table client cascade;
select * from client;
alter table client drop constraint fk_car_client_id;
alter table client drop column car_id;
alter table client drop column driver_id;
delete from driver where driver_id between 25 and 600;
--table employees
create table employee(
	employee_id int primary key,
	employee_name text not null,
	employee_surname text not null,
	employee_address text not null,
	employee_date_of_birth date not null,
	employee_job text not null,
	employee_salary int not null,
	employee_hire_number text not null,
	employee_hire_date date not null
);
--alter table employee add column driver_id int;
--alter table employee add constraint fk_driver_employee_id foreign key(driver_id) references driver(driver_id);
select * from employee;
drop table employee cascade;
--orders
create table orders(
	order_id int primary key
);
alter table orders add column client_id int references client(client_id);
--alter table orders add constraint fk_client_orders_id foreign key(client_id) references client(client_id);
alter table orders add column driver_id int references driver(driver_id);
--alter table orders add references driver(driver_id);
select * from orders;
delete from orders where order_id between 11 and 400;
alter table orders drop constraint fk_driver_orders_id;
alter table orders add foreign key fk_driver_orders_id(driver_id) references driver(driver_id);
drop table orders cascade;
--user
--create role
create role user_u;
--create user
create user new_user with password '0000';
--revoke
revoke create on schema public from public;
revoke all on database car_service from public;
--grant
grant create on schema public to user_u;
grant create on database car_service to user_u;
grant connect on database car_service to user_u;
grant usage on schema public to user_u;
grant user_u to new_user;
grant select,insert,update,delete on table 
public.car, public.driver,public.employee,public.client,public.orders to new_user;
grant select,insert,update,delete on hibernate_sequence  to new_user;
--sequence
--CREATE SEQUENCE hibernate_sequence START WITH 1 INCREMENT BY 1;
--drop sequence hibernate_sequence;
--create sequence hibernate_sequence start with 15 increment by 1;
--grant usage, select on all sequences in schema public to new_user;
--drop sequence hibernate_sequence cascade;
--
--create sequence if not exists hibernate_sequence start with 21 increment by 1;
--alter table car alter column car_id set default nextval('hibernate_sequence ');
--grant select,insert,update,delete on hibernate_sequence  to new_user;
--
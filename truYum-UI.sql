create database truYumDB;
use truYumDB;

create table users(	id int primary key identity(1,1), name varchar(90) not null);

create table Menu_items (
										item_id int primary key identity(1,1) , 
										item_name varchar(50) not null,
										price float not null, 
										date_of_launch date not null, 
										category varchar(45),
										free_delivery tinyint
									);

create table Cart (
									Cart_id int primary key identity(1,1),
                                    users_id int foreign key references users(id)
                                );
						
create table Cart_invoice (
									Invoice_id int primary key identity(1,1),
                                    cart_id int not null references Cart,
                                    item_id int not null references Menu_items
                                    );
                                    
insert into Menu_items values('Sandwich', 99, '2016-09-01', 'Main Course', 1);
insert into Menu_items values('Burger', 129, '2015-03-09', 'Main Course', 1);
insert into Menu_items values('Pizza', 149, '2017-01-08', 'Main Course', 1);
insert into Menu_items values('French Fries', 49, '2017-03-05', 'Starters', 0);
insert into Menu_items values('Chocolate Brownie', 79, '2018-04-09', 'Dessert', 1);

select * from Menu_items;
select item_name from Menu_items where price > (select AVG(price) from Menu_items ); 

select * from users;
insert into users values('Souvik'), ('John');
-- insert into cart as you enter into users table
insert into Cart values(1), (2);

-- GET Menu items for customer 
select item_name, price, category, free_delivery from Menu_items
where date_of_launch < current_date();

select * from Cart_invoice;

delete from Cart_invoice where item_id = 2;

-- Place an item in customer cart 
insert into Cart_invoice(cart_id, item_id) values ((select Cart_id from Cart where users_id = 2), 2); -- Query to insert an item to cart 

-- Get all items in customer cart 
select m.item_name, m.price, m.free_delivery from Menu_items m 
join Cart_invoice c on m.item_id = c.item_id and c.cart_id in (select Cart_id from Cart where users_id = 2);

select c.Cart_id as Cart, ci.item_id as Item from Cart_invoice ci
join Cart c on c.Cart_id = ci.cart_id
order by c.Cart_id;

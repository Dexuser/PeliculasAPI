/*
    Cree una base de datos llamada Movies de antemano
    Este script es de SQL Server    
*/
use Movies;
create table Movies(
    id int identity(1,1),
    name varchar(100) not null,
    premiere_year smallint not null,
    genre varchar(50) not null,
    director varchar(100) not null,
    rating tinyint not null,
    poster_url varchar(200),
   oficial_trailer_url varchar(200),
    constraint CK_Movies_rating check (rating between 1 and 5),
    constraint PK_Movies_id primary key(id)
)
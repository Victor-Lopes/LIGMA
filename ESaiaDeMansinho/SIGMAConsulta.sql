select * from sys.types;

if(exists(select * from sys.databases where id = 'Ola'));
if DB_ID('dbLIGMA') is not null
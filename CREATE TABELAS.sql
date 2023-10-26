
CREATE TABLE funcionario(
CPF varchar(20) primary key,
Nome varchar(100) NOT NULL,
Endereço varchar(100) NOT NULL,
Bairro varchar(50) NOT NULL,
CEP varchar(50) NOT NULL,
Telefone varchar(50) NOT NULL,
Cidade varchar(50) NOT NULL,
UF char(2) NOT NULL
); 


CREATE TABLE dadostrabalhista(
Id int identity primary key,
Cargo varchar(50) NOT NULL,
Salariobase decimal(10,2) NOT NULL,
Horasdetrabalho int NOT NULL,
Insalubridade decimal(10,2) not null, 
Pis varchar(20) NOT NULL, 
Periculosidade bit NOT NULL, 
Dataadmissao varchar(20) NOT NULL, 
Datademissao varchar(20) NOT NULl,
CpfFunc varchar(20) foreign key references funcionario(CPF) on delete cascade
);


CREATE TABLE dadosFolha(
Id int identity primary key,
SalarioBase varchar(20) NOT NULL,
SalarioLiqui varchar(20) NOT NULL,
DescINSS varchar(20) NOT NULL,
DescIRRF varchar(20) NOT NULL,
AddPericulosidade varchar(20) NOT NULL, 
AddInsalubridade varchar(20) NOT NULL, 
HorasTrab varchar(20) NOT NULL, 
CpfFunc varchar(20) foreign key references funcionario(CPF) on delete cascade
);


CREATE TABLE usuario(
id int identity primary key,
usuario varchar(50) NOT NULL,
senha varchar(20) NOT NULL
);

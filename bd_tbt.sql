Create database Tomorrow_by_Together;
use Tomorrow_by_Together;

Create table Endereco(
	id_end int auto_increment,
	cep_end varchar(100),
	rua_end varchar(200),
	numero_end int,
	bairro_end varchar(100),
	cidade_end varchar(100),
	estado_end varchar(100)
);

create table equipamento (
    id_equi int primary key auto_increment,
    marca_equi varchar(100),
    tipo_equipamento_equi varchar(100),
    modelo_equi varchar(100),
    cor_equi varchar(100),
    preco_custo_equi float,
    referencia_equi varchar(100),
    descricao_equi varchar(250),
    valor_aluguel_equi float
);

Create table Cliente(
	id_cli int auto_increment,
    tipo_pessoa_cli varchar(200),
    telefone_cli varchar(20)
);

Create table Cliente_fisico(
	id_cli_fis int auto_increment,
	nome_cli_fis varchar(200),
	rg_cli_fis varchar(50),
	cpf_cli_fis varchar(50),
	data_nascimento_cli_fis date,
	estado_civil_cli_fis varchar(200),
	id_cli_fk int,
    foreign key (id_cli_fk) references Cliente(id_cli)
);

Create table Cliente_juridico (
    id_cli_jur int primary key auto_increment,
    razao_social_cli_jur varchar(200),
    nome_fantasia_cli_jur varchar(200),
    inscricao_estadual_cli_jur varchar(50),
    cnpj_cli_jur varchar(50),
    data_abertura_cli_jur date,
    id_cli_fk int,
    foreign key (id_cli_fk) references Cliente(id_cli)
);
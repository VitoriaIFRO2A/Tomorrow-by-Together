Create database Tomorrow_by_Together;
use Tomorrow_by_Together;

Create table Cliente(
	id_cli int primary key auto_increment,
    nome_cli varchar(200),
	cpf_cli varchar(200),
    telefone_cli varchar(200),
    estado_cli varchar(200),
    cidade_cli varchar(200),
    rua_cli varchar(200),
    numero_cli int,
    bairro_cli varchar(200)
);

create table funcionario(
	id_fun int primary key auto_increment,
    nome_fun varchar(200),
    data_nascimento_fun date,
	cpf_fun varchar(200),
    rg_fun varchar(200),
    sexo_fun varchar(200),
    funcao_fun varchar(200),
    telefone_fun varchar(200),
    email_fun varchar(200),
    estado_fun varchar(200),
    cidade_fun varchar(200),
    rua_fun varchar(200),
    numero_fun int,
    bairro_fun varchar(200)
);

create table login(
	id_login int primary key auto_increment,
	usuario_login varchar(200),
	senha_login varchar(200),
	id_fun_fk int,
    foreign key (id_fun_fk) references funcionario (id_fun)
);

create table fornecedor(
	id_for int primary key auto_increment,
	razao_social_for varchar(200),
	nome_fantasia_for varchar(200),
    telefone_for varchar(200),
    email_for varchar(200),
    estado_for varchar(200),
    cidade_for varchar(200),
    bairro_for varchar(200),
    numero_for int
);

create table produto(
	id_pro int primary key auto_increment,
	tipo_produto_pro varchar(200),
    marca_pro varchar(200),
    modelo_pro varchar(200),
    referencia_pro varchar(200),
    descricao_pro varchar(200),
    preco_custo_pro float,
    valor_aluguel_pro float,
    cor_pro varchar(200),
    id_for_fk int,
    foreign key (id_for_fk) references fornecedor (id_for)
);

create table venda(
	id_ven int primary key auto_increment,
    hora_ven time,
    data_ven date,
    id_fun_fk int,
    foreign key (id_fun_fk) references funcionario (id_fun),
    id_cli_fk int,
    foreign key (id_cli_fk) references cliente (id_cli)
);

create table venda_produto(
	id_ven_pro int primary key auto_increment,
	id_ven_fk int,
    foreign key (id_ven_fk) references venda (id_ven),
    id_pro_fk int,
    foreign key (id_pro_fk) references produto (id_pro)
);

insert into funcionario values (null, 'admin', null, null, null, null, 'admin', null, null, null, null, null, null, null);
insert into login values (1, 'admin', '1234', 1);
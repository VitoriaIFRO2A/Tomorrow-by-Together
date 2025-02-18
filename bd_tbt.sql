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
    rua_for varchar(200),
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
    data_ven date,
    id_fun_fk int,
    foreign key (id_fun_fk) references funcionario (id_fun),
    id_cli_fk int,
    foreign key (id_cli_fk) references cliente (id_cli),
    id_pro_fk int,
    foreign key (id_pro_fk) references produto (id_pro)
);



insert into login values (1, 'admin', '1234', null);

INSERT INTO Cliente (nome_cli, cpf_cli, telefone_cli, estado_cli, cidade_cli, rua_cli, numero_cli, bairro_cli)
VALUES 
('João Silva', '123.456.789-00', '(11) 98765-4321', 'São Paulo', 'São Paulo', 'Rua A', 100, 'Centro'),
('Maria Oliveira', '234.567.890-11', '(21) 91234-5678', 'Rio de Janeiro', 'Rio de Janeiro', 'Rua B', 200, 'Botafogo');

INSERT INTO funcionario (nome_fun, data_nascimento_fun, cpf_fun, rg_fun, sexo_fun, funcao_fun, telefone_fun, email_fun, estado_fun, cidade_fun, rua_fun, numero_fun, bairro_fun)
VALUES
('Carlos Souza', '1990-05-15', '111.222.333-44', 'MG123456', 'Masculino', 'Gerente', '(11) 12345-6789', 'carlos.souza@email.com', 'São Paulo', 'São Paulo', 'Rua X', 150, 'Vila Progresso'),
('Ana Lima', '1985-11-20', '555.666.777-88', 'SP987654', 'Feminino', 'Atendente', '(21) 98765-4321', 'ana.lima@email.com', 'Rio de Janeiro', 'Rio de Janeiro', 'Rua Y', 250, 'Lapa');

INSERT INTO fornecedor (razao_social_for, nome_fantasia_for, telefone_for, email_for, estado_for, cidade_for, bairro_for, rua_for, numero_for)
VALUES
('Empresa X LTDA', 'X Produtos', '(11) 33333-4444', 'contato@xprodutos.com.br', 'São Paulo', 'São Paulo', 'Jardim Paulista', 'Avenida Z', 500),
('Fornecedor Y S/A', 'Y Comércio', '(21) 44444-5555', 'contato@ycomercio.com.br', 'Rio de Janeiro', 'Rio de Janeiro', 'Centro', 'Rua W', 750);

INSERT INTO produto (tipo_produto_pro, marca_pro, modelo_pro, referencia_pro, descricao_pro, preco_custo_pro, valor_aluguel_pro, cor_pro, id_for_fk)
VALUES
('Cadeira', 'Marca X', 'Modelo 1', 'REF123', 'Cadeira de escritório confortável', 150.00, 50.00, 'Preta', 1),
('Mesa', 'Marca Y', 'Modelo 2', 'REF456', 'Mesa de madeira', 300.00, 100.00, 'Marrom', 2);

INSERT INTO venda (data_ven, id_fun_fk, id_cli_fk, id_pro_fk)
VALUES
('2025-02-17', 1, 1, 1),
('2025-02-18', 2, 2, 2);
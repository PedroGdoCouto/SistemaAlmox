CREATE DATABASE bd_login;
CREATE EXTENSION pgcrypto;

CREATE TABLE usuarios(
    /* idUsuario UUID DEFAULT gen_random_uuid() PRIMARY KEY, */
    cpfUsuario VARCHAR(14) PRIMARY KEY,
    nomeUsuario VARCHAR(200) NOT NULL,
    dataNascimento VARCHAR(10) NOT NULL,
    emailUsuario VARCHAR(200) UNIQUE NOT NULL,
    senhaUsuario VARCHAR(60) NOT NULL,
    tipoUsuario VARCHAR(10) NOT NULL
);

INSERT INTO usuarios
VALUES ('987.654.321-00', 'ADMINISTRADOR', '10/10/1950',
        'admin@adm.com', crypt('adm', gen_salt('bf', 8)), 'adm');

CREATE TABLE instituicoes(
    idInstituicao UUID DEFAULT gen_random_uuid() PRIMARY KEY,
    cnpjInstituicao VARCHAR(18) UNIQUE NOT NULL,
    razaoSocialInstituicao VARCHAR(200) UNIQUE NOT NULL,
    enderecoInstituicao VARCHAR NOT NULL
);

INSERT INTO instituicoes
VALUES (DEFAULT, '12.345.678/0009-00', 'SENAI CENTRO',
        'RUA NOME DA RUA - 15 - BAIRRO - CIDADE - UF - CEP');

CREATE TABLE materiais(
    idMaterial SERIAL PRIMARY KEY,
    nomeMaterial VARCHAR(200) NOT NULL,
    descricaoMaterial VARCHAR(200) NOT NULL,
    quantidadeMaterial INT NOT NULL,
    localizacaoMaterial VARCHAR(10) NOT NULL,
    chaveNotaFiscal VARCHAR(44) NOT NULL
);

INSERT INTO materiais
VALUES (DEFAULT, 'CANETA ESFEROGRAFICA', 'BIC COR PRETA', 15, 'A-1', '1234568894568951679861000048000898008798564'),
   (DEFAULT, 'CANETA ESFEROGRAFICA', 'BIC COR AZUL', 10, 'A-2', '1234568894568951679861000048000898008798564'),
   (DEFAULT, 'LAPIS COMUM', 'FABER CASTEL COR PRETO', 2, 'B-1', '1234568894568951679861000048000898008798564'),
   (DEFAULT, 'CANETA ESFEROGRAFICA', 'BIC COR VERMELHA', 5, 'A-3', '1234568894568951679861000048000898008798564');

CREATE TABLE registroEntrada(
    idRegistro SERIAL PRIMARY KEY,
    dataRegistro VARCHAR(10) NOT NULL,
    quantidadeEntrada INT NOT NULL,
    idMaterial INT REFERENCES materiais(idMaterial) NOT NULL,
    chaveNotaFiscal VARCHAR(44) NOT NULL
);

INSERT INTO registroEntrada
VALUES(DEFAULT, '19/11/1995', 15, 1, '1234567894568951679861000048000898008798564');

CREATE TABLE registroSaida(
    idRegistro SERIAL PRIMARY KEY,
    dataRegistro VARCHAR(10) NOT NULL,
    quantidadeRetirada INT NOT NULL,
    idMaterial INT REFERENCES materiais(idMaterial) NOT NULL,
    cnpjInstituicao VARCHAR(18) REFERENCES instituicoes(cnpjInstituicao) NOT NULL
);

INSERT INTO registroSaida
VALUES(DEFAULT, '23/11/1972', 5, 1, '12.345.678/0009-00');

CREATE TABLE historicoUsuario(
    idRegistro SERIAL PRIMARY KEY,
    dataRegistro VARCHAR(10) NOT NULL,
    operacao VARCHAR(10) NOT NULL,
    cpfUsuario VARCHAR(14) NOT NULL,
    nomeUsuario VARCHAR(200) NOT NULL
);

/* TESTE CLAUSES
SELECT *
FROM historicoUsuario;

DROP TABLE historicoUsuario;

SELECT count(*)
FROM usuarios
WHERE senhaUsuario = crypt('123456', senhaUsuario);

DROP TABLE registroEntrada;
TRUNCATE registroEntrada;
ALTER SEQUENCE materiais_idMaterial_seq RESTART;
ALTER SEQUENCE registroentrada_idregistro_seq RESTART;
ALTER SEQUENCE registrosaida_idregistro_seq RESTART;

SELECT tipoUsuario
FROM usuarios
WHERE emailUsuario = ('admin@adm.com') AND senhaUsuario = crypt(('adm123'), senhaUsuario);

SELECT cpfUsuario, substring(nomeUsuario FROM '[^ ]+'::text) AS nomeUsuario, emailUsuario
FROM usuarios;

SELECT idMaterial, nomeMaterial, descricaoMaterial, quantidadeMaterial, localizacaoMaterial
FROM materiais
WHERE idMaterial::text LIKE upper('');

UPDATE materiais
SET
    nomeMaterial = 'Caneta',
    descricaoMaterial = 'Descrição',
    quantidadeMaterial = 2,
    localizacaoMaterial = 'A-5'
WHERE idMaterial::text = '2';

/* Stored procedure */
CREATE FUNCTION registroSaida()
RETURNS TRIGGER AS $$
    BEGIN
        /* Indica a retirada do material
        IF (NEW.quantidadeMaterial < OLD.quantidadeMaterial) THEN
        END IF;
        */

    END;
    $$ LANGUAGE plpgsql;

/* Trigger de histórico */
CREATE TRIGGER registroSaida
    BEFORE INSERT OR UPDATE OR DELETE
    ON materiais
    FOR EACH ROW
    EXECUTE PROCEDURE registroSaida();

DROP FUNCTION registroSaida();
DROP TRIGGER registroSaida ON registroSaida;

SELECT dataRegistro FROM registroSaida WHERE idMaterial = 5 ORDER BY idRegistro DESC LIMIT 1;

SELECT concat(nomeMaterial, ' ', descricaoMaterial) FROM materiais ORDER BY idMaterial DESC LIMIT 1;

SELECT idMaterial, concat(substring(nomeMaterial FROM '[^ ]+'::text), ' ', descricaoMaterial) AS nomeMaterial, descricaoMaterial, quantidadeMaterial, localizacaoMaterial, chaveNotaFiscal FROM materiais WHERE idMaterial::text LIKE '%1%';

SELECT materiais.idMaterial,
       concat(substring(nomeMaterial FROM '[^ ]+'::text), ' ', descricaoMaterial) nomeMaterial,
       quantidadeMaterial,
       localizacaoMaterial,
       registroEntrada.dataRegistro dataEntrada,
       registroSaida.dataRegistro dataSaida,
       registroEntrada.chaveNotaFiscal
FROM materiais
JOIN registroEntrada ON registroEntrada.idMaterial = materiais.idMaterial
JOIN registroSaida ON registroSaida.idMaterial = materiais.idMaterial;

SELECT materiais.idMaterial,
       concat(substring(nomeMaterial FROM '[^ ]+'::text), ' ', descricaoMaterial) nomeMaterial,
       quantidadeMaterial,
       localizacaoMaterial,
       registroEntrada.dataRegistro dataEntrada,
       registroSaida.dataRegistro dataSaida,
       registroEntrada.chaveNotaFiscal
FROM materiais
JOIN registroEntrada ON registroEntrada.idMaterial = materiais.idMaterial
JOIN registroSaida ON registroSaida.idMaterial = materiais.idMaterial
WHERE nomeMaterial LIKE '%LAPIS%';

SELECT dataRegistro, operacao, cpfUsuario, (SELECT nomeUsuario FROM usuarios WHERE usuarios.cpfUsuario = historicoUsuario.cpfUsuario)
FROM historicoUsuario;

SELECT * FROM historicoUsuario;

SELECT dataRegistro, operacao, cpfUsuario, nomeUsuario FROM historicoUsuario WHERE cpfUsuario = '111.524.736-03';
*/
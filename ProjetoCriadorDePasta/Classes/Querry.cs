using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Security.AccessControl;
namespace ProjetoCriadorDePasta.Classes
{
    public class Querry
    {
        public void Cliente(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                    SELECT
	PESSOA.ID,
	'|',
	CASE WHEN PESSOA.TIPONATUREZA = 'F' THEN 1
	ELSE 2
	END,
	'|',
	CNPJCPF,
	'|',
	REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-',''),
	'|',
	CASE 
		WHEN LEN(PESSOA.PSEUDONIMO) < 2 THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
		WHEN PESSOA.PSEUDONIMO IS NULL THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
		WHEN PESSOA.PSEUDONIMO = '' THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
	ELSE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.PSEUDONIMO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
	END,
	'|',
	CONVERT(CHAR(10), PESSOA.DATANASCIMENTO, 103) AS DATANASCIMENTO,
	'|',
	PESSOA.INSCRICAOESTADUAL,
	'|',
	PESSOA.INSCRICAOMUNICIPAL,
	'|',
	REPLACE(REPLACE(REPLACE(COALESCE(PESSOA.OBSERVACAOINTERNA, ''), CHAR(10), ''), CHAR(13), ''), '|', ''),
	'|',
	COALESCE(CONTRIBUINTE.TIPOCONTRIBUINTENFEFISCAL, '1') AS CONTRIBUINTE,		
	'|',
	0 AS PERMITEAPROVEITAMENTOCREDITO,
	'|',
	CASE 
     WHEN PESSOA.ATIVO = 'true' THEN 1 
    ELSE 0 
     END AS ATIVO
FROM PESSOA
LEFT JOIN CONTRIBUINTE ON CONTRIBUINTE.ID = PESSOA.CONTRIBUINTEID
left join CADCLI on CADCLI.NOME = PESSOA.NOME
WHERE PESSOA.ID < 999999 ";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Cliente_Endereco(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                    SELECT
	PESSOA.ID,	
	'|',
	CASE WHEN LEN(ENDERECO.LOGRADOURO) < 2 THEN 'LOGRADOURO NAO INFORMADO' ELSE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(ENDERECO.LOGRADOURO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')END,	
	'|',
	COALESCE(ENDERECO.NUMERO, '0'),
	'|',
	REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(ENDERECO.COMPLEMENTO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-',''),
	'|',
	ENDERECO.CAIXAPOSTAL,
	'|',
	CASE
		WHEN ENDERECO.BAIRRO IS NULL THEN 'CENTRO' 
		WHEN LEN(ENDERECO.BAIRRO) < 2 THEN 'CENTRO'
		ELSE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(ENDERECO.BAIRRO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
	END,
	'|',
	CASE 
		WHEN ENDERECO.CEP IS NULL THEN '29900000'
		WHEN LEN(ENDERECO.CEP) < 8 THEN LEFT(RTRIM(ENDERECO.CEP) + '00000000', 8) 
		ELSE ENDERECO.CEP END,
	'|',
	COALESCE(ENDERECO.MUNICIPIOID, '3203205'),
	'|',
	CASE 
     WHEN ENDERECO.ATIVO = 'true' THEN 1 
    ELSE 0 
     END AS ATIVO 
FROM ENDERECO
JOIN PESSOA ON PESSOA.ENDERECOID = ENDERECO.ID left join CADCLI on CADCLI.NOME = PESSOA.NOME
WHERE PESSOA.ID < 999999

ORDER BY PESSOA.ID ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Cliente_Telefone(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT
	PESSOAID,
	'|',
	case TIPOTELEFONE
	when  9 then 2
	else TIPOTELEFONE 
	end as telefone,
	'|',
	TELEFONE,
	'|',
	case ATIVO when 'true' then 1 else 0 end as ativo
FROM PESSOATELEFONE
WHERE PESSOAID < 999999
ORDER BY PESSOAID ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Cliente_Email(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                  SELECT
	PESSOAID,
	'|',
	'0',
	'|',
	EMAIL,
	'|',
	case ATIVO when 'true' then 1 else 0 end as ativo
FROM PESSOAEMAIL
WHERE PESSOAID < 999999
ORDER BY PESSOAID ASC
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        /////////
        public void Fornecedor(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT
	PESSOA.ID - 1000000,
	'|',
	CASE WHEN PESSOA.TIPONATUREZA = 'F' THEN 1
	ELSE 2
	END,
	'|',
	PESSOA.CNPJCPF,
	'|',
	REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-',''),
	'|',
CASE 
		WHEN LEN(PESSOA.PSEUDONIMO) < 2 THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
		WHEN PESSOA.PSEUDONIMO IS NULL THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
		WHEN PESSOA.PSEUDONIMO = '' THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.NOME, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
	ELSE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(PESSOA.PSEUDONIMO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
	END,
	'|',
	CONVERT(CHAR(10), DATANASCIMENTO, 103) AS DATANASCIMENTO,
	'|',
	PESSOA.INSCRICAOESTADUAL,
	'|',
	PESSOA.INSCRICAOMUNICIPAL,
	'|',
	REPLACE(REPLACE(REPLACE(COALESCE(OBSERVACAOINTERNA, ''), CHAR(10), ''), CHAR(13), ''), '|', ''),
	'|',
	COALESCE(CONTRIBUINTE.TIPOCONTRIBUINTENFEFISCAL, 9),
	'|',
	CASE CADFOR.TIPO
		WHEN 'F' THEN 2
		WHEN 'S' THEN 1
		WHEN 'T' THEN 3
		WHEN 'I' THEN 4
		WHEN 'O' THEN 6
		ELSE 5
	END,
	'|',
	NULL AS HOMEPAGE,
	'|',
	CASE 
     WHEN PESSOA.ATIVO = 'true' THEN 1 
    ELSE 0 
     END AS ATIVO
FROM PESSOA
LEFT JOIN CONTRIBUINTE ON CONTRIBUINTE.ID = PESSOA.CONTRIBUINTEID
JOIN CADFOR ON CADFOR.FORNECEDOR + 1000000 = PESSOA.ID 
WHERE PESSOA.ID > 1000000 AND PESSOA.ID <= 2000000";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Fornecedor_Endereco(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                  SELECT
	PESSOA.ID - 1000000,	
	'|',
	CASE WHEN LEN(ENDERECO.LOGRADOURO) < 2 THEN 'LOGRADOURO NAO INFORMADO' ELSE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(ENDERECO.LOGRADOURO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')END,
	'|',
	COALESCE(ENDERECO.NUMERO, '0'),
	'|',
		REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(ENDERECO.COMPLEMENTO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-',''),
	'|',
	ENDERECO.CAIXAPOSTAL,
	'|',
	CASE
		WHEN ENDERECO.BAIRRO IS NULL THEN 'CENTRO' 
		WHEN LEN(ENDERECO.BAIRRO) < 2 THEN 'CENTRO'
		ELSE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
COALESCE(ENDERECO.BAIRRO, '')
,'Ç','C'),'Ñ','N'),'Ý','Y'),'Á','A'),'À','A'),'Â','A'),'Ã','A'),'Ä','A'),'É','E'),'È','E'),'Ê','E'),'Ë','E'),'Í','I'),'Ì','I'),'Î','I'),'Ï','I'),'Ó','O'),'Ò','O'),'Ô','O'),'Õ','O'),'Ö','O'),'Ú','U'),'Ù','U'),'Û','U'),'Ü','U'),'–',''),'-','')
	END,
	'|',
	CASE 
		WHEN ENDERECO.CEP IS NULL THEN '29900000'
		WHEN LEN(ENDERECO.CEP) < 8 THEN LEFT(RTRIM(ENDERECO.CEP) + '00000000', 8) 
		ELSE ENDERECO.CEP END,
	'|',
	COALESCE(ENDERECO.MUNICIPIOID, '3203205'),
	'|',
	case ENDERECO.ATIVO when 'TRUE' then 1 else 0 end
FROM ENDERECO
JOIN PESSOA ON PESSOA.ENDERECOID = ENDERECO.ID
WHERE PESSOA.ID >= 1000000 AND PESSOA.ID < 2000000
ORDER BY PESSOA.ID ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
                    }
        public void Fornecedor_Telefone(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                  SELECT
	PESSOAID - 1000000,
	'|',
	TIPOTELEFONE,
	'|',
	TELEFONE,
	'|',
	case ATIVO when 'TRUE' then 1 else 0 end
FROM PESSOATELEFONE
WHERE PESSOAID >= 1000000 AND PESSOAID < 2000000
ORDER BY PESSOAID ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Fornecedor_Email(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                  SELECT
	PESSOAID - 1000000,
	'|',
	'0',
	'|',
	EMAIL,
	'|',
	case ATIVO when 'TRUE' then 1 else 0 end
FROM PESSOAEMAIL
WHERE PESSOAID >= 1000000 AND PESSOAID < 2000000
ORDER BY PESSOAID ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Fornecedor_Contato(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                 SELECT
	FORNECEDOR,
	'|',
	CONTATO,
	'|',
	CONTATO_FONE,
	'|',
	CONTATO_E_MAIL,
	'|',
	CASE WHEN USU_EXC = 'FALSE' THEN 0 ELSE 1 END
FROM CADFOR
JOIN PESSOA ON PESSOA.ID = (CADFOR.FORNECEDOR + 1000000)
WHERE CONTATO <> '' AND CONTATO IS NOT NULL";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        //////////
       public void cest(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT
	CESTFISCAL.ID,
	'|',
	CESTFISCAL.NOME,
	'|',
	case CESTFISCAL.ATIVO when 'TRUE' then 1 else 0 end
FROM CESTFISCAL";

    SqlCommand command = new SqlCommand(query, cn);
    SqlDataReader reader = command.ExecuteReader();

    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i<reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void ncm(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT
	NCMFISCAL.ID,
	'|',
	NCMFISCAL.NOME,
	'|',
	case NCMFISCAL.ATIVO when 'TRUE' then 1 else 0 end 
FROM NCMFISCAL";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void cestxncm(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT
	CESTFISCAL_NCMFISCAL.CESTFISCALID,
	'|',
	CESTFISCAL_NCMFISCAL.NCMFISCALID,
	'|',
	case CESTFISCAL_NCMFISCAL.ATIVO when 'TRUE' then 1 else 0 end
FROM CESTFISCAL_NCMFISCAL";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void markup(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT
	ROW_NUMBER() OVER(ORDER BY DATA) + 1, /* Markup 1 ja existe no banco da web. O script 11.1 PRECOS PRODUTOS utiliza a mesma lógica desse arquivo para configurar o Markup */
	'|',
	CADMKP.NOME,
	'|',
	CADMKP.PERCENTUAL,
	'|',
	case CADMKP.ATIVO when 'true' then 1 else 0 end
FROM CADMKP";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Unidade(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT 
	  UNIDADEPRODUTO.ID,
	  '|',
	  UNIDADEPRODUTO.NOME,
	  '|',
	 case ATIVO when 'TRUE' then 1 else 0 end
FROM UNIDADEPRODUTO

";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Marca(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   SELECT 
	  FORMAR.ID,
	  '|',
	  FORMAR.DESCRICAO,
	  '|',
	  case FORMAR.ATIVO when 'true' then 1 else 0 end
FROM FORMAR
ORDER BY ID ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Grupo(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"
                   ----- ====== CRIA GRUPOS PADROES ====== ----
IF NOT EXISTS(SELECT [dbo].[ESTGRU].[ID] FROM [dbo].[ESTGRU] WHERE [dbo].[ESTGRU].[ID] = '99')
BEGIN
	INSERT INTO [dbo].[ESTGRU]
			   ([ID], [DESCRICAO], [COM_AVISTA], [COM_ENTRADA], [COM_APRAZO]
			   ,[COM_CHEQUE], [COM_CHEQUEPRE], [COM_CARTAO], [COM_ELECTRON], [COM_OUTROS]
			   ,[COM_FINANCEIRA], [LUCRO], [ADMITE_MOV], [DATA], [ATIVO], [EXPORTADO])
		 VALUES ('99','DEPARTAMENTO DIVERSOS'
			   ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0,'S', GETDATE(), 1, 1)
END

IF NOT EXISTS(SELECT [dbo].[ESTGRU].[ID] FROM [dbo].[ESTGRU] WHERE [dbo].[ESTGRU].[ID] = '9999')
BEGIN
	INSERT INTO [dbo].[ESTGRU]
			   ([ID], [DESCRICAO], [COM_AVISTA], [COM_ENTRADA], [COM_APRAZO]
			   ,[COM_CHEQUE], [COM_CHEQUEPRE], [COM_CARTAO], [COM_ELECTRON], [COM_OUTROS]
			   ,[COM_FINANCEIRA], [LUCRO], [ADMITE_MOV], [DATA], [ATIVO], [EXPORTADO])
		 VALUES ('9999','SETOR DIVERSOS'
			   ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0,'S', GETDATE(), 1, 1)
END

IF NOT EXISTS(SELECT [dbo].[ESTGRU].[ID] FROM [dbo].[ESTGRU] WHERE [dbo].[ESTGRU].[ID] = '9999999')
BEGIN
	INSERT INTO [dbo].[ESTGRU]
			   ([ID], [DESCRICAO], [COM_AVISTA], [COM_ENTRADA], [COM_APRAZO]
			   ,[COM_CHEQUE], [COM_CHEQUEPRE], [COM_CARTAO], [COM_ELECTRON], [COM_OUTROS]
			   ,[COM_FINANCEIRA], [LUCRO], [ADMITE_MOV], [DATA], [ATIVO], [EXPORTADO])
		 VALUES ('9999999','SECAO DIVERSOS'
			   ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0,'S', GETDATE(), 1, 1)
END

----- ====== DECLARACOES DE VARIAVEIS ====== ----

DECLARE @TABELASEQUENCIA TABLE(
	SEQ INT,
	DEPARTAMENTO VARCHAR(100),
	SETOR VARCHAR(100),
	SECAO VARCHAR(100),
	ID VARCHAR(100)
)

DECLARE @TABELAFINALGRUPO TABLE(
	SEQ INT,
	DESCRICAO VARCHAR(100),
	CODRELACIONAMENTO VARCHAR(100),
	HIERARQUIA VARCHAR(10)
)

----- ====== INSERT TABELA AUXILIAR DE SEQUENCIA DO GRUPO ====== ----

INSERT INTO @TABELASEQUENCIA (SEQ, DEPARTAMENTO, SETOR, SECAO, ID)
	SELECT
		ROW_NUMBER() OVER (ORDER BY LEN(ESTGRUSQ.ID), ESTGRUSQ.ID) + 3 AS SEQ /* +3 == GRUPOS PADRAO DO SISTEMA */
	   ,SUBSTRING(ESTGRUSQ.ID, 1, 2) AS DEPARTAMENTO
	   ,SUBSTRING(ESTGRUSQ.ID, 3, 2) AS SETOR
	   ,SUBSTRING(ESTGRUSQ.ID, 5, 3) AS SECAO
	   ,ESTGRUSQ.ID AS ID
	FROM ESTGRU AS ESTGRUSQ
	WHERE ESTGRUSQ.ID NOT IN('99', '9999', '9999999')

----- ====== INSERT NA TABELA FINAL DE GRUPO ====== ----

INSERT INTO @TABELAFINALGRUPO(SEQ, DESCRICAO, CODRELACIONAMENTO, HIERARQUIA)
	SELECT 1, ESTGRU.DESCRICAO, NULL, 1 FROM ESTGRU WHERE ESTGRU.ID = '99'
	UNION ALL
	SELECT 2, ESTGRU.DESCRICAO, 1, 2 FROM ESTGRU WHERE ESTGRU.ID = '9999'
	UNION ALL
	SELECT 3, ESTGRU.DESCRICAO, 2, 3 FROM ESTGRU WHERE ESTGRU.ID = '9999999'

INSERT INTO @TABELAFINALGRUPO(SEQ, DESCRICAO, CODRELACIONAMENTO, HIERARQUIA)
SELECT
	TABELASEQUENCIA.SEQ
   ,ESTGRU.DESCRICAO
   ,CASE LEN(ESTGRU.ID)
		WHEN 2 THEN NULL
		WHEN 4 THEN COALESCE(CAST((SELECT
					TABELASEQUENCIASQ.SEQ
				FROM @TABELASEQUENCIA AS TABELASEQUENCIASQ
				WHERE TABELASEQUENCIASQ.DEPARTAMENTO = TABELASEQUENCIA.DEPARTAMENTO
				AND REPLACE(TABELASEQUENCIASQ.SETOR, ' ', '') = ''
				AND REPLACE(TABELASEQUENCIASQ.SECAO, ' ', '') = '')
			AS VARCHAR(100)), 1)  /* 2 == DEPARTAMENTO DIVERSOS */

		ELSE COALESCE((SELECT
					TABELASEQUENCIASQ.SEQ
				FROM @TABELASEQUENCIA AS TABELASEQUENCIASQ
				WHERE TABELASEQUENCIASQ.DEPARTAMENTO = TABELASEQUENCIA.DEPARTAMENTO
				AND TABELASEQUENCIASQ.SETOR = TABELASEQUENCIA.SETOR
				AND REPLACE(TABELASEQUENCIASQ.SECAO, ' ', '') = '')
			, COALESCE((SELECT
					TABELASEQUENCIASQ.SEQ
				FROM @TABELASEQUENCIA AS TABELASEQUENCIASQ
				WHERE TABELASEQUENCIASQ.DEPARTAMENTO = TABELASEQUENCIA.DEPARTAMENTO
				AND REPLACE(TABELASEQUENCIASQ.SETOR, ' ', '') = ''
				AND REPLACE(TABELASEQUENCIASQ.SECAO, ' ', '') = ''), (2)) /* 2 == SETOR DIVERSOS */
			)
	END AS RELOBJWEBDB,
	CASE
		WHEN LEN(ESTGRU.ID) <= 2 THEN 1
		WHEN LEN(ESTGRU.ID) >= 3 AND LEN(ESTGRU.ID) <= 4 THEN 2
		WHEN LEN(ESTGRU.ID) >= 5 AND LEN(ESTGRU.ID) <= 7 THEN 3
	END
FROM ESTGRU
LEFT JOIN @TABELASEQUENCIA AS TABELASEQUENCIA
	ON TABELASEQUENCIA.ID = ESTGRU.ID
WHERE ESTGRU.ID NOT IN('99', '9999', '9999999')
ORDER BY LEN(ESTGRU.ID), ESTGRU.ID

--select * FROM @TABELAFINALGRUPO order by descricao
--select * From ESTGRU order by descricao
SELECT 
	SEQ,
	'|',
	DESCRICAO,
	'|',
	CODRELACIONAMENTO,
	'|',
	HIERARQUIA,
	'|',
	1
FROM @TABELAFINALGRUPO
ORDER BY SEQ ASC";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Grades(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT 
	LTRIM(RTRIM(GRADE)),
	'|',
	1
FROM ESTGRA
WHERE LEN(LTRIM(RTRIM(GRADE))) > 0
GROUP BY LTRIM(RTRIM(GRADE))
ORDER BY COUNT(*) DESC
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Produto(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT
	CADPRO.ID,
	'|',
	CADPRO.DESCRICAO,
	'|',
	CADPRO.REFERENCIA,
	'|',
	CADPRO.CODIGO_BARRA,
	'|',
	CADPRO.PESOV,
	'|',
	CADPRO.VOLUME,
	'|',
	CASE WHEN CSTICMSID = '060' THEN '0500'
		 WHEN CSTICMSID = '000' THEN '0102'
		 ELSE '0102'
	END,
	'|',
	0 AS MONOFASICO,
	'|',
	0 AS COMBUSTIVEL,
	'|',
	CASE CADPRO.ALTERAR_VALOR
		WHEN 'S' THEN 1
		ELSE '0'
	END AS ALTERAR_VALOR,
	'|',
	CASE CADPRO.UTILIZABALANCA
		WHEN 'S' THEN 1
		ELSE '0'
	END AS PESAVEL,
	'|',
	CADPRO.UNIDADEPRODUTOID,
	'|',
	--CADPRO.CODIGONCM,
	CASE WHEN LEN(LTRIM(RTRIM(COALESCE(CADPRO.CODIGONCM, '')))) > 0
		THEN CADPRO.CODIGONCM
		ELSE '12040090' --0025654582
	END AS NCMFISCALID, /* Em situacoes onde nao existe o NCMFISCALID Relacionado, utilizar esse codigo */
	'|',
	CADPRO.CESTFISCALID,
	'|',
	CADPRO.ANPFISCALID,
	'|',	
	ESTGRU.DESCRICAO,
	'|',
	CADPRO.MARCA,
	'|',
	CADPRO.GENEROFISCALID,
	'|',
	CADPRO.EXTIPIFISCALID,
	'|',
	case CADPRO.ATIVO when 'true' then 1 else 0 end
FROM CADPRO
JOIN ESTGRU ON ESTGRU.ID = CADPRO.GRUPO
WHERE CADPRO.ID > 1
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Saldo(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT 
	CADPRO.ID,
	'|',
	ESTSAL.FILIAL,
	'|',
	1 AS TABELAPRECO,
	'|',
	NULL, --TABELAMARKUP.CODIGOMARKUP AS MARKUP,
	'|',
	COALESCE(ESTSAL.VRVENDAV, 0),
	'|',
	COALESCE(ESTSAL.VRCOMPRAV, 0),
	'|',
	COALESCE(ESTSAL.VRCUSTOV, 0),
	'|',
	COALESCE(ESTSAL.VRZEROV, 0),
	'|',
	COALESCE(ESTSAL.VRMEDIOV, 0),
	'|',
	COALESCE(ESTSAL.LUCROV, 0),
	'|',
	case ESTSAL.ATIVO when 'true' then 1 else 0 end
 FROM CADPRO
 JOIN ESTSAL ON ESTSAL.MATRICULA = CADPRO.ID
 LEFT JOIN (
	SELECT
	ROW_NUMBER() OVER(ORDER BY DATA) + 1 AS CODIGOMARKUP /* Markup 1 ja existe no banco da web */, CADMKP.ID, CADMKP.NOME, CADMKP.PERCENTUAL, CADMKP.ATIVO FROM CADMKP
 ) AS TABELAMARKUP ON TABELAMARKUP.ID = ESTSAL.IDCADMKP
 WHERE CADPRO.ID > 1
 ORDER BY CADPRO.ID ASC
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void GradeProduto(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT 
	CADPRO.ID AS PRODUTOID, 
	'|',
	ESTSAL.FILIAL AS FILIALID,
	'|',
	CASE
		WHEN LEN(LTRIM(RTRIM(GRADE))) > 0
			THEN LTRIM(RTRIM(GRADE))
		ELSE 'U'
	END AS GRADE,
	'|',
	ESTGRA.ESTOQUEFISICO AS QUANTIDADE,
	'|',
	case ESTGRA.ATIVO when 'true' then 1 else 0 end
FROM CADPRO
JOIN ESTSAL ON ESTSAL.MATRICULA = CADPRO.ID
JOIN ESTGRA ON ESTGRA.IDESTSAL = ESTSAL.ID
WHERE CADPRO.ID > 1
ORDER BY PRODUTOID ASC
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void CodigoBarra(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT 
	ESTREL.ID,
	'|',
	ESTREL.MATRICULA,
	'|',
	CASE
		WHEN LEN(LTRIM(RTRIM(GRADE))) > 0
			THEN LTRIM(RTRIM(GRADE))
		ELSE 'U'
	END AS GRADE,
	'|',
	case ESTREL.ATIVO when 'true' then 1 else 0 end
FROM ESTREL
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void CodigoTerceiro(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT
	CODIGOTERCEIROPRODUTO.CADPROID,
	'|',
	CODIGOTERCEIROPRODUTO.CODIGOTERCEIRO,
	'|',
	CODIGOTERCEIROPRODUTO.CNPJCPF,	
	'|',
	case CODIGOTERCEIROPRODUTO.ATIVO when 'true' then 1 else 0 end
FROM CODIGOTERCEIROPRODUTO
WHERE CODIGOTERCEIROPRODUTO.ATIVO = 1
--AND CODIGOTERCEIROPRODUTO.CNPJCPF IN(SELECT CADFOR.CNPJ FROM CADFOR) /* Acrescentar essa clausula caso queira ignorar registros em que o CNPJ do Fornecedor nao existe na CADFOR */
ORDER BY CODIGOTERCEIROPRODUTO.CADPROID
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Clidoc(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT
	CAST(CLIDOC.FILIAL AS VARCHAR(100)),
	'| ',		-- Codigo da Filial
	CASE WHEN CADPOR.DEBITO = 'N' AND CADPOR.CREDITO = 'S' THEN '2' ELSE '1' END,			
	'| ',		-- Tipo do Documento 1 - Receber e 2 - Pagar
	CAST(CASE CLIDOC.CLIENTE WHEN 999999 THEN 406 ELSE COALESCE(CLIDOC.CLIENTE, 1) END AS VARCHAR(100)),			
	'| ',		-- Codigo do Cliente
	COALESCE(CLIDOC.CONTRATO, 0),		
	'| ',		-- Numero do Documento
	COALESCE(CLIDOC.PARCELA, ''),		
	'| ',		-- Numero da Parcela
	CONVERT(VARCHAR(100), CLIDOC.DT_EMISSAO, 103),			
	'| ',		-- Data de Emissao
	CONVERT(VARCHAR(100), CLIDOC.DT_VENCIMENTO, 103),			
	'| ',		-- Data de Vencimento
	CONVERT(VARCHAR(100), CLIDOC.DT_PAGAMENTO, 103),		
	'| ',		-- Data de Baixa
	CONVERT(VARCHAR(100), CLIDOC.DT_PRORROGACAO, 103),			
	'| ',		-- Data de Prorrogacao
	CAST(COALESCE(CLIDOC.VR_PARCELA, 0) AS VARCHAR(100)),			
	'| ',		-- Valor da Parcela
	COALESCE(CLIDOC.VR_JUROS, 0),			
	'| ',		-- Valor de Juros
	COALESCE(CLIDOC.VR_MULTA, 0),			
	'| ',		-- Valor de Multa
	COALESCE(CLIDOC.VR_DESCONTO, 0),			
	'| ',		-- Valor de Desconto
	COALESCE(VR_PAGO, 0) + COALESCE(VR_JUROS, 0) + COALESCE(VR_MULTA, 0) - COALESCE(VR_DESCONTO, 0),			
	'| ',		-- Valor Baixado
	COALESCE(CAST(CLIDOC.NOTA_FISCAL AS VARCHAR(100)), 'NULL'),		
	'| ',		-- Numero da Nota Fiscal ou Cupom Fiscal
	COALESCE(CAST(CLIDOC.FATURA AS VARCHAR(20)), ''),			
	'| ',		-- Numero da Fatura
	CAST(COALESCE(CLIDOC.DUPLICATA, '') AS VARCHAR(20)),			
	'| ',		-- Numero da Duplicat
	REPLACE(REPLACE(COALESCE(CLIDOC.TEXTO, ''), CHAR(13), ''), CHAR(10), ''),			
	'| ',		-- Observacoes
	case CLIDOC.ATIVO when 'true' then 1 else 0 end
				-- Ativo

FROM CLIDOC 
LEFT JOIN CADPOR ON CADPOR.PORTADOR = CLIDOC.PORTADOR
WHERE CLIDOC.VR_PARCELA > COALESCE(CLIDOC.VR_PAGO, 0) AND CLIDOC.ATIVO = 1
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
       public void Fordoc(string LocalDiretorio)
        {
            try
            {
                // Verificar se o diretório existe e garantir permissões
                string directory = Path.GetDirectoryName(LocalDiretorio);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    string query = @"SELECT
	CAST(FORDOC.FILIAL AS VARCHAR(100)),
	'| ',		-- Codigo da Filial
	CASE WHEN CADPOR.DEBITO = 'N' AND CADPOR.CREDITO = 'S' THEN '1' ELSE '2' END,			
	'| ',		-- Tipo do Documento 1 - Receber e 2 - Pagar
	FORDOC.FORNECEDOR ,			
	'| ',		-- Codigo do Cliente
	COALESCE(FORDOC.DOCUMENTO, 0),		
	'| ',		-- Numero do Documento
	COALESCE(FORDOC.PARCELA, ''),		
	'| ',		-- Numero da Parcela
	CONVERT(VARCHAR(100), FORDOC.DT_EMISSAO, 103),			
	'| ',		-- Data de Emissao
	CONVERT(VARCHAR(100), FORDOC.DT_VENCIMENTO, 103),			
	'| ',		-- Data de Vencimento
	CONVERT(VARCHAR(100), FORDOC.DT_PAGAMENTO, 103),		
	'| ',		-- Data de Baixa
	CONVERT(VARCHAR(100), FORDOC.DT_PRORROGACAO, 103),			
	'| ',		-- Data de Prorrogacao
	CAST(COALESCE(FORDOC.VR_PARCELA, 0) AS VARCHAR(100)),			
	'| ',		-- Valor da Parcela
	COALESCE(FORDOC.VR_JUROS, 0),			
	'| ',		-- Valor de Juros
	COALESCE(FORDOC.VR_MULTA, 0),			
	'| ',		-- Valor de Multa
	COALESCE(FORDOC.VR_DESCONTO, 0),			
	'| ',		-- Valor de Desconto
	COALESCE(VR_PAGO, 0) + COALESCE(VR_JUROS, 0) + COALESCE(VR_MULTA, 0) - COALESCE(VR_DESCONTO, 0),			
	'| ',		-- Valor Baixado
	COALESCE(CAST(FORDOC.NOTA_FISCAL AS VARCHAR(100)), 'NULL'),		
	'| ',		-- Numero da Nota Fiscal ou Cupom Fiscal
	'',			
	'| ',		-- Numero da Fatura
	CAST(COALESCE(FORDOC.DUPLICATA, '') AS VARCHAR(20)),			
	'| ',		-- Numero da Duplicat
	REPLACE(REPLACE(COALESCE(FORDOC.TEXTO, ''), CHAR(13), ''), CHAR(10), ''),			
	'| ',		-- Observacoes
	CASE COALESCE(FORDOC.USU_EXC, 0) WHEN 'false' THEN 1 ELSE 0 END
				-- Ativo

FROM FORDOC 
LEFT JOIN CADPOR ON CADPOR.PORTADOR = FORDOC.PORTADOR
WHERE FORDOC.VR_PARCELA > COALESCE(FORDOC.VR_PAGO, 0) AND CASE COALESCE(FORDOC.USU_EXC, 0) WHEN 0 THEN 1 ELSE 0 END = 1
";

                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder resultStringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultStringBuilder.Append(reader[i].ToString());
                        }
                        resultStringBuilder.AppendLine(); // Nova linha para cada registro
                    }

                    File.WriteAllText(LocalDiretorio, resultStringBuilder.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        //querrys pra funfar com
    }
}


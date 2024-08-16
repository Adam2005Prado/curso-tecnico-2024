
using Minha_Parte_Biblio.Modelo;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usuario;

namespace Minha_Parte_Biblio.Controle
{
    internal class ClUsercontrole
    {
         ClConnection conexao = new ClConnection();

        public bool SignUp(ClUserModelo Perfil)
        {
            bool Resultado = false;

            try
            {

                String SQL_Insert = "insert into Table_User(ID_Aluno, Nome_Completo, NameUser, Senha, IMG_User, CFK_Ano, CFK_Cargo,CFK_Unidade)values(@ID_Aluno, @Nome_Completo, @UserName, @Password, @IMG_User, @CFK_Ano, @CFK_Cargo,@CFK_Unidade)";

                string[] campos = {"@ID_Aluno", "@Nome_Completo", "@UserName", "@Password", "@IMG_User", "@CFK_Ano", "@CFK_Cargo", "@CFK_Unidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { Perfil.ID_Aluno.ToString(), Perfil.NomeComp.ToString(), Perfil.UserName.ToString(), Perfil.Password.ToString(), Perfil.Caminho_FT.ToString(), Perfil.Index_Ano.ToString(), Perfil.Index_Cargo.ToString() };

                //testar o insert no banco de dados
                if (conexao.cadastrar(0, campos, valores, SQL_Insert, "@ID_Aluno") >= 1)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
                 bool editar(ClUserModelo usuario)
                {
                    bool resultado = false;
                    try
                    {


                        //monta o script sql de cadastrar as informações no banco
                        string sql = "update Table_User set ID_Aluno=@ID_Aluno, NameUser=@NameUser, Nome_Completo=@Nome_Completo, Senha=@Senha, CFK_Cargo=@CFK_Cargo, CFK_Unidade =@CFK_Unidade, CFK_Ano=@CFK_Ano where ID_Aluno=@ LIMIT 1;";
                        //monto o vetor de atributos da tabela usuario
                        string[] ID_Aluno = { "@ID_Aluno","@NameUser", "@Nome_Completo", "@Senha", "@CFK_Cargo", "@CFK_Unidade", "@CFK_Ano" };
                        //monto o vetor com os valores do formulario
                        string[] valores = { usuario.ID_Aluno, usuario.UserName, usuario.Password, usuario.Index_Cargo.ToString(), usuario.Index_Ano.ToString(), usuario.Index_Unidade.ToString() };
                        //testar o insert no banco de dados
                        if (conexao.cadastrar(0, campos, valores, sql, "@ID_Aluno") >= 1)

                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = false;
                        }
                        return resultado;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.ToString());
                    }
                }

            }
            catch(Exception ex) 
            {
                throw new Exception(ex.ToString());
            }


            return Resultado;
        }

    }
}

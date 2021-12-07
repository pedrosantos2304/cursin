using cursos.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursos.Model
{
    class cursin
    {
        public int codigo { get; set; }
        public string turma { get; set; }
        public string cursos { get; set; }
        public string professores { get; set; }


        public Conexao con;

        public cursin()
        {
            con = new Conexao();
        }

        public void Criar()
        {
            try
            {
                con.ExecutarComando($"INSERT INTO `informacoes`(`codigo`, `turmas`, `professores`, `cursos`) VALUES(null,'{turma}','{professores}','{cursos}')");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de cadastrar um estabelecimento " + e.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return con.ExecutarConsulta($"SELECT * FROM `informacoes`");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de listar os estabelecimentos " + e.Message);
            }
        }
    }
}

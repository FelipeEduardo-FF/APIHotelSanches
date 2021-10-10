using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOFuncionario
    {
        List<Funcionario> funcionarios;
        Funcionario funcionario;

        public DAOFuncionario()
        {
            funcionarios = new List<Funcionario>();
            funcionario = new Funcionario();
        }

        public void CreateFuncionario(Funcionario funcionario)
        {
            var context = new Db_HotelContext();
            context.Funcionarios.Add(funcionario);
            context.SaveChanges();
        }

        public void UpdateFuncionario(Funcionario funcionario,int Id)
        {
            var context = new Db_HotelContext();
            var Dbfuncionario = context.Funcionarios.FirstOrDefault(Fn => Fn.IdFuncionario == Id);
            Dbfuncionario.DataContratacao = funcionario.DataContratacao;
            Dbfuncionario.IdFuncao = funcionario.IdFuncao;
            Dbfuncionario.SalarioFuncionario = funcionario.SalarioFuncionario;
            context.SaveChanges();
    }

        public List<Funcionario> GetFuncionarios()
        {
            var context = new Db_HotelContext();
            funcionarios.AddRange(context.Funcionarios.Where(Fn => Fn.IdFuncionario != 0));
            return funcionarios;
        }

        public Funcionario GetFuncionarioById(int Id)
        {
            var context = new Db_HotelContext();
            funcionario=context.Funcionarios.FirstOrDefault(Fn => Fn.IdFuncionario == Id);
            return funcionario;
        }
    }
}

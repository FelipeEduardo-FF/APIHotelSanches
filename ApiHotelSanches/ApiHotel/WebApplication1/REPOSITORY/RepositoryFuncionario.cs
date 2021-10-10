using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryFuncionario
    {

        DAOFuncionario daoFuncionario;
        public RepositoryFuncionario()
        {
            daoFuncionario = new DAOFuncionario();
        }

        public void CreateFuncionario(Funcionario funcionario)
        {
            daoFuncionario.CreateFuncionario(funcionario);
        }

        public void UpdateFuncionario(Funcionario funcionario, int Id)
        {
            daoFuncionario.UpdateFuncionario(funcionario, Id);
        }
        public string GetFuncionario()
        {
            var dataJson = JsonSerializer.Serialize(daoFuncionario.GetFuncionarios());
            return dataJson;
        }

        public string GetFuncionarioById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daoFuncionario.GetFuncionarioById(Id));
            return dataJson;
        }
    
}
}

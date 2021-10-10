using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOFuncao
    {
        List<TbFuncao> funcoes;
        TbFuncao funcao;

        public DAOFuncao(){
            funcoes = new List<TbFuncao>();
            funcao = new TbFuncao();
        }

        public void CreateFuncao(TbFuncao funcao)
        {
            var context = new Db_HotelContext();
            context.Funcaos.Add(funcao);
            context.SaveChanges();
        }

        public void UpdateFuncao(TbFuncao funcao, int Id)
        {
            var context = new Db_HotelContext();
            var DbFuncao= context.Funcaos.FirstOrDefault(Fc => Fc.IdFuncao == Id);
            DbFuncao.Funcao = funcao.Funcao;
            DbFuncao.DescricaoFuncao = funcao.DescricaoFuncao;
            context.SaveChanges();
        }
        public List<TbFuncao> GetFuncoes()
        {
            var context = new Db_HotelContext();
            funcoes.AddRange(context.Funcaos.Where(Fc => Fc.IdFuncao != 0).ToList());
            return funcoes;
        }

        public TbFuncao GetFuncaobyID(int Id)
        {
            var context = new Db_HotelContext();
            funcao = context.Funcaos.FirstOrDefault(Fc => Fc.IdFuncao == Id);
            return funcao;
        }
    }
}

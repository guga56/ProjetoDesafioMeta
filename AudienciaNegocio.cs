using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMetaDesafio.DAL.Repositorio;
using ProjetoMetaDesafio.Entidade.Entidade;

namespace ProjetoMetaDesafio.Negocio.Negocio
{
    public class AudienciaNegocio
    {
        private readonly AudienciaRepositorio audienciaRepositorio;

        public AudienciaNegocio()
        {
            audienciaRepositorio = new AudienciaRepositorio();
        }

        public void InserirAudiencia(Audiencia audiencia)
        {
            audienciaRepositorio.Adicionar(audiencia);
        }

        public List<Audiencia> ListarTodasAudiencias()
        {
            return audienciaRepositorio.ObterTodos();
        }

        public void Deletar(int idAudiencia)
        {
            audienciaRepositorio.Deletar(idAudiencia);
        }

        public Audiencia Buscar(int id)
        {
            return audienciaRepositorio.Buscar(id, id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMetaDesafio.DAL.Repositorio;
using ProjetoMetaDesafio.Entidade.Entidade;

namespace ProjetoMetaDesafio.Negocio.Negocio
{
    public class EmissoraNegocio
    {
        private readonly EmissoraRepositorio emissoraRepositorio;

        public EmissoraNegocio()
        {
            emissoraRepositorio = new EmissoraRepositorio();
        }

        public void InserirAudiencia(Emissora emissora)
        {
            emissoraRepositorio.Adicionar(emissora);
        }

        public List<Emissora> ListarTodasEmissoras()
        {
            return emissoraRepositorio.ObterTodos();
        }

        public void Deletar(int idEmissora)
        {
            emissoraRepositorio.Deletar(idEmissora);
        }

        public Emissora Buscar(int id)
        {
            return emissoraRepositorio.Buscar(id, id);
        }
    }
}

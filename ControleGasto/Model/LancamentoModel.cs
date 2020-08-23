using ControleGasto.Controllers;
using ControleGasto.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleGasto.Model
{
   public class LancamentoModel
    {
        public static int Inserir(Lancamento objeto)
        {
            return new LancamentoController().Inserir(objeto);
        }

        public static int Alterar(Lancamento objeto)
        {
            return new LancamentoController().Alterar(objeto);
        }

        public static int Excluir(Lancamento objeto)
        {
            return new LancamentoController().Excluir(objeto);
        }

        // Método de pesquisa por id
        public List<Lancamento> Buscar(Lancamento objeto)
        {
            return new LancamentoController().Buscar(objeto);
        } 
        
        public List<Lancamento> BuscarTipo(Lancamento objeto)
        {
            return new LancamentoController().BuscarTipo(objeto);
        }

        public List<Lancamento> BuscarDataTipoEntrada(Lancamento objeto)
        {
            return new LancamentoController().BuscarDataTipoEntrada(objeto);
        }

        public List<Lancamento> BuscarDataTipoSaida(Lancamento objeto)
        {
            return new LancamentoController().BuscarDataTipoSaida(objeto);
        }

        // Lista todos os dados de uma tabela.
        public List<Lancamento> Lista()
        {
            return new LancamentoController().Lista();
        }

        
    }
}

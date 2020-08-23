using ControleGasto.Controllers;
using ControleGasto.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleGasto.Model
{
    public class AnoModel
    {

        public static int Inserir(Anos objeto)
        {
            return new AnoController().Inserir(objeto);
        }

        public static int Alterar(Anos objeto)
        {
            return new AnoController().Alterar(objeto);
        }

        public static int Excluir(Anos objeto)
        {
            return new AnoController().Excluir(objeto);
        }

        // Método de pesquisa por id
        public List<Anos>Buscar(Anos objeto)
        {
            return new AnoController().Buscar(objeto);
        }

        // Lista todos os dados de uma tabela.
        public List<Anos> Lista()
        {
            return new AnoController().Lista();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ControleGasto.Entity
{
    public class Lancamento
    {
        #region Campos

        public long LancamentoId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Mes { get; set; }
        public int AnoId { get; set; }
        public DateTime Data { get; set; }



        #endregion


    }
}

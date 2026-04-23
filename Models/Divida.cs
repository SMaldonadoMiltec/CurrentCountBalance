using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurrentAccountBalance_Mark1.Models
{
    public class Divida
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [Required, SQLite.MaxLength(50)]
        public string nome { get; set; }
        public string descricao { get; set; }
        public int diaVencimento { get; set; }
        public decimal valor { get; set; }
        public Boolean pago { get; set; }

        public List<string> Parcelas { get; set; }

        public Divida()
        {
            nome= string.Empty;
            descricao = string.Empty;
            Parcelas = new List<string>();
        }
    }
}

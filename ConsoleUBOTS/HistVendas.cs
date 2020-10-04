using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleUBOTS
{
    class HistVendas
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("cliente")]
        public string Cpf { get; set; }

        [JsonProperty("itens")]
        public List<Itens> Itens { get; set; }

        [JsonProperty("valorTotal")]
        public decimal ValorTotal { get; set; }
    }

    public class Itens
    {
        [JsonProperty("produto")]
        public string Produto { get; set; }

        [JsonProperty("variedade")]
        public string Variedade { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("categoria")]
        public string Categoria { get; set; }

        [JsonProperty("safra")]
        public string Safra { get; set; }

        [JsonProperty("preco")]
        public decimal Preco { get; set; }


    }
}

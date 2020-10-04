using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace ConsoleUBOTS
{
    
    public class Cliente
    {
        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }


    }



}


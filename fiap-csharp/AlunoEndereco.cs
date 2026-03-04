using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace fiap_csharp
{
    public  class AlunoEndereco
    {
        [JsonPropertyName("logradouro")]
        public string RuaAluno { get; set; }

        [JsonPropertyName("bairro")]
        public string BairroAluno { get; set; }

        [JsonPropertyName("cep")]
        public string CepAluno { get; set; }
    }
}

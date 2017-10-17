using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFaceLib
{
    public class ServicosDeBuscaExterna
    {

        public BuscaExterna BuscadadosExternos(string cpf)
        {
           

            var restClient = new RestClient("<URL SERVIÇO>" + cpf);

            restClient.AddHandler("application/json", new RestSharp.Deserializers.JsonDeserializer());

            var request = new RestRequest(Method.GET);

            request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);

            var outputResult = restClient.Execute<BuscaExterna>(request).Data;

            return outputResult;

        }
    }
}

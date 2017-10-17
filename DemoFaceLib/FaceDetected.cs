using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFaceLib
{
    public class FaceDetected
    {
        public Retorno GetFaceDetected(string base64Data,string nome,string cpf , string userId)
        {            
            string uri = "<URL api>";

            var restClient = new RestClient(uri);

            restClient.AddHandler("application/octet-stream", new RestSharp.Deserializers.JsonDeserializer());

            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/octet-stream");
            request.AddHeader("Ocp-Apim-Subscription-Key", "<ApiKey>");

            byte[] data = Convert.FromBase64String(base64Data);
            request.AddParameter("application/octet-stream", data, ParameterType.RequestBody);

            var response = restClient.Execute<List<FaceModel>>(request).Data;

            //ServicosDeBuscaExterna busca = new ServicosDeBuscaExterna();
            //var ret = busca.BuscadadosExternos(cpf);

            var retor = TrataRetorno(response.FirstOrDefault(), null);
            //try
            //{
            //    gravaImagens(base64Data, nome, cpf, userId, response.FirstOrDefault().faceId);
            //}
            //catch(Exception ex)
            //{

            //}

            return retor;
        }

        private Retorno TrataRetorno(FaceModel facemodel, BuscaExterna busca)
        {
            var Retorno = new Retorno();

            Retorno.faceId = facemodel.faceId;
            Retorno.Nome = busca.Entities[0].People[0].Name;
            //Retorno.Idade = facemodel.faceAttributes.age != CalculateIdade(DateTime.Parse(busca.Entities[0].People[0].Birthdate)) ? CalculateIdade(DateTime.Parse(busca.Entities[0].People[0].Birthdate)).ToString() : facemodel.faceAttributes.age.ToString();
            Retorno.Idade = facemodel.faceAttributes.age.ToString();
            Retorno.EstadoCivil = busca.Entities[0].People[0].RelationshipType;
            Retorno.Endereco = "";// busca.Entities[0].People[0].Contacts[0].Address.AddressCore;
            Retorno.Cidade = "";//busca.Entities[0].People[0].Contacts[0].Address.City;
            Retorno.Estado = "";//busca.Entities[0].People[0].Contacts[0].Address.State;
            Retorno.Sexo = facemodel.faceAttributes.gender;
            Retorno.CorCabelo = facemodel.faceAttributes.hair.hairColor.FirstOrDefault(x => x.confidence >= 0.5).color;

         
            return Retorno;
        }

        //public void gravaImagens(string base64Data, string nome, string cpf, string userId , string faceid)
        //{
        //    Solicitacao sol = new Solicitacao();

        //    sol.arquivoBase64 = base64Data;
        //    sol.CPF = cpf;
        //    sol.FaceId = faceid;
        //    sol.UserId = userId;
        //    sol.DataSolicitacao = DateTime.Now;

        //    var db = new Contexto();

        //    db.Solicitacao.Add(sol);
        //    db.SaveChanges();

        //}

        public static int CalculateIdade(DateTime DataNascimento)

        {

            int anos = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))

                anos--;

            return anos;

        }


    }
}

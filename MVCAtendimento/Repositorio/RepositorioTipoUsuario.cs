using MVCAtendimento.Interfaces;


using Microsoft.AspNetCore.Mvc;
using MVCAtendimento.Models;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MVCAtendimento.Repositorio
{
    public class RepositorioTipoUsuario : ITipoUsuario
    {
        private readonly string ENDPOINT = "http://localhost:28019/";

        public TipoUsuario CriarTipoUsuario(TipoUsuario tipousuario)
        {
            var tipoUsuarioCriado = new TipoUsuario();
            try
            {
                using (var cliente = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(tipoUsuarioCriado);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    var resposta = cliente.PostAsync(ENDPOINT + "Create", content);
                    resposta.Wait();
                    if(resposta.Result.IsSuccessStatusCode)
                    {
                        var retorno = resposta.Result.Content.ReadAsStringAsync();
                        tipoUsuarioCriado = JsonConvert.DeserializeObject<TipoUsuario>(retorno.Result);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return tipoUsuarioCriado;
        }

        public TipoUsuario SelecionarTipoUsuario(int TipoUsuarioId)
        {
            var tipoUsuarioCriado = new TipoUsuario();
            tipoUsuarioCriado.TipoUsuarioId = TipoUsuarioId;
            try
            {
                using (var cliente = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(tipoUsuarioCriado);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    var resposta = cliente.PostAsync(ENDPOINT + "SelecionarTipoUsuario", content);
                    resposta.Wait();
                    if (resposta.Result.IsSuccessStatusCode)
                    {
                        var retorno = resposta.Result.Content.ReadAsStringAsync();
                        tipoUsuarioCriado = JsonConvert.DeserializeObject<TipoUsuario>(retorno.Result);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return tipoUsuarioCriado;
        }

        public TipoUsuario AtualizarTipoUsuario(int TipoUsuarioId, TipoUsuario tipousuario)
        {
            var tipoUsuarioCriado = new TipoUsuario();
            try
            {
                using (var cliente = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(tipoUsuarioCriado);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    var resposta = cliente.PostAsync(ENDPOINT + "AtualizarTipoUsuario", content);
                    resposta.Wait();
                    if (resposta.Result.IsSuccessStatusCode)
                    {
                        var retorno = resposta.Result.Content.ReadAsStringAsync();
                        tipoUsuarioCriado = JsonConvert.DeserializeObject<TipoUsuario>(retorno.Result);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return tipoUsuarioCriado;
        }

        public TipoUsuario DeletarTipoUsuario(int TipoUsuarioId)
        {
            var tipoUsuarioCriado = new TipoUsuario();
            tipoUsuarioCriado.TipoUsuarioId = TipoUsuarioId;
            try
            {
                using (var cliente = new HttpClient())
                {
                    string jsonObject = JsonConvert.SerializeObject(tipoUsuarioCriado);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    var resposta = cliente.PostAsync(ENDPOINT + "DeletarTipoUsuario", content);
                    resposta.Wait();
                    if (resposta.Result.IsSuccessStatusCode)
                    {
                        var retorno = resposta.Result.Content.ReadAsStringAsync();
                        tipoUsuarioCriado = JsonConvert.DeserializeObject<TipoUsuario>(retorno.Result);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return tipoUsuarioCriado;
        }

        public void AtualizarTipoUsuario(TipoUsuario collection)
        {
            throw new NotImplementedException();
        }
    }
}

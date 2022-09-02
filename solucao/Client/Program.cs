using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;

namespace Client
{
    class Program
    {
        //Por termos um operador await precisamos mudar o "void main" para "async Task"
        static async Task Main(string[] args)
        {
            //descobrir os endpoints a partir dos metadados
            var client = new HttpClient();//este client será usado para fazer chamadas para o Http do IdentityServer
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5001");
            /*
            Método para descobrir qual é o Discovery Document, Endereço do IdentityServer
            Por ser um método Async é necessário que ele seja "await"
            */

            if (disco.IsError)//Em caso do disco dar erro
            {
                Console.WriteLine(disco.Error);//Vai imprimin o erro no console.
                return;//retornando sem fazer nada.
            }
            //Request Token, utilizando o Discovery Document para acessar o Token.
            var tokenResponse =
                    //Requisitando as credenciais do token
                    await client.RequestClientCredentialsTokenAsync
                    (
                            //Passando como parametro a configuração com varias informações do Client e qual recurso queremos acessar.
                            new ClientCredentialsTokenRequest
                            {
                                Address = disco.TokenEndpoint,//Qual endereço vamos acessar para pegar o token.
                                ClientId = "client",//Qual o identificador deste client que estamos usando para acessar. Lembrando que ser igual o configurado no Identity Server

                                ClientSecret = "secret",//Secret do client.

                                Scope = "api1"//scope que iremos acessar
                            });
            if (tokenResponse.IsError)//Verificando se o tokenResponse foi um erro
            {
                Console.WriteLine(tokenResponse.Error);//Imprimindo o erro no console.
                return;//retornando sem fazer nada
            }
            //Caso o contrário prossiga, obtenha a resposta do token e imprima a propriedade na tela
            Console.WriteLine(tokenResponse.Json);

            //Criando um novo Client Http para chamar a API
            var apiClient = new HttpClient();

            //Método que vai definir o token, jogando o tokenResponse no cabeçalho da requisição Http
            apiClient.SetBearerToken(tokenResponse.AccessToken);//Acessando o token de acesso do tokenResponse

            //Acessar a API, pegar o resultado e exibi-lo
            var response = await apiClient.GetAsync("https://localhost:5000/identity");//coloque a Route da IdentityController
            if (!response.IsSuccessStatusCode)//Se a resposta não for um sucesso
            {
                Console.WriteLine(response.StatusCode);//Imprima no console
            }
            else//Caso o contrário ou seja um sucesso
            {
                var content = await response.Content.ReadAsStringAsync();//Pegando o conteudo da resposta e lendo como uma string.
                Console.WriteLine(JArray.Parse(content));//Pegando o resultado json e transformando em um objeto para imprimi-lo 

            }

            Console.ReadKey();//impedindo que o console feche
        }
    }
}
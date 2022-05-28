#pragma checksum "C:\Users\KAYN\Desktop\ProjetoElevado\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c40ef4e31bf681989734468e89f90a3dac5565e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\KAYN\Desktop\ProjetoElevado\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KAYN\Desktop\ProjetoElevado\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c40ef4e31bf681989734468e89f90a3dac5565e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4923143fe3bec400c1f93c72fde12f2bac68e920", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\KAYN\Desktop\ProjetoElevado\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "~Proj_Elev_Doc~";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-left"">
    <h3><b></distributed-cache><span style=""color:#2980b9"">DOCUMENTAÇÃO-PROJETO ELEVADOR</b></h3>
    <p><b>FORMAÇÃO MS-DEV - SAMSUNG OCEAN</b></p>
    </div>

<boddy>

<p>RESUMO GERAL:  Neste projeto, o intuito é aplicar o conhecimento adquirido nesta jornada de estudo de lógica de programação e praticar os tipos de dados, 
    controle de fluxo, laços de repetição utilizando funções. O projeto será um software que tem como função o gerenciamento de um elevador, ele terá as funções 
    de inicializar, entrar, sair, subir e descer. O projeto foi publicado no <a href=""https://github.com/caiousouza/ProjetoElevador"">github.</a></p> 

<div class=""text-center""><h5><b>---INSTRUÇÕES---</b></h5></div>
<p>Utilize o Visual Studio Community, crie um projeto Aplicativo de Co
    nsole (console app) como nome ProjetoElevador, utilize a estrutura .NET 5 ou inferior. 
   Todas as classes deverão ficar em uma pasta chamada Model, a estrutura com as pastas de Controller e View são ");
            WriteLiteral(@"opcionais. Crie uma classe denominada Elevador 
   para armazenar as informações de um elevador dentro de um prédio, a classe deve armazenar o andar atual (térreo = 0), total de andares no prédio 
   (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:  inicializar,
   entrar, sair, subir e descer.</p>

<div class=""text-center""><h5><b>~DESCRIÇÃO DO PROGRAMA~</b></h5></div>

<h6>~FUNCIONABILIDADE:</h6>

<p>Assim que o projeto for iniciado, surgira uma mensagem de ""Boas-Vindas"", e logo em seguida surgira dois campos de pergunta pedindo para o user informar a quantidade 
   de andares, e a capaciade do elevador. O metodo ""Inicializar()"" será utilizado para fazer as perguntas e receber as respostas. Logo após os campos de pergunta 
   serem respondidos, as variaveis que armazenaram as respostas, seram convertidas para ""int"", e seram alocadas dentro de outras variaveis.</p>

<img src=""/img/Lacdr.jpg"" />
<p");
            WriteLiteral(@">-</p>

<p>Após o Metodo ""Inicializar()"" ser concluido, o projeto irá iniciar o laço de repetição do-while, com o intuito de repetir as opções pre definidas ao user, até 
   a opção de finalizar o programa for escolhida. As opções disponiveis serão: adicionar, retirar, subir, descer e finalizar. A variavel ""escolha"" irá receber a 
   escolha decidida e será armacenada dentro da variavel ""Num"", após ser convertida em inteira. Logo após que a escolha for recebida, convertida e armazenada, a 
   instrução switch receberá a variavel ""Num"" e chamará o Metodo correspondente ao solicitado, executando o Metodo e logo em seguida retornado uma mensagem para informar 
   qual ação foi executada e qual o status do elevador. Dentre as opções disponiveis, há um comando chamado ""default"", ele será executado quando o user precionar alguma
   tecla diferente das disponiveis a ele.</p>

<img src=""/img/switch.jpg"" />
<p>-</p>

<h6>~METODOS:</h6>

<p>Os Metodos estão alocados em uma class denominada ""Elevador.cs"", ");
            WriteLiteral(@"podemos ultilizar essa class por a mesma ser publica, sendo chamada pelo nosso programa por uma biblioteca,
   cada Metodo tem uma função espeficica, quanndo for executado mudará e retornará a variavel com um novo valor, em seguida retornando uma mensagem da ação feita, e os status do 
   elevador. Podemos usar como exemplo o Metodo Entrar().</p>

<img src=""/img/MetEnt.jpg"" />
<p>-</p>

<p>O metodo Entra() será ultilizado para adicionar um passageiro, toda vez que for executado ela adicionarar +1, nós podemos notar que há a instrução ""IF"" e ELSE"", se o 
   valor corresponder quantidade de pessoas atual sendo menor que a quantidade de pessoas total, a instrução ""IF"" ela será executada, e dentro dela há um novo comando, este comando
   ""PessoasAtual++"" serve para adicinar o passageiro, ela terá a função de sempre acrescentar,há a possiblidade de ter outro ""IF"" ou um ""RETURN"", se a variavel ""AndarAtual"" for 
   correspondente a ""0"""", o ""RETURN"" dentro do segundo ""IF"" será executado e retornará uma mens");
            WriteLiteral(@"agem informando que o elevador está no terrio e a quantidade exata de passageiros no 
   elevador. Senão o primeiro ""RETURN"" será executado e retornando que entrou um passageiro, o andar atual e a quantidade exata de passageiros. O ""ELSE"" será executado caso não seja 
   atencido os requisitos de ""IF"", Retornado a mensagem que o elevador atingiu a sua capacidade maxima, o andar atual e a quantidade exata de passageiros.</p>

<p>O codigo ""Console.Clear();"" é ultilizado toda vez que for necessario retornar uma mensagem para o user, assim o console ficará mais limpo e e as informações retornadas ficam mais 
    nitidas. A mesma metodologia ultilizada para adicionar passageiros no elevador, tambêm pode ser utilizada para subitrair passageiros, ou subir um andar, ou descer um andar, só
    tendo uma pequena diferença na sua sintaxe, que seria o ""PessoasAtual--"", ou o ""AndarAtual++"", ou ""AndarAtual--"".<p>

<img src=""/img/MetSair.jpg""/>
<p>-</p>

<h6>~EXECUÇÃO:</h6>

<p>Com o projeto finalizado e todos ");
            WriteLiteral("os pontos e virgulas em seus devidos lugares, o programa terá um visual do prompt de comando, simples, legivel e funcional, botando \r\n   tudo pra rodar.</p>\r\n\r\n<img src=\"/img/cap2.jpg\" />\r\n<p>-</p>\r\n\r\n<P>Autor: Caio Souza Queiroz</P>\r\n</boddy>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

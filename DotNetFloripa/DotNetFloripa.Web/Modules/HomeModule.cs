using DotNetFloripa.Model;
using Nancy;
using System.Collections.Generic;

namespace DotNetFloripa.Web.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
            Get["/sobre"] = _ => View["About"];
            Get["/eventos"] = _ => View["Events"];
            Get["/vagas"] = _ => View["Jobs"];
            Get["/empresas"] = _ => View["Companies", GetCompanies()];
            Get["/contato"] = _ => View["Contact"];
        }

        private IEnumerable<Company> GetCompanies()
        {
            return new[] {
                new Company {
                    Id = 1,
                    Name = "Way2 Techonology",
                    Description = "A Way2 desenvolve softwares e serviços para telemedição e gestão de dados de medição de energia. Sediada em Florianópolis, Santa Catarina, a empresa possui uma equipe multidisciplinar especializada no atendimento às demandas de empresas do setor elétrico, como geradoras, transmissoras, distribuidoras e comercializadoras.",
                    Site = "http://way2.com.br",
                    Address = "Rodovia SC 401, Km 04, Espaço Primavera Garden - Bloco B",
                    Logo = "http://way2.com.br/wp-content/themes/way2/images/logo-way2.png"
                },
                new Company {
                    Id = 2,
                    Name = "Bravi Software",
                    Description = "A Bravi Software é uma empresa que desenvolve soluções e tecnologia para o mercado da educação.",
                    Site = "http://bravisoftware.com/",
                    Address = "Rodovia SC 401, n° 8600 - Sala 4, bloco 08",
                    Logo = "http://bravisoftware.com/img/bg-logo.png"
                }
            };
        }
    }
}
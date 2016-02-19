using System;
using System.Linq;
using DotNetFloripa.Model;
using DotNetFloripa.Model.Interfaces;

namespace DotNetFloripa.Data
{
    public class AppRepository : IAppRepository
    {
        public AppRepository()
        {
            Events = new[]
            {
                new Event
                {
                    Id = 1,
                    Slug = "dotnetfloripa-fevereiro",
                    Description = "O grupo DotNetFloripa está voltando a ativa e já temos um novo evento marcado!",
                    Start = new DateTime(2014, 2, 19, 19, 00, 0),
                    End = new DateTime(2014, 2, 19, 21, 30, 0),
                    ExternalUrl = "http://www.eventick.com.br/dotnetfloripa-fevereiro",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Fevereiro",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "NancyFX é um framework HTTP super leve que serve de alternativa para o ASP.NET MVC ou ASP.NET Web API. Por que precisamos de uma alternativa? Quais os benefícios que isso traz e como introduzir o NancyFX em um app já existente? Venha conferir!",
                            Start = new DateTime(2014, 2, 19, 19, 30, 0),
                            End = new DateTime(2014, 2, 19, 20, 15, 0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Conheça o NancyFX!"
                        },
                        new Talk
                        {
                            Start = new DateTime(2014, 2, 19, 20, 15, 0),
                            End = new DateTime(2014, 2, 19, 20, 30, 0),
                            Title = "coffee-break",
                            Description = "Sim! Agora temos coffee-break com deliciosos salgadinhos!"
                        },
                        new Talk
                        {
                            Description =
                                "Todos nós amamos o Nuget. É até difícil lembrar o quanto era cruel gerenciar nossas dependências de projetos manualmente. Nesta palestra damos um passo a mais: vamos aprender como criar nossos próprios pacotes, integrá-los com builds automatizados e descobrir como sua empresa pode tirar o máximo desta tecnologia.",
                            Start = new DateTime(2014, 2, 19, 20, 30, 0),
                            End = new DateTime(2014, 2, 19, 21, 30, 0),
                            Speaker = "André Carlucci",
                            Title = "Aproveite ao máximo o Nuget"
                        }
                    }
                },
                new Event
                {
                    Id = 2,
                    Slug = "gwab-floripa",
                    Description =
                        "Bootcamp de Windows Azure! Mais informações no <a href='http://gwab2014-floripa.azurewebsites.net/'>site oficial</a>! ",
                    Start = new DateTime(2014, 3, 29, 8, 0, 0),
                    End = new DateTime(2014, 3, 29, 17, 0, 0),
                    ExternalUrl = "http://www.eventick.com.br/GWAB2014-Florianopolis-SC",
                    ImageUrl = "http://i.imgur.com/yW4p5Yy.jpg",
                    Organizers = new[] {"André Carlucci", "Luís Deschamps Rudge"},
                    Title = "Global Windows Azure Bootcamp - Floripa",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description = "Boas vindas",
                            Start = new DateTime(2014, 3, 29, 8, 0, 0),
                            End = new DateTime(2014, 3, 29, 8, 30, 0),
                            Speaker = "-",
                            Title = "Welcome"
                        },
                        new Talk
                        {
                            Description = "Keynote sobre o evento",
                            Start = new DateTime(2014, 3, 29, 8, 30, 0),
                            End = new DateTime(2014, 3, 29, 9, 0, 0),
                            Speaker = "-",
                            Title = "Keynote Microsoft"
                        },
                        new Talk
                        {
                            Description = "Overview sobre Windows Azure",
                            Start = new DateTime(2014, 3, 29, 9, 0, 0),
                            End = new DateTime(2014, 3, 29, 9, 45, 0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Overview Windows Azure"
                        },
                        new Talk
                        {
                            Description = "LAB",
                            Start = new DateTime(2014, 3, 29, 9, 45, 0),
                            End = new DateTime(2014, 3, 29, 11, 0, 0),
                            Speaker = "-",
                            Title = "Lab: Luta contra diabetes"
                        },
                        new Talk
                        {
                            Description =
                                "Entenda o que é Azure Mobile Services e como utilizá-lo com sucesso no seu app!",
                            Start = new DateTime(2014, 3, 29, 11, 0, 0),
                            End = new DateTime(2014, 3, 29, 11, 30, 0),
                            Speaker = "André Carlucci",
                            Title = "Windows Azure Mobile Services"
                        },
                        new Talk
                        {
                            Description = "Confira como utilizar o Azure como uma extensão da sua empresa!",
                            Start = new DateTime(2014, 3, 29, 11, 30, 0),
                            End = new DateTime(2014, 3, 29, 12, 0, 0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Máquinas virtuais e VPN"
                        },
                        new Talk
                        {
                            Description = "Almoço grátis no local",
                            Start = new DateTime(2014, 3, 29, 12, 0, 0),
                            End = new DateTime(2014, 3, 29, 13, 0, 0),
                            Speaker = "-",
                            Title = "Almoço"
                        },
                        new Talk
                        {
                            Description = "LAB",
                            Start = new DateTime(2014, 3, 29, 13, 0, 0),
                            End = new DateTime(2014, 3, 29, 16, 45, 0),
                            Speaker = "-",
                            Title = "Labs (Virtual Machines, VPN, Mobile Services, WebSites)"
                        },
                        new Talk
                        {
                            Description = "Encerramento",
                            Start = new DateTime(2014, 3, 29, 16, 45, 0),
                            End = new DateTime(2014, 3, 29, 17, 0, 0),
                            Speaker = "-",
                            Title = "Encerramento"
                        }
                    }
                },
                new Event
                {
                    Id = 3,
                    Slug = "dotnetfloripa-2015-04",
                    Description = "IoT com Netduíno e reconhecimento de gestos com RealSense",
                    Start = new DateTime(2015, 4, 23, 19, 15, 0),
                    End = new DateTime(2014, 4, 23, 21, 15, 0),
                    ExternalUrl = "http://even.tc/dotnetfloripa-2015-04",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Abril de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Você já deve ter ouvido falar disso. Internet das Coisas (IoT Internet of things), tudo o que é dispositivo pessoal ou equipamento com um endereço IP, sendo monitorado, gerenciado e telemetrado. Mas que tal começar a colocar a mão na massa e entender como interagir com os dispositivos por exemplo Chaves de contato liga e desliga, medidores de potência, leds, tudo isso usando MicroFrameWork + Arduino = NetDuino em C#!!! Assista esta palestra e saia com o lado esquerdo do cérebro pipocando de ideias.",
                            Start = new DateTime(2015, 4, 23, 19, 15, 0),
                            End = new DateTime(2015, 4, 23, 20, 00, 0),
                            Speaker = "Claudenir C. Andrade",
                            Title = "IOT Internet das Coisas Visual Studio e Windows embedded"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 4, 23, 20, 0, 0),
                            End = new DateTime(2015, 4, 23, 20, 15, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description =
                                "Venha aprender como utilizar gestos, fala e expressões faciais para interagir com suas aplicações adicionando a elas um controle natural e intuitivo com Intel RealSense SDK",
                            Start = new DateTime(2015, 4, 23, 20, 30, 0),
                            End = new DateTime(2015, 4, 23, 21, 15, 0),
                            Speaker = "André Carlucci e Renato Haddad",
                            Title = "Interaja naturalmente com suas aplicações utilizando o Intel RealSense SDK"
                        }
                    }
                },
                new Event
                {
                    Id = 4,
                    Slug = "dotnetfloripa-2015-05",
                    Description = "ASP.NET 5 e o novo mundo de desenvolvimento WEB",
                    Start = new DateTime(2015, 5, 27, 19, 15, 0),
                    End = new DateTime(2014, 5, 27, 21, 15, 0),
                    ExternalUrl = "http://even.tc/dotnetfloripa-2015-05",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Maio de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Venha conhecer o que há de novo no ASP.NET 5, os novos tipos e estruturas de projetos, as ferramentas de edição  de códigos, as plataformas de execução de uma aplicação ASP 5 (Windows, Mac Ox, Linux), os arquivos de configurações, a integração com injeção de dependências, os novos .NET Execution Environment (DNX) e .NET Version Manager (DNVM), como integrar com o Entity Framework 7, e ao final, como executar uma aplicação ASP.NET 5 no Pen-Drive.",
                            Start = new DateTime(2015, 5, 27, 19, 15, 0),
                            End = new DateTime(2015, 5, 27, 20, 00, 0),
                            Speaker = "Renato Haddad",
                            Title = "O que há de novo no ASP.NET 5?"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 5, 27, 20, 0, 0),
                            End = new DateTime(2015, 5, 27, 20, 15, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description =
                                "NodeJS, NPM, gulp, yeoman, bower, docker... É tanta coisa nova que é difícil saber por onde começar. Nessa palestra, vamos entender onde cada peça se encaixa e como tirar vantagem de tudo isso utilizando a plataforma .NET",
                            Start = new DateTime(2015, 5, 27, 20, 30, 0),
                            End = new DateTime(2015, 5, 27, 21, 15, 0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Desenvolvimento WEB moderno com .NET"
                        }
                    }
                }
                ,
                new Event
                {
                    Id = 5,
                    Slug = "dotnetfloripa-2015-06",
                    Description = "C# no mundo Android com Xamarin",
                    Start = new DateTime(2015, 6, 16, 19, 00, 0),
                    End = new DateTime(2014, 6, 16, 21, 00, 0),
                    ExternalUrl = "http://www.meetup.com/pt/DotNetFloripa/events/223229354/",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Junho de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Venha conhecer como fazer um app para android usando C# e Xamarin. Onde fazer download e os tipos de licença. Vamos inserir um dado no banco de dados SQLite3, consultar e mandar para um nova tela (transporte de valores de uma tela a outra). Pegar este projeto feito em VS2013, abrir no Xamarin Studio para mostrar a compatibilidade entre os dois.",
                            Start = new DateTime(2015, 6, 16, 19, 00, 0),
                            End = new DateTime(2015, 6, 16, 20, 00, 0),
                            Speaker = "Marco A. (Ghostman)",
                            Title = "C# no mundo Android com Xamarin"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 5, 27, 20, 0, 0),
                            End = new DateTime(2015, 5, 27, 20, 15, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description = "Discussão sobre desenvolvimento mobile. Acertos, erros e lições aprendidas",
                            Start = new DateTime(2015, 5, 27, 20, 30, 0),
                            End = new DateTime(2015, 5, 27, 21, 15, 0),
                            Speaker = "Todos",
                            Title = "Discussão sobre desenvolvimento mobile. Acertos, erros e lições aprendidas"
                        }
                    }
                }
                ,
                new Event
                {
                    Id = 6,
                    Slug = "dotnetfloripa-2015-07",
                    Description = "Mob Programming com C# 6, TDD e muito Refactoring!",
                    Start = new DateTime(2015, 7, 16, 19, 00, 0),
                    End = new DateTime(2015, 7, 16, 21, 30, 0),
                    ExternalUrl = "http://www.meetup.com/DotNetFloripa/events/223834501/",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad"},
                    Title = "dotnet Floripa - Julho de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description = "Novidades do C# 6",
                            Start = new DateTime(2015, 7, 16, 19, 30, 0),
                            End = new DateTime(2015, 7, 16, 19, 50, 0),
                            Speaker = "Renato Haddad",
                            Title = "Novidades do C# 6"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 7, 16, 19, 50, 0),
                            End = new DateTime(2015, 7, 16, 20, 0, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description = "Mob Programming com a participação de todos",
                            Start = new DateTime(2015, 7, 16, 20, 0, 0),
                            End = new DateTime(2015, 7, 16, 21, 30, 0),
                            Speaker = "André Carlucci e todos os presentes",
                            Title = "Mob Programming com C# 6, TDD e muito Refactoring!"
                        }
                    }
                },
                new Event
                {
                    Id = 7,
                    Slug = "dotnetfloripa-2015-08",
                    Description = "ASP.NET 5 e Angular 2 com Testes de Unidade, no Linux e sem Visual Studio :)",
                    Start = new DateTime(2015, 8, 26, 19, 00, 0),
                    End = new DateTime(2015, 8, 26, 21, 30, 0),
                    ExternalUrl = "http://www.meetup.com/DotNetFloripa/events/224637303/",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad"},
                    Title = "dotnet Floripa - Agosto de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Nessa palestra será apresentado o fluxo de criação de um web app, indo da criação dos serviços em ASP.NET 5 até a interação com cliente utilizando Angular 2 e testes com Jasmine.",
                            Start = new DateTime(2015, 8, 26, 19, 15, 0),
                            End = new DateTime(2015, 8, 26, 20, 15, 0),
                            Speaker = "Guilherme Waess e Gabriel Cardoso",
                            Title = "ASP.NET 5 e Angular 2 com Testes de Unidade, no Linux e sem Visual Studio :)"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 8, 26, 20, 15, 0),
                            End = new DateTime(2015, 8, 26, 20, 30, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description = "",
                            Start = new DateTime(2015, 8, 26, 20, 30, 0),
                            End = new DateTime(2015, 8, 26, 21, 00, 0),
                            Speaker = "Todos",
                            Title = "Discussão sobre Angular 2 e Asp.Net VNEXT"
                        }
                    }
                },
                new Event
                {
                    Id = 8,
                    Slug = "dotnetfloripa-2015-09",
                    Description = "Test Driven Development, como começar",
                    Start = new DateTime(2015, 9, 30, 19, 00, 0),
                    End = new DateTime(2015, 9, 30, 21, 30, 0),
                    ExternalUrl = "http://www.meetup.com/pt/DotNetFloripa/events/225674366",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luis Rudge"},
                    Title = "dotnet Floripa - Setembro de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Desenvolvimento orientado a testes é um processo evolucionário em que o desenvolvedor escreve primeiro os testes e depois o código de produção. É uma técnica de programação que visa acima de tudo qualidade e redução de bugs nas aplicações, fazendo o programador pensar primeiro do design da aplicação e depois em seu código funcional. Venha conhecer técnicas, frameworks e ver na prática como escrever testes de unidade tornando suas aplicações mais confiáveis e fáceis de manter.",
                            Start = new DateTime(2015, 9, 30, 19, 15, 0),
                            End = new DateTime(2015, 9, 30, 20, 15, 0),
                            Speaker = "André Carlucci",
                            Title = "Test Driven Development, como começar"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 9, 30, 20, 15, 0),
                            End = new DateTime(2015, 9, 30, 20, 30, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description = "",
                            Start = new DateTime(2015, 9, 30, 20, 30, 0),
                            End = new DateTime(2015, 9, 30, 21, 00, 0),
                            Speaker = "Todos",
                            Title = "Discussão e troca de experiências sobre TDD"
                        }
                    }
                },
                new Event
                {
                    Id = 9,
                    Slug = "dotnetfloripa-2015-11",
                    Description = "Venha conhecer os novos lançamentos da Microsoft na área de relatórios (Power BI) e Microservices (Azure Service Fabric).",
                    Start = new DateTime(2015, 11, 25, 19, 00, 0),
                    End = new DateTime(2015, 11, 25, 21, 30, 0),
                    ExternalUrl = "http://www.meetup.com/DotNetFloripa/events/226958412",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luis Rudge"},
                    Title = "dotnet Floripa - Novembro de 2015",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Durante muitos anos a Microsoft pensou numa ferramenta de relatórios que atendesse o mercado de forma brilhante. E, finalmente criaram a ferramenta chamada Power BI. Quando digo brilhante é porquê ela contém muitos modelos de relatórios, consegue usar qualquer fonte de dados disponível no mercado, a interface de usuário para se criar um relatório é simples, você publica na Internet, e para finalizar, em breve será criado um Viewer para que você possa ler qualquer relatório de dentro das aplicações, seja Web, Mobile ou HTML.",
                            Start = new DateTime(2015, 11, 25, 19, 15, 0),
                            End = new DateTime(2015, 11, 25, 20, 15, 0),
                            Speaker = "Renato Haddad",
                            Title = "Explore relatórios com o Power BI"
                        },
                        new Talk
                        {
                            Start = new DateTime(2015, 11, 25, 20, 15, 0),
                            End = new DateTime(2015, 11, 25, 20, 30, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description =
                                "A complexidade de criar e administrar um grande números de serviços é muito grande. Ferramentas e aplicações ainda não conseguiram resolver os inúmeros problemas desse tipo de solução com flexibilidade e de maneira confiável. O Azure Service Fabric, a evolução do PaaS (Platform-as-a-Service) da Microsoft, foi criado pra resolver esses problemas, conectando os microservices com a infraestrutura em que eles estão rodando de maneira simples.",
                            Start = new DateTime(2015, 11, 25, 20, 30, 0),
                            End = new DateTime(2015, 11, 25, 21, 30, 0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Microservices: é simples com Azure Service Fabric"
                        }
                    }
                },
                new Event
                {
                    Id = 10,
                    Slug = "dotnetfloripa-2016-02",
                    Description = "Conheça tudo sobre Application Insights",
                    Start = new DateTime(2016, 02, 22, 19, 00, 0),
                    End = new DateTime(2016, 02, 22, 21, 30, 0),
                    ExternalUrl = "http://www.meetup.com/pt-BR/DotNetFloripa/events/228868744",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[] {"André Carlucci", "Renato Haddad", "Luis Rudge"},
                    Title = "dotnet Floripa - Fevereiro de 2016",
                    Talks = new[]
                    {
                        new Talk
                        {
                            Description =
                                "Através do Application Insights é possível detectar situações, auxiliar na solução de problemas para sempre melhorar a sua aplicação. Diagnósticos rápidos ajudam a resolver problemas durante o desenvolvimento e também em produção, principalmente como os usuários atuam no sistema. Atualmente suportado em iOS, Android, Windows Apps, J2EE, ASP.NET Web Applications e WCF. O SDK para JavaScript funciona em qualquer Web Page.",
                            Start = new DateTime(2016, 02, 22, 19, 15, 0),
                            End = new DateTime(2016, 02, 22, 20, 15, 0),
                            Speaker = "Alex Tochetto",
                            Title = "Application Insights com Microsoft Azure"
                        },
                        new Talk
                        {
                            Start = new DateTime(2016, 02, 22, 20, 15, 0),
                            End = new DateTime(2016, 02, 22, 20, 30, 0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },
                        new Talk
                        {
                            Description =
                                "Em breve",
                            Start = new DateTime(2016, 02, 22, 20, 30, 0),
                            End = new DateTime(2016, 02, 22, 21, 30, 0),
                            Speaker = "Em breve",
                            Title = "Em breve"
                        }
                    }
                }
            };

            Companies = new[]
            {
                new Company
                {
                    Name = "Way2 Techonology",
                    Description =
                        "A Way2 desenvolve softwares e serviços para telemedição e gestão de dados de medição de energia. Sediada em Florianópolis, Santa Catarina, a empresa possui uma equipe multidisciplinar especializada no atendimento às demandas de empresas do setor elétrico, como geradoras, transmissoras, distribuidoras e comercializadoras.",
                    Site = "http://way2.com.br",
                    Address = "Rodovia SC 401, 4150, CIA Acate sala 17 - Florianópolis - SC",
                    LogoUrl = "http://i.imgur.com/Slsbsu1.png"
                },
                new Company
                {
                    Name = "Paradigma",
                    Description =
                        "Em 18 anos de mercado a Paradigma especializou-se no desenvolvimento de soluções para relacionamento e negociação eletrônica. Presente em mais de 20 setores da economia, acumula experiência e conhecimento com um ciclo contínuo de inovação tecnológica e de processos, acompanhando a evolução das melhores práticas de mercado. A empresa oferece soluções consolidadas, confiáveis e com alta disponibilidade, para os segmentos de energia, indústria, serviços, setor público e mercado aberto.",
                    Site = "http://www.paradigmabs.com.br",
                    Address = "Rodovia José Carlos Daux (SC 401), 8.600, Sala 102 - Bloco 04 - Florianópolis - SC",
                    LogoUrl = "http://i.imgur.com/iiqapkl.png"
                }
            };
        }

        public Event[] Events { get; }
        public Company[] Companies { get; set; }

        public IQueryable<Event> GetEvents()
        {
            return Events.AsQueryable();
        }

        public Event GetEventBySlug(string slug)
        {
            return Events.FirstOrDefault(e => e.Slug.Equals(slug, StringComparison.InvariantCultureIgnoreCase));
        }

        public IQueryable<Company> GetCompanies()
        {
            return Companies.AsQueryable();
        }
    }
}

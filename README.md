# ListaDeContatoASPNET
Programa feito com front-end em HTML, CSS e JavaScript, com back-end em C# e banco de dados no SQLserver local.

<h1> Como rodar o programa com banco de dados através do Script fornecido</h1>
Primeiramente clone o repositório através do Visual Studio, após a clonagem, abra o SQL Server Management Studio e faça a importação do script.
Siga para o appsettings.json e altere a connectionstring para que o servidor, usuário e senha se assemelhe ao seus cadastrados no SSMS.
Após isso o banco de dados deverá ser reconhecido e utilizável.
Para rodar o programa, clique em IIS Express na parte superior do Visual Studio.

<h2> Como rodar o programa através de comandos no Nuget packet manager console</h2>
Primeiramente clone o repositório através do Visual Studio, após a clonagem, siga para o appsettings.json e altere a connectionstring para que o servidor, usuário e senha se assemelhe ao seus cadastrados no SSMS. 
Vá em tools na parte superior esquerda da tela, Nuget Packet Manager e Packet Manager Console.
Já no console digite: Update-Database -Context BancoContext
Após isso o programa deverá criar um banco de dados no SQLServer e se conectar com ele.
Para rodar o programa, clique em IIS Express na parte superior do Visual Studio.

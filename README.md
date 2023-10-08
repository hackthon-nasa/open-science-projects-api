# Open Science Project - API .NET 6

A Plataforma de Colaboração de Projetos - API .NET 6 é a parte da aplicação que lida com a lógica de backend e a interação com o banco de dados. 
Ela fornece uma interface para que o frontend da aplicação se comunique e gerencie dados relacionados a instituições públicas, profissionais e projetos.

## Pré-Requisitos

- **.NET 6.0:** Certifique-se de ter o ambiente de desenvolvimento .NET 6 instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet/6.0).

- **SQL Server:** A aplicação requer um banco de dados SQL Server para armazenar informações de projetos, usuários e colaborações. Certifique-se de configurar uma conexão válida no arquivo de configuração.

## Configuração e Instalação

1. Clone este repositório em sua máquina local:

```bash 
git clone 
``` 

2. Navegue até o diretório raiz do projeto:

```bash 
cd open-science-projects-api
``` 

3. Configure o banco de dados SQL Server editando a string de conexão no arquivo `appsettings.json`.

4. Execute as migrações do banco de dados para criar as tabelas necessárias:
```bash 
dotnet ef database update
``` 

5. Inicie a API:
```bash 
dotnet run
``` 

A API estará disponível em `http://localhost:6001`.

## Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo [LICENSE](LICENSE) para obter detalhes.

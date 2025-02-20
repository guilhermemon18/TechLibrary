# TechLibrary

Uma API que permite listar livros com paginação e parâmetros, realizar o empréstimo desses itens, criar usuários e realizar seu login.

## Tecnologias Utilizadas

- **.Net versão 8:** Plataforma de desenvolvimento.
- **Sqlite:** Banco de dados SQL.
- **Entity Framework:** Mapeamento objeto-relacional.
- **BCrypt.Net-Next:** Biblioteca para criptografar dados.
- **Swagger-OpenAPI:** Biblioteca utilizada para documentar a API.
- **FluentValidation:** Biblioteca para validação de dados.
- **Microsoft.IdentityModel.Tokens:** Biblioteca para trabalhar com tokens em autenticação e autorização.
- **System.IdentityModel.Tokens.Jwt:** Biblioteca que fornece suporte a JSON Web Tokens (JWT).
- **Microsoft.AspNetCore.Authentication.JwtBearer:** Middleware para autenticação com base em tokens Bearer JWT.
  
  

## Como utilizar a API

Para utilizar esta API, você precisará de um cliente HTTP como Postman ou Insomnia para fazer as requisições, mas pode ser utilizada a documentação do swagger/openAPI também.

## Endpoints

Uma documentação detalhada consta na própria API na rota:

```sh
http://localhost:5215/swagger/index.html
```
## Executando o projeto

Faça um clone deste repositório e instale no seu ambiente de desenvolvimento utilizando o seguinte comando no seu terminal (escolha um diretório apropriado):

```shell
git clone git@github.com:guilhermemon18/TechLibrary.git
```

Após clonar o conteúdo do repositório, acesse o diretório criado, acesse o projeto `TechLibrary.Api` e execute os comandos abaixo:

```shell
dotnet restore
dotnet run
```

Após a execução do comando acima o servidor estará em execução no endereço `http://localhost:5215`, com a possibilidade de ser testado diretamente em:

```shell
http://localhost:5215/swagger/index.html
```



## Autenticação de rotas

Para utilizar as rotas que exigem autorização (/Checkouts/{bookId}),  é necessário criar um usuário no endpoint `/Users`, utilizando as seguintes credenciais no corpo de requisição:

```shell
{
  "name": "user_name",
  "email": "user@provedor.com",
  "password": "senha_mínimo_6_caracteres"
}
```
Em seguida, utilizar o acesstoken recebido como resposta para fazer a autorização no swagger no botão `Authorize` utilizando a seguinte sintaxe:

```shell
Bearer acess_token
```

ou inserir no Headers a chave Authorization com o Bearer Token da seguinte forma:
```shell
{
  Key: "Authorization",
  Value: "Bearer acess_token"
}
```

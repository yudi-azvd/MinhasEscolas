# Minhas Escolas

REST API muito simples pra gerenciar escolas.

[Treinamento basicão no YouTube](https://youtu.be/tMB0GwntJtA).

[Slides](/treinamento-dotnet.pdf).

## Uso

    git clone git@github.com:yudi-azvd/MinhasEscolas.git
    cd MinhasEscolas

Inicie o servidor

    dotnet run

Acesse http://localhost:5273/Escolas.

Você também pode acessar a documentação swagger pelo browser em 
http://localhost:5273/swagger.

### HTTREPL

Para usar o `httprepl`, instale-o globalmente:

    dotnet tool install --global Microsoft.dotnet-httprepl

Conecte-se ao servidor

    httprepl http://localhost:5273 --swagger /swagger/v1/swagger.json

Comandos para o repl:

    ls
    ls -r
    cd {rota}
    get {rota}
    post -c {json stringificado} {rota} 

Consulte a 
[documentação](https://learn.microsoft.com/pt-br/aspnet/core/web-api/http-repl/?view=aspnetcore-7.0&tabs=linux) 
para mais informações.

## Melhorias

- Adicionar uma rota para edição de uma escola
- Adicionar uma rota para excluir uma escola

## Desafios

Esses desafios envolvem assuntos não vistos no vídeo, 
mas são bons pra treinar:

- Adicionar uma rota pra receber um arquivo CSV
com informações de escolas e adicioná-las no servidor
- Persistir dados das escolas (banco de dados PostgreSQL)
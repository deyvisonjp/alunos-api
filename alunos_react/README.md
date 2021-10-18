# ASP .NET Core - Consumindo uma Web API com React

### by Jose Carlos Macoratti

## Aula IV

- projeto criado com o comando . . . `npx create-react-app alunosreact`
- execução do projeto com . . . `npm start`

## [Aula V](https://youtu.be/Hc6wDjL_x_U)

### Recursos Adicionados e importados

`npm i bootstrap reactstrap axios`

- Bootstrap
- Janelas modais
- Imagem: Pasta assets
- Axios

_Na API, no arquivo startup . . ._

```
            // Define o cors para aplicação React está executando
            app.UseCors(options =>
            {
                options.WithOrigins("https://localhost:3000");
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });
```

**Erro ao copilar o código: Module not found: Error: Can't resolve 'jquery'** -
Resolvido com: `npm install jquery --save`

## [ASP .NET Core - Consumindo uma Web API com React - VI](https://youtu.be/hjAJisi_6n4)

... Continua

## ASP .NET Core - Consumindo uma Web API com React
### by Jose Carlos Macoratti

## Aula 1
- Instalações EntityFramework e EntityFrameworkSqlServer
- Criação da Model
- Criação e configuração Context
- Migration com:
	1. add-migration nomeMigration
	2. update-database

## Aula 2
1. Criação da pasta Service
	 1. Criação da interface IAlunoService
	 2. A partir da criação da Interface Criamos a classe AlunoService, que implemnta a Interface cirada anteriormente.
** FindAsync: Mais performático por buscar antes na memória (por exemplo FirstOrDefault)
2. Registrar o serviço de Aluno na classe Startup
3. Criar o controller

## Aula 3
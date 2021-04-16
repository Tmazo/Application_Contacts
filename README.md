# Aplicação de Clientes
Aplicação de clientes do tipo WebAPI, utilizando a linguagem de programação C# com o banco de dados MongoDb

### Arquivo JSON para utilizar os métodos no postman 
Application_Client.postman.json

## Pré requisitos
1. Baixar o arquivo JSON (Application_Client.postman.json) para utilização no postman;
2. Importar arquivo mencionado acima,no postman;
3. Ter o mongoDb instalado;
4. Possuir o C# instalado;
5. Possuir o Postman em sua maquina. 

## Inicio do processo de execução da aplicação
1 - Copie a aplicação para a sua máquina

## Executando a aplicação
No Visual Studio rodar aplicação pela API. Este campo fica ao lado do "Any CPU"


### Url API 
Caminho camada de API: `http://localhost:5000` ou `https://localhost:5001`

#### Recursos da API
base path: http://localhost:5001/swagger

| Método    | Recurso                      | Descrição                  |
|---------- |:-----------------------------|:---------------------------|
| `GET`     | `/Client`                    | Listar clientes            |
| `GET`     | `/Client/:id`				           | Visualizar cliente       |

| Método  	| Recurso                      | Descrição                 	|
|---------- |:-----------------------------|:--------------------------	|
| `POST`    | `/Client`                    | Cadastrar cliente         	|

| Método    | Recurso                      | Descrição                  |
|---------- |:-----------------------------|:---------------------------|
| `DELETE`  | `/Client/:id`                | Excluir Cliente        		|

| Método    | Recurso                      | Descrição                  |
|---------- |:-----------------------------|:--------------------------	|
| `PUT`     | `/Client`                    | Atualiza Cliente           |



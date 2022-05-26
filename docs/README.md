## Migration

1 - Setar o projeto de Infra.Data como principal a ser executado

2- Pelo PowerShell, entrar na pasta C:\dev\Estudos\back\TesteTecnomyl\src\TesteTecnomyl.Cadastros.Infra.Dados

3 - Executar o comando abaixo para setar o Ambiente em que deseja fazer o Migration
$Env:ASPNETCORE_ENVIRONMENT = "Development"


4 - Então, executar o comando abaixo para gerar o Migration, de acordo com o ambiente setado anteriormente
dotnet ef migrations add development --context DbTecnomyl -s C:\dev\Estudos\back\TesteTecnomyl\src\WebApi --verbose

5 - Após a geração do Migration, executar o comando abaixo para atualizar a DataBase
dotnet ef database update --context DbTecnomyl -s C:\dev\Estudos\back\TesteTecnomyl\src\WebApi --verbose


## Criar uma rede especial em modo bridge
docker network create --gateway 172.18.0.1 --subnet 172.18.0.0/16 dev-local

## Criar o volume
docker volume create pg-tecnomyl


## Executar o container do Postgres para a API Tecnomyl
docker run -ti --network=dev-local --ip 172.18.0.176 -p 5432:5432 --name pg-tecnomyl -e "POSTGRES_PASSWORD=123456" -v /var/lib/docker/volumes/pg-tecnomyl/_data:/var/lib/postgresql/data -d postgres



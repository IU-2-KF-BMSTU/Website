set DbUser=postgres
set DbPassword=root
set "DbConnectionString=Host=database;Username=postgres;Password=root;Database=BmstuWebsite"
echo %DbConnectionString%
docker-compose -f ./docker-compose.local.yml up --build
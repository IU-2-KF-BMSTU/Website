### Общая информация

--Развёртывание на сервере--
docker-compose.deploy.yml - используется для запуска приложения на сервере.
На сервере используется volumes->nginx-data. Данный раздел необходим для установки SSL сертификатов,
которые конфигурируются в Frontend\nginxconfigs\nginx.Production.conf

--Локальный запуск--
Для локального запуска использовать из текущей директории команды: 
docker-compose -f docker-compose.local.yml build
docker-compose -f docker-compose.local.yml up
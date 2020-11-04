# build
FROM node:10.15.1 AS build
WORKDIR /app
COPY Frontend ./
RUN npm i
ARG Environment=Production
ENV NODE_ENV=$Environment
RUN npm run build
# run
FROM nginx
ARG Environment=Production
COPY Frontend/nginxconfigs/nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/build /app
EXPOSE 80
EXPOSE 443
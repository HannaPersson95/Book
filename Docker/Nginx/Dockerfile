FROM nginx:latest


COPY bookapi.conf /etc/nginx/conf.d

EXPOSE 80
EXPOSE 81

CMD ["nginx", "-g", "daemon off;"]

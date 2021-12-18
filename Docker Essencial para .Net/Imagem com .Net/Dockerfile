FROM debian:10
LABEL key="1.0" description="Debian/Nginx"
RUN apt-get update && apt-get install -y nginx && apt-get clean
EXPOSE 8080
ENTRYPOINT ["/usr/sbin/nginx"]
CMD ["-g","daemon off;"]
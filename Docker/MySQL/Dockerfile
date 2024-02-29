FROM mysql:8.0.35

ENV MYSQL_ROOT_PASSWORD=gokstad

COPY user_book.sql /docker-entrypoint-initdb.d/
COPY book_db.sql /docker-entrypoint-initdb.d/

EXPOSE 3306
FROM mcr.microsoft.com/mssql/server:2022-latest

USER root
RUN apt-get update; apt-get install -y gnupg2 && apt-get install -y vim 

COPY --chmod=0755 setup.sql setup.sql
COPY --chmod=0755 setup_database.sh setup_database.sh
COPY --chmod=0755 entrypoint.sh entrypoint.sh

CMD /bin/bash ./entrypoint.sh

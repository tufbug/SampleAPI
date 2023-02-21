#!/usr/bin/env bash
sleep 20
./opt/mssql-tools/bin/sqlcmd -S localhost,1433 -U sa -P dmaz15haw@K@ -i setup.sql

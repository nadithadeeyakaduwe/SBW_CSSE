cd DatabaseCreation
for %%G in (*.sql) do sqlcmd /S .\ESHANSQLEXP -U sa -P "10170545" -i"%%G"
cd..
cd StoredProcedures
for %%G in (*.sql) do sqlcmd /S .\ESHANSQLEXP /d SarangaBatteryWork -U sa -P "10170545" -i"%%G"

pause
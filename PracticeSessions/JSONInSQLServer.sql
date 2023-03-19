SELECT DISTINCT 
    ClientMachine,
    ProgramName,
    LoginName,
    COUNT(LoginName) AS CALs
FROM 
    sys.dm_exec_sessions
GROUP BY 
    ClientMachine,
    ProgramName,
    LoginName
ORDER BY 
    CALs DESC;

	SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'sys.dm_exec_sessions';


select * from Members


Create table People (
	Id int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	JsonData nvarchar(max) NOT NULL
);

INSERT INTO People(JsonData)
values ('{
	"Name" : "Ishwor",
	"Age": 32,
	"Address": {
		"City": "Kathmandu",
		"State": "Bagmati",
		"Country": "Nepal"
	},
	"PhoneNumbers": [
		"9841 159415",
		"0410 356 835"
	]
}');

select * from People;

SELECT JSON_VALUE(JsonData, '$.Name') AS Name,
		JSON_VALUE(JsonData, '$.Age') AS Age,
		JSON_VALUE(JsonData, '$.Address.Country') AS Country,
		JSON_QUERY(JsonData, '$.PhoneNumbers') AS PhoneNumbers

	FROM People

	where ISJSON(JsonData) > 0
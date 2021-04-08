# CURD-Angular
This is a Angular + .net core+EF core + SQL server project
Json -server

Run a Json server:- json-server --watch db.json

Post command:=http://localhost:3000/Department  
{
    "id":1, //ID is required to pass in json server to insert record into json.db
    "departmentId":44,
    "departmentName":"Gitesh json-server"
    
}

{
  "Department": [
    {
      "departmentId": 13,
      "departmentName": "2323"
    },
    {
      "departmentId": 14,
      "departmentName": "t678"
    },
    {
      "departmentId": 7,
      "departmentName": "gitesh"
    },
    {
      "departmentId": 10,
      "departmentName": "343434rfgfdgfgfg"
    },
    {
      "departmentId": 22,
      "departmentName": "43434343"
    },
    {
      "departmentId": 434,
      "departmentName": "4343"
    },
    {
      "departmentId": 666,
      "departmentName": "tegfgfgfgfgfgfgfgfgst"
    }
  ]
}

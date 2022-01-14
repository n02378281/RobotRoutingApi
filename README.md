
Request:
**Body Parameters:**
 
      x	     int 
     
      y	     int
      
 loadId   	string
     
Example:
{
    "loadId": "231",
    "x":80,
    "y": 53
}

**Request headers:**

Content-type	application/json

**Resposne:**

{
    "robotId": "72",
    "distanceToGoal": 7.211102550927978,
    "batteryLevel": 32
}

**Request cURL:**
**cURL:**

curl --location --request POST 'http://localhost:5001/api/Robots/closest' \
--header 'Content-Type: application/json' \
--data-raw '{
    "loadId": "231",
    "x":50,
    "y": 3
}'

Please follow below steps:

1. Open Postman
2. Click Import
3. Raw text
4. Paste below curl:
curl --location --request POST 'http://localhost:5001/api/Robots/closest' \
--header 'Content-Type: application/json' \
--data-raw '{
    "loadId": "231",
    "x":50,
    "y": 3
}'

5. Continue
6. Import
7. Make sure application is running on visual studio
8. Send request on postman to see the result.

# Restuarant API

-[Resturuant API](#Restuarant-api)
 -[Auth](#auth)
    -[Register](#register)
      -[Register Request](#register-request)
      -[Register Response](#register-response)
    -[Login](#login)
      -[Login request](#Login-request)
      -[Login response](#Login-response)

  
    
## Auth

### Register

...js
POST {{host}}/auth/register
....

#### Register Request

...json
{
    "firstName": "Nick",
    "lastName": "Nuhu",
    "Email": "nickflinks@gmail.com",
    "Password": "Nicklas@9",
    "ConfirmPassword": "Nicklas@9"
}

#### Register Response

...json
200 ok
....

 #### Register Response

...json
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Nick",
    "lastName": "Nuhu",
    "Email": "nickflinks@gmail.com",
    "token": "eyjhb..hbbq";
}

#### Login Request

...json
{
    "Email": "nickflinks@gmail.com",
    "Password": "Nicklas@9";
}

#### Login Response

...json
200 ok
....
 
 #### Login Response

...json
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Nick",
    "lastName": "Nuhu",
    "Email": "nickflinks@gmail.com",
    "token": "eyjhb..hbbq";

}
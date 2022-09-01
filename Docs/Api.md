# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)
    - [Setting Secret](#setting-secret)
      - [Notice](#notice)
      - [Init](#init)
      - [Set](#set)
      - [List](#list)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "password": "Amiko1232!"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "d89c2d9a-eb2e-4075-95ff-b92920b55aa104",
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "token": "eyJhb..z9dqcnXoY"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "amichai@mantinband.com",
    "password": "Amiko1232!"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "d89c2d9a-eb2e-4075-95ff-b92920b55aa104",
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "token": "eyJhb..z9dqcnXoY"
}
```
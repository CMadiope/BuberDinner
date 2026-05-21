# Buber Dinner API

- [Buber Dinner API](#buber-Dinner-api)
  - [Create Dinner](#create-Dinner)
    - [Create Dinner Request](#create-Dinner-request)
    - [Create Dinner Response](#create-Dinner-response)
  - [Get Dinner](#get-Dinner)
    - [Get Dinner Request](#get-Dinner-request)
    - [Get Dinner Response](#get-Dinner-response)
  - [Update Dinner](#update-Dinner)
    - [Update Dinner Request](#update-Dinner-request)
    - [Update Dinner Response](#update-Dinner-response)
  - [Delete Dinner](#delete-Dinner)
    - [Delete Dinner Request](#delete-Dinner-request)
    - [Delete Dinner Response](#delete-Dinner-response)

## Create Dinner

### Create Dinner Request

```js
POST /Dinners
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Dinner..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create Dinner Response

```js
201 Created
```

```yml
Location: {{host}}/Dinners/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Dinner..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get Dinner

### Get Dinner Request

```js
GET /Dinners/{{id}}
```

### Get Dinner Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Dinner..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Dinner

### Update Dinner Request

```js
PUT /Dinners/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Dinner..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Dinner Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Dinners/{{id}}
```

## Delete Dinner

### Delete Dinner Request

```js
DELETE /Dinners/{{id}}
```

### Delete Dinner Response

```js
204 No Content
```
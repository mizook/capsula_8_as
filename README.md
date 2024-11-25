# SeedDataApi

Esta es una API REST creada en .NET que permite poblar una base de datos SQLite con datos semilla, ya sea al iniciar la aplicación o mediante un endpoint.

## Características

- Inicializa la base de datos con datos semilla.
- Endpoint para poblar la base de datos bajo demanda.
- Uso de herramientas como Mockaroo para generar datos realistas.

## Requisitos previos

Asegúrate de tener instalados los siguientes elementos antes de ejecutar el proyecto:

1. .NET 8.
2. SQLite (se incluye en el proyecto, no requiere instalación adicional).

## Instalación

1. Clonar este repositorio:

   ```
   git clone https://github.com/usuario/SeedDataApi.git
   cd SeedDataApi
   ```

2. Restaurar las dependencias del proyecto:

   ```
   dotnet restore
   ```

## Ejecutar

1. Ejecutar el proyecto en local:

   ```
   dotnet run
   ```

2. La API estará disponible por defecto en http://localhost:5002.

## Uso

### Poblar la base de datos

Realiza una solicitud POST al siguiente endpoint para poblar la base de datos:

```
POST /api/seed
```

### Despoblar la base de datos

Realiza una solicitud DELETE al siguiente endpoint para despoblar la base de datos:

```
DELETE /api/seed
```

## Contribuir

Este proyecto es un ejemplo educativo. Las contribuciones no son necesarias, pero puedes clonar y modificar el proyecto según tus necesidades.

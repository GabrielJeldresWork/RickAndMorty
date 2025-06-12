Prueba Tecnica - Carsales

Este repositorio contiene la solución a la prueba técnica solicitada. El proyecto esta dividido en dos carpetas:

- frontend/: Aplicación Angular 17 que consume una API REST intermedia para listar episodios de Rick and Morty.
- backend/: API REST desarrollada en .NET 8 que actua como intermediario entre el frontend y la API original de Rick and Morty.


Tecnologías que Utilicé

1) Frontend

- Angular 17
- Bootstrap 
- TypeScript

2) Backend

- .NET 8
- C#
- Swagger para documentación


Requisitos previos

- Node.js v20+
- Angular CLI
- .NET 8 SDK
- Git (opcional para clonar)



Ejecución del proyecto

 1. Clonar el repositorio

```bash
git clone https://github.com/GabrielJeldresWork/PruebaTecnicaCarsales.git
cd PruebaTecnicaCarsales
```

 2. Levantar el backend (.NET 8)

```bash
cd backend/ApiRickAndMorty

dotnet restore

dotnet run
```

Esto levantará la API en:
```
https://localhost:7270/api/episodio
```
Puedes probarla usando Swagger:
```
https://localhost:7270/swagger
```

3. Levantar el frontend (Angular 17)

En otra terminal:
```bash
cd frontend
npm install
ng serve
```

Esto iniciará la app Angular en:
```
http://localhost:4200
```

Características implementadas

- Listado de episodios con paginación
- Filtro de búsqueda por nombre o código
- Consumo de API Rick and Morty mediante API intermedia
- Manejo de errores en backend para páginas vacías o parámetros inválidos
- Swagger para prueba de endpoints
- URL base de la API configurada desde `appsettings.json`


Mejoras solicitadas implementadas

-  Mejoras en README.md
-  Filtro de búsqueda en Angular
-  Lectura de URL desde configuración (backend)
-  Migrado a .NET 8
-  Manejo de errores detallado en la API

---

Autor

Gabriel Jeldres
Desarrollador .NET / Angular

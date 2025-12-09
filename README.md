# 📘 NotasApp – Aplicación MVC por Capas con .NET y SQL Server

Este proyecto es una aplicación **ASP.NET MVC / .NET Core MVC** que implementa arquitectura por capas (**Presentación, Negocio y Datos**) y permite realizar operaciones **CRUD** sobre la tabla *Notas* usando **Entity Framework Core** y SQL Server.

---

## 1. Crear la Base de Datos

Antes de ejecutar la aplicación, debes crear la tabla **Notas** en tu base de datos SQL Server.

Ejecuta el siguiente script SQL:

```sql
CREATE DATABASE NOTASAPP;

USE NOTASAPP;

CREATE TABLE Notas (
    Id INT PRIMARY KEY IDENTITY,
	Contenido VARCHAR(1500) NOT NULL
);

INSERT INTO Notas (Contenido)
VALUES
('Revisión pendiente del informe semanal.'),
('Recordar enviar el correo a administración.'),
('Actualizar inventario de equipos de laboratorio.'),
('Preparar presentación para la reunión del viernes.'),
('Realizar respaldo de la base de datos.'),
('Contactar al proveedor para cotización.'),
('Revisar incidencias reportadas este mes.'),
('Planificar tareas para el próximo sprint.'),
('Verificar funcionamiento del módulo de autenticación.'),
('Anotar ideas para mejoras del sistema.');
```
---

##  2. Dirigirse al archivo *appsettings.json*

Después de crear la base de datos, debes configurar la cadena de conexión en el archivo:

```json
"ConnectionStrings": {
  "Default": "Server=TU_SERVIDOR;Database=NOTASAPP;Trusted_Connection=True;MultipleActiveResultSets=true"
}

```

## 3. Ejecutar el proyecto

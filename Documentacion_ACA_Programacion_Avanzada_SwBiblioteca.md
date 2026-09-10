# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**Corporación Unificada Nacional de Educación Superior – CUN**

**Programación Avanzada - 53304**

**Ingeniería de Sistemas**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
Kevin Santiago Sepúlveda Cortes

**Docente:**\
Verónica Castro Munar

**Fecha:**\
9 de Septiembre de 2026

------------------------------------------------------------------------

# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** Kevin Santiago Sepúlveda Cortes\
**Programa:** Programación Avanzada \
**Grupo:** 53304\
**Docente:** Verónica Castro Munar\
**Institución:** Corporación Unificada Nacional de Educación Superior – CUN\
**Año:** 2026

------------------------------------------------------------------------
# TABLA DE CONTENIDO

1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

# 1. INTRODUCCIÓN

El presente documento describe el desarrollo del Sistema de Gestión de Biblioteca, una aplicación de escritorio cuyo propósito es facilitar la administración de los procesos relacionados con el registro y control de libros, usuarios y préstamos dentro de una institución educativa.

Actualmente, este tipo de instituciones suele llevar la información de su biblioteca de forma manual, lo que genera pérdida de datos, errores en los registros y dificultad para consultar el estado de los préstamos en cualquier momento. Ante esta problemática, se planteó el desarrollo de un sistema de escritorio que permita administrar de manera organizada, rápida y confiable toda la información relacionada con la biblioteca, reduciendo así los errores propios del manejo manual y facilitando el acceso a la información cuando se requiera.

El sistema fue desarrollado utilizando C#, bajo el entorno de Windows Forms para la interfaz gráfica, y SQL Server como motor de base de datos, aplicando principios de Programación Orientada a Objetos y una arquitectura por capas, separando la lógica de acceso a datos del resto de la aplicación.

La aplicación se encuentra organizada en los módulos de Inicio, Libros, Usuarios, Autores, Editoriales, Préstamos, Reportes y Salida, permitiendo así gestionar de forma completa toda la información necesaria para el funcionamiento de la biblioteca.

------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar una aplicación de escritorio utilizando C# y SQL Server que permita
gestionar los procesos principales de una biblioteca, la administración de usuarios, como el registro de libros, autores y editoriales, el control de
préstamos y la generación de reportes, utilizando Programación Orientada a
Objetos, una base de datos relacional y una arquitectura por capas.


## 2.2 Objetivos específicos

- Diseñar e implementar una aplicación de escritorio para la gestión de
  libros, autores, editoriales, usuarios, préstamos y reportes.
- Aplicar principios de Programación Orientada a Objetos.
- Diseñar e implementar una base de datos relacional en SQL Server.
- Implementar operaciones CRUD para las entidades principales del sistema.
- Implementar el control de préstamos de libros dentro del sistema.
- Implementar la generación de reportes que faciliten la administración de
  la biblioteca.
- Implementar validaciones de datos ingresados por el usuario.
- Implementar manejo de excepciones.
- Aplicar una arquitectura por capas.
- Utilizar Git y GitHub para el control de versiones.
- Documentar técnica y funcionalmente el proyecto.

------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

Una institución educativa desea automatizar el proceso de administración de su biblioteca. Actualmente, toda la información relacionada con los libros, usuarios y préstamos se lleva de forma manual y escrita, lo cual ocasiona pérdida de información, errores en los registros y dificultad para consultar el estado de los préstamos.
Por esta razón, se propone desarrollar una aplicación de escritorio que permita optimizar y administrar la información de la biblioteca de manera organizada y eficiente.

## 3.2 Justificación

El desarrollo de este sistema es importante porque permite reemplazar el manejo manual de la información por un proceso automatizado, reduciendo los errores de registro de la información y la pérdida de datos. Además, facilita la consulta rápida del estado de los libros y los préstamos, optimizando las labores del personal encargado de la biblioteca y mejorando el control sobre el inventario disponible.

## 3.3 Alcance

El sistema permitirá:
- Gestionar libros. 
- Gestionar usuarios.
- Gestionar autores.
- Gestionar editoriales.
- Gestionar préstamos y actualizar su estado.
- Generar reportes y consultas sobre la información almacenada.

### Fuera del alcance

El sistema no cuenta, en esta versión, las siguientes funciones:
- Registro de devoluciones como proceso independiente.
- Inicio de sesión y manejo de roles de usuario (administrador, bibliotecario, etc.).
- Exportación de reportes en formato PDF o Excel; los reportes se consultan directamente dentro de la aplicación.
- Funcionamiento en red o multiusuario; el sistema está diseñado para ejecutarse en un solo equipo.

------------------------------------------------------------------------

# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información relacionada con libros, usuarios, autores, editoriales, controlar los prestamos y permitir la gestión de reportes dentro de la biblioteca.

## 4.2 Actores del sistema

| Actor | Descripción |
|---|---|
| Bibliotecario / Administrador | Encargado de registrar, consultar, actualizar o eliminar la información de libros, usuarios, autores y editoriales, así como de gestionar los préstamos y consultar los reportes generados por el sistema. |



## 4.3 Requerimientos funcionales

| Código | Requerimiento | Descripción |
|---|---|---|
| RF01 | Gestionar libros | Registrar, consultar, actualizar, eliminar y buscar libros. |
| RF02 | Gestionar autores | Registrar, consultar, actualizar y eliminar autores. |
| RF03 | Gestionar editoriales | Registrar, consultar, actualizar y eliminar editoriales. |
| RF04 | Gestionar usuarios | Registrar, consultar, actualizar y eliminar usuarios. |
| RF05 | Registrar préstamos | Registrar préstamos y actualizar su estado (marcar como devuelto). |
| RF06 | Generar reportes | Generar reportes y consultas sobre la información almacenada en el sistema. |

## 4.4 Requerimientos no funcionales

| Código | Requerimiento | Descripción |
|---|---|---|
| RNF01 | Usabilidad | La interfaz debe ser clara, sencilla y fácil de utilizar. |
| RNF02 | Validación | El sistema debe validar la información ingresada por el usuario. |
| RNF03 | Mantenibilidad | El código debe estar organizado y documentado. |
| RNF04 | Arquitectura | El sistema debe utilizar una arquitectura por capas. |
| RNF05 | Manejo de excepciones | Las operaciones deben manejar errores de forma controlada. |
| RNF06 | Integridad de datos | La información debe mantenerse consistente en la base de datos. |
| RNF07 | Consultas parametrizadas | Las consultas a la base de datos deben utilizar parámetros. |

## 4.5 Reglas de negocio

### RN01 — Código único del libro
No se permitirá registrar dos libros con el mismo ISBN.

### RN02 — Datos obligatorios
No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 — Usuario existente
No se podrá registrar un préstamo para un usuario inexistente.

### RN04 — Libro existente
No se podrá registrar un préstamo para un libro inexistente.

### RN05 — Disponibilidad
No se podrá prestar un libro cuando no existan ejemplares disponibles.

### RN06 — Actualización de disponibilidad
Al registrar un préstamo, la disponibilidad (existencias) del libro deberá actualizarse.

### RN07 — Actualización al marcar como devuelto
Al marcar un préstamo como devuelto, la disponibilidad (existencias) del libro deberá actualizarse nuevamente.

------------------------------------------------------------------------

# 5. CASOS DE USO

## 5.1 Descripción

El sistema es utilizado por el Bibliotecario o Administrador, quien es la única persona que interactúa con él. Desde ahí puede gestionar los libros, usuarios, autores y editoriales registrados, además de encargarse de los préstamos y consultar los reportes que genera el sistema.

## 5.2 Diagrama de casos de uso


> **Nota:** el diagrama incluye los casos de uso **Gestionar Categorías**, **Gestionar Devoluciones** y **Realizar Consultas**, sin embargo, estos no se llegaron a implementar en la versión final del sistema. Las categorías se manejan como un simple campo dentro del libro y no como un módulo aparte, las devoluciones se controlan actualizando el estado del préstamo ya existente, y las consultas del diagrama tampoco se desarrollaron como tal. En cambio, sí se agregó el módulo de **Reportes**, que no aparece reflejado en el diagrama.

## 5.3 Descripción de casos de uso

### **CU01 — Gestionar libros**

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar, consultar, actualizar, eliminar y
buscar libros dentro del sistema.

**Precondiciones:**
- El usuario debe tener acceso al sistema.

**Flujo principal:**
1. El actor entra al módulo de libros.
2. El sistema muestra los libros ya registrados.
3. El actor elige qué operación quiere hacer (registrar, editar, eliminar
   o buscar un libro).
4. El sistema procesa lo que el actor pidió.
5. El sistema muestra el resultado en pantalla.

**Flujos alternativos:**
- Si el actor deja algún campo obligatorio vacío, el sistema le muestra
  una advertencia y no deja continuar.
- Si el año o las existencias no son números válidos, el sistema también
  avisa y detiene la operación.

**Postcondiciones:**
- El libro queda registrado, actualizado o eliminado, según lo que se
  haya hecho.

### **CU02 — Registrar préstamo**

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar el préstamo de un libro a un usuario.

**Precondiciones:**
- El usuario debe existir en el sistema.
- El libro debe existir en el sistema.
- El libro debe tener existencias disponibles.

**Flujo principal:**
1. El actor selecciona al usuario que va a llevar el libro.
2. El actor selecciona el libro.
3. El sistema revisa si hay existencias disponibles.
4. El sistema registra el préstamo.
5. El sistema descuenta la existencia del libro.
6. El sistema confirma que el préstamo se registró correctamente.

**Flujos alternativos:**
- Si el libro no tiene existencias disponibles, el sistema no deja
  registrar el préstamo.

**Postcondiciones:**
- El préstamo queda guardado en el sistema.
- La disponibilidad del libro se actualiza.

### **CU03 — Actualizar estado del préstamo**

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite marcar un préstamo como devuelto, cambiando su
estado.

**Precondiciones:**
- Debe existir un préstamo previamente registrado.

**Flujo principal:**
1. El actor selecciona el préstamo que quiere actualizar.
2. El actor cambia el estado a "Devuelto" desde el ComboBox del
   formulario.
3. El sistema actualiza nuevamente la disponibilidad del libro.
4. El sistema confirma el cambio.

**Postcondiciones:**
- El estado del préstamo queda actualizado.
- El libro vuelve a estar disponible para un nuevo préstamo.

------------------------------------------------------------------------

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

El sistema está compuesto principalmente por los formularios encargados de cada módulo (libros, usuarios, autores, editoriales, préstamos y reportes), junto con la clase `Conexion`, responsable de establecer la comunicación con la base de datos. A continuación, se describen las clases más relevantes del sistema y la función que cumple cada una.

## 6.2 Diagrama de clases

Insertar aquí el diagrama de clases.

`![Diagrama de clases](ruta/al/diagrama-clases.png)`

> **Nota:** el diagrama anterior corresponde al modelo propuesto en la guía, con clases de entidad (`Libro`, `Autor`, `Usuario`, `Prestamo`, `DetallePrestamo`,`Categoria`, `Devolucion`). En la implementación real del proyecto no se crearon clases de modelo para cada entidad; los> datos se consultan y manipulan directamente dentro de cada formulario, usando `DataTable` y `SqlDataReader`. La única clase propia del proyecto es `Conexion`, encargada de la conexión a la base de datos.

## 6.3 Principales clases

| Clase | Responsabilidad |
|---|---|
| Conexion | Establecer y devolver la conexión hacia la base de datos, para que los formularios puedan utilizarla al momento de consultar o modificar la información. |
| Libros | Gestionar la interfaz y la lógica para registrar, consultar, actualizar, eliminar y buscar libros. |
| Usuarios | Gestionar la interfaz y la lógica para registrar, consultar, actualizar y eliminar usuarios. |
| Autores | Gestionar la interfaz y la lógica para registrar, consultar, actualizar y eliminar autores. |
| Editoriales | Gestionar la interfaz y la lógica para registrar, consultar, actualizar y eliminar editoriales. |
| Prestamos | Gestionar la interfaz y la lógica para registrar préstamos y actualizar su estado. |
| Reportes | Generar y mostrar los reportes y consultas del sistema. |

## 6.4 Aplicación de POO

**Clases:** se creó la clase `Conexion`, encargada de manejar la conexión
a la base de datos, además de los formularios (`FrmLibros`, `FrmAutores`,
etc.), que en C# también son clases, cada una con su propia
responsabilidad.

**Objetos:** dentro de cada formulario se crean objetos de tipo
`Conexion`, `SqlConnection`, `SqlCommand`, `SqlDataAdapter` y `DataTable`,
utilizados para conectarse a la base de datos y manejar la información
obtenida.

**Constructores:** se utilizó el constructor del formulario, por ejemplo
`FrmLibros()`, para inicializar los componentes de la interfaz y cargar
automáticamente la información de libros, autores y editoriales al abrir
la ventana.

**Métodos:** cada operación del sistema se implementó como un método
independiente, como `CargarLibros()`, `CargarAutores()`,
`ObtenerConexion()`, entre otros, con el fin de organizar el código y
evitar repetirlo.

**Propiedades:** se utilizaron propiedades tanto de los controles de la
interfaz (`Text`, `DataSource`, `SelectedValue`, etc.) como de la clase
`Conexion`, para acceder o modificar su información.

**Encapsulamiento:** la cadena de conexión se declaró como un campo
privado (`private string cadenaConexion`) dentro de la clase `Conexion`,
de modo que solo puede accederse a ella a través del método público
`ObtenerConexion()`.

**Colecciones:** se utilizaron objetos `DataTable` para almacenar y
mostrar temporalmente los datos obtenidos de la base de datos en los
controles `DataGridView` y `ComboBox`.

**Herencia:** los formularios del sistema heredan de la clase `Form`,
propia del framework de Windows Forms, lo cual les permite contar con las
propiedades y comportamientos básicos de una ventana.

**Polimorfismo y sobrecarga:** no se implementaron de forma explícita en
este proyecto, ya que no se manejaron métodos con múltiples firmas ni
clases derivadas propias del sistema.

------------------------------------------------------------------------

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

La base de datos `Biblioteca` está compuesta por cinco tablas: `Autores`, `Editoriales`, `Libros`, `Usuarios` y `Prestamos`, relacionadas entre sí mediante llaves foráneas, con el fin de organizar y mantener consistente la información del sistema.

## 7.2 Diagrama entidad-relación

Insertar aquí el modelo entidad-relación.

`![Modelo entidad-relación](ruta/al/modelo-entidad-relacion.png)`

## 7.3 Relaciones principales

- Un autor puede tener muchos libros.
- Una editorial puede tener muchos libros.
- Un usuario puede realizar muchos préstamos.
- Un libro puede estar asociado a muchos préstamos.
- Un préstamo puede contener uno o varios detalles.
- Un detalle de préstamo corresponde a un libro.

------------------------------------------------------------------------

# 8. DICCIONARIO DE DATOS

## 8.1 Convenciones

| Abreviatura | Significado |
|---|---|
| PK | Clave primaria |
| FK | Clave foránea |
| UQ | Campo con valor único |
| NULL | Campo que puede estar vacío |
| NOT NULL | Campo obligatorio |

## 8.2 Tabla: Autores

| Campo | Tipo de dato | Clave | Nulo | Descripción |
|---|---|---|---|---|
| IdAutor | INT | PK | No | Identificador único del autor. |
| Nombre | VARCHAR(100) | - | No | Nombre del autor. |
| Apellido | VARCHAR(100) | - | No | Apellido del autor. |

## 8.3 Tabla: Editoriales

| Campo | Tipo de dato | Clave | Nulo | Descripción |
|---|---|---|---|---|
| IdEditorial | INT | PK | No | Identificador único de la editorial. |
| Nombre | VARCHAR(150) | - | No | Nombre de la editorial. |

## 8.4 Tabla: Libros

| Campo | Tipo de dato | Clave | Nulo | Descripción |
|---|---|---|---|---|
| ISBN | VARCHAR(20) | PK | No | Identificador único del libro. |
| Titulo | VARCHAR(200) | - | No | Título del libro. |
| IdAutor | INT | FK | No | Autor asociado al libro. |
| IdEditorial | INT | FK | No | Editorial asociada al libro. |
| Categoria | VARCHAR(100) | - | Sí | Categoría del libro. |
| Anio | INT | - | Sí | Año de publicación. |
| Existencias | INT | - | No | Cantidad de ejemplares disponibles. |

## 8.5 Tabla: Usuarios

| Campo | Tipo de dato | Clave | Nulo | Descripción |
|---|---|---|---|---|
| IdUsuario | INT | PK | No | Identificador único del usuario. |
| Nombre | VARCHAR(100) | - | No | Nombre del usuario. |
| Apellido | VARCHAR(100) | - | No | Apellido del usuario. |
| Documento | VARCHAR(30) | UQ | No | Número de documento del usuario. |
| Telefono | VARCHAR(30) | - | Sí | Teléfono de contacto. |
| Correo | VARCHAR(150) | - | Sí | Correo electrónico. |

## 8.6 Tabla: Prestamos

| Campo | Tipo de dato | Clave | Nulo | Descripción |
|---|---|---|---|---|
| IdPrestamo | INT | PK | No | Identificador único del préstamo. |
| IdUsuario | INT | FK | No | Usuario que realiza el préstamo. |
| ISBN | VARCHAR(20) | FK | No | Libro prestado. |
| FechaPrestamo | DATE | - | No | Fecha en que se registró el préstamo. |
| FechaDevolucion | DATE | - | Sí | Fecha en que se marcó como devuelto. |
| Estado | VARCHAR(20) | - | No | Estado del préstamo (por ejemplo, "Prestado" o "Devuelto"). |

------------------------------------------------------------------------


# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla utilizando una arquitectura por capas, con el objetivo de separar las responsabilidades del sistema y facilitar su mantenimiento, organización y evolución.

La arquitectura está compuesta por:

1. Capa de Presentación.
2. Capa de Acceso a Datos.
3. Capa de Base de Datos.

> **Nota:** a diferencia del modelo de 4 capas propuesto en la guía, en este proyecto no se implementó una capa de Lógica de Negocio independiente. Las validaciones y reglas de negocio se manejan directamente dentro de la Capa de Presentación, en los métodos de cada formulario.

## 9.2 Diagrama de arquitectura

![Arquitectura del sistema](ruta/al/diagrama-arquitectura.png)

## 9.3 Capa de Presentación

**Responsabilidad:**
Es la capa mediante la cual el usuario interactúa con el sistema.
Además de mostrar la interfaz gráfica, también se manejan las validaciones de los datos ingresados y las reglas de negocio del sistema.

**Componentes:**
- FrmInicio
- FrmLibros
- FrmUsuarios
- FrmAutores
- FrmEditoriales
- FrmPrestamos
- FrmReportes

**Tecnología utilizada:**
- C#
- Formularios de Windows (Windows Forms)
- .NET.10

**Ejemplos de reglas manejadas en esta capa:**
- Validar que los campos obligatorios no estén vacíos.
- Validar que el año y las existencias sean valores numéricos validos.
- Validar disponibilidad de existencias antes de registrar un préstamo.
- Actualizar el estado del préstamo (marcar como devuelto).

## 9.4 Capa de Acceso a Datos

**Responsabilidad:**
Gestiona la comunicación entre la aplicación y SQL Server.

**Componentes:**
- Conexion

**Tecnologías utilizadas:**
- SQL Server.
- Microsoft.Data.SqlClient.
- Consultas parametrizadas.


## 9.5 Capa de Base de Datos

La información del sistema se almacena en:

**Base de datos:** `Biblioteca`

**Tablas principales:**

- Libros
- Usuarios
- Autores
- Editoriales
- Prestamos

## 9.6 Flujo de información

```Usuario
↓
Presentación (interfaz, validaciones y reglas de negocio)
↓
Acceso a Datos (clase Conexion)
↓
SQL Server
```

Las respuestas de la base de datos realizan el recorrido inverso hasta
llegar nuevamente a la interfaz.

------------------------------------------------------------------------

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de libros
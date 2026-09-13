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
12 de Septiembre de 2026

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
15. Anexos

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

![Diagrama de casos de uso](/Diagramas%20Biblioteca/Diagrama%20De%20Casos%20De%20Uso%20-%20Biblioteca%20.png)


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

![Diagrama de clases](/Diagramas%20Biblioteca/Diagrama%20De%20Clases%20-%20Biblioteca.png)

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

![Modelo entidad-relación](/Diagramas%20Biblioteca/Diagrama%20Entidad-Relación.png)

## 7.3 Relaciones principales

- Un autor puede tener muchos libros.
- Una editorial puede tener muchos libros.
- Un usuario puede realizar muchos préstamos.
- Un libro puede estar asociado a muchos préstamos.
- Un préstamo puede contener uno o varios detalles.
- Un detalle de préstamo corresponde a un libro.

------------------------------------------------------------------------

# 8. DICCIONARIO DE DATOS

## Diccionario de Datos

![Diccionario de datos](/Diagramas%20Biblioteca/Diccionario%20De%20Datos%20-%20Biblioteca%20.png)

> **Nota:** el diccionario de datos propuesto en la guía incluye las tablas `Categoria`, `DetallePrestamo` y `Devolución`. En la implementación real del proyecto estas tablas no existen: la categoría se maneja como un simple campo de texto dentro de `Libros`, y las devoluciones se controlan actualizando directamente el campo `Estado` de la tabla `Prestamos`, sin una tabla de detalle intermedia. Por esta razón, el diccionario de datos de esta sección refleja únicamente las cinco tablas realmente implementadas: `Autores`, `Editoriales`, `Libros`, `Usuarios` y `Prestamos`.

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

![Diagrama de arquitectura del sistema](/Diagramas%20Biblioteca/Arquitectura%20Del%20Sistema%20%20-%20Biblioteca%20.png)

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

Las respuestas de la base de datos realizan el recorrido inverso hasta llegar nuevamente a la interfaz.

------------------------------------------------------------------------

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de libros

**Objetivo:** Permitir la administración completa de la información de los libros disponibles en la biblioteca, incluyendo su registro, consulta, edición, eliminación y búsqueda.

**Interfaz:** El formulario `FrmLibros` está compuesto por un panel de búsqueda (`pnlBusqueda`) con un campo para buscar por ISBN; un panel de datos (`pnlDatos`) con los campos del libro (ISBN, título, categoría, año, existencias) junto con los `ComboBox` de autor y editorial; un panel de botones(`pnlBotones`) con las operaciones CRUD; y un `DataGridView` (`dgvLibros`) que lista todos los libros registrados.

**Clases y métodos utilizados:**
- `Conexion`: clase encargada de establecer la conexión con la base de datos.
- `CargarLibros()`: consulta y muestra todos los libros en el `DataGridView`.
- `CargarAutores()` / `CargarEditoriales()`: cargan los `ComboBox` deautor y editorial desde la base de datos.
- `btnBuscar_Click`: busca un libro por ISBN y muestra sus datos.
- `btnNuevo_Click`: limpia el formulario para un nuevo registro.
- `CargarLibroSeleccionado`: carga los datos de un libro al seleccionar una fila del `DataGridView`.
- `btnGuardar_Click`: valida los datos e inserta un nuevo libro.
- `btnEditar_Click`: valida los datos y actualiza un libro existente.
- `btnEliminar_Click`: elimina el libro seleccionado, previa confirmación.
- `btnCancelar_Click`: limpia el formulario y cancela la edición.

**Funcionalidades:**
- Registrar, consultar, actualizar, eliminar y buscar libros.

**Validaciones:**
- Todos los campos deben estar completos antes de guardar o editar un libro.
- El año y las existencias deben ser valores numéricos enteros.

## 10.2 Módulo de usuarios

**Objetivo:** Permitir la administración de la información de los
usuarios registrados en el sistema, quienes son las personas que pueden
solicitar préstamos de libros.

**Interfaz:** El formulario `FrmUsuarios` está compuesto por los campos
Nombre, Apellido, Documento, Teléfono y Correo (cada uno con su `Label`
y `TextBox`), los botones de operación (`btnNuevo`, `btnGuardar`,
`btnEditar`, `btnEliminar`, `btnCancelar`) y un `DataGridView`
(`dgvUsuarios`) que lista todos los usuarios registrados.

**Clases y métodos utilizados:**
- `Conexion`: clase encargada de establecer la conexión con la base de datos.
- `CargarUsuarios()`: consulta y muestra todos los usuarios en el
  `DataGridView`, y se ejecuta al cargar el formulario (`FrmUsuarios_Load`).
- `dgvUsuarios_CellDoubleClick`: carga los datos de un usuario al hacer doble clic sobre una fila del `DataGridView`.
- `btnNuevo_Click`: limpia el formulario para un nuevo registro.
- `btnGuardar_Click`: valida los datos e inserta un nuevo usuario.
- `btnEditar_Click`: valida los datos y actualiza el usuario seleccionado, identificado por `IdUsuario`.
- `btnEliminar_Click`: elimina el usuario seleccionado, previa confirmación.
- `btnCancelar_Click`: limpia el formulario y quita la selección del `DataGridView`.

**Funcionalidades:**
- Registrar, consultar, actualizar y eliminar usuarios.

**Validaciones:**
- Todos los campos (Nombre, Apellido, Documento, Teléfono y Correo)
  deben estar completos antes de guardar o editar un usuario.

## 10.3 Módulo de autores

**Objetivo:** Permitir la administración de la información de los autores registrados en el sistema, con el fin de asociarlos a los libros correspondientes.

**Interfaz:** El formulario `FrmAutores` está compuesto por los campos Nombre y Apellido (cada uno con su `Label` y `TextBox`), los botones de operación (`btnNuevo`, `btnGuardar`, `btnEditar`, `btnEliminar`, `btnCancelar`) y un `DataGridView` (`dgvAutores`) que lista todos los autores registrados.

**Clases y métodos utilizados:**
- `Conexion`: clase encargada de establecer la conexión con la base de datos.
- `CargarAutores()`: consulta y muestra todos los autores en el
  `DataGridView`, y se ejecuta al cargar el formulario (`FrmAutores_Load_1`).
- `dgvAutores_CellDoubleClick`: carga los datos de un autor al hacer doble clic sobre una fila del `DataGridView`.
- `btnNuevo_Click`: limpia el formulario para un nuevo registro.
- `btnGuardar_Click_1`: valida los datos e inserta un nuevo autor.
- `btnEditar_Click`: valida los datos y actualiza el autor seleccionado, identificado por `IdAutor`.
- `btnEliminar_Click`: elimina el autor seleccionado, previa confirmación.
- `btnCancelar_Click`: limpia el formulario.

**Funcionalidades:**
- Registrar, consultar, actualizar y eliminar autores.

**Validaciones:**
- Los campos Nombre y Apellido deben estar completos antes de guardar o editar un autor.

## 10.4 Módulo de editoriales

**Objetivo:** Permitir la administración de la información de las editoriales encargadas de la publicación de los libros registrados en el sistema.

**Interfaz:** El formulario `FrmEditoriales` está compuesto por el campo Nombre (con su `Label` y `TextBox`), los botones de operación (`btnNuevo`, `btnGuardar`, `btnEditar`, `btnEliminar`, `btnCancelar`) y un `DataGridView` (`dgvEditoriales`) que lista todas las editoriales registradas.

**Clases y métodos utilizados:**
- `Conexion`: clase encargada de establecer la conexión con la base de datos.
- `CargarEditoriales()`: consulta y muestra todas las editoriales en el `DataGridView`, y se ejecuta al cargar el formulario (`FrmEditoriales_Load`).
- `dgvEditoriales_CellDoubleClick`: carga los datos de una editorial al hacer doble clic sobre una fila del `DataGridView`.
- `btnNuevo_Click`: limpia el formulario para un nuevo registro.
- `btnGuardar_Click`: valida el dato e inserta una nueva editorial.
- `btnEditar_Click`: valida el dato y actualiza la editorial seleccionada, identificada por `IdEditorial`.
- `btnEliminar_Click`: elimina la editorial seleccionada, previa confirmación.
- `btnCancelar_Click`: limpia el formulario.

**Funcionalidades:**
- Registrar, consultar, actualizar y eliminar editoriales.

**Validaciones:**
- El campo Nombre debe estar completo antes de guardar o editar una
  editorial.

## 10.5 Módulo de préstamos

**Objetivo:** Permitir el registro y control de los préstamos de libros
realizados a los usuarios, manteniendo actualizada la disponibilidad de
cada libro.

**Interfaz:** El formulario `FrmPrestamos` está compuesto por un
`ComboBox` para seleccionar el usuario (`cmbUsuario`), un `ComboBox`
para seleccionar el libro (`cmbLibro`), dos `DateTimePicker` para la
fecha de préstamo (`dtpFechaPrestamo`) y la fecha de devolución
(`dtpFechaDevolucion`), los botones de operación (`btnNuevo`,
`btnGuardar`, `btnEditar`, `btnEliminar`, `btnCancelar`) y un
`DataGridView` (`dgvPrestamos`) que lista todos los préstamos
registrados.

**Clases y métodos utilizados:**
- `Conexion`: clase encargada de establecer la conexión con la base de datos.
- `CargarPrestamos()`: consulta y muestra todos los préstamos en el `DataGridView`.
- `CargarUsuarios()` / `CargarLibros()`: cargan los `ComboBox` de usuario y libro desde la base de datos.
- `dgvPrestamos_CellDoubleClick`: carga los datos de un préstamo al hacer doble clic sobre una fila del `DataGridView`.
- `btnNuevo_Click`: limpia la selección y restablece las fechas al día actual.
- `btnGuardar_Click`: valida la selección de usuario y libro, verifica que existan existencias disponibles, registra el préstamo y descuenta una existencia del libro.
- `btnEditar_Click`: registra la **devolución** del préstamo seleccionado (actualiza la fecha de devolución y el estado a "Devuelto"), y aumenta nuevamente la existencia del libro.
- `btnEliminar_Click`: elimina el préstamo seleccionado; si su estado era "Prestado", también devuelve la existencia al libro.
- `btnCancelar_Click`: limpia la selección y restablece las fechas.

**Funcionalidades:**
- Registrar préstamos.
- Registrar la devolución de un préstamo (a través del botón Editar).
- Eliminar préstamos.

**Validaciones:**
- Se debe seleccionar un usuario y un libro antes de guardar un préstamo.
- No se puede registrar un préstamo si el libro no tiene existencias disponibles.
- No se puede registrar la devolución de un préstamo que ya fue marcado como "Devuelto".
- Se debe marcar (`Checked`) la fecha de devolución antes de registrarla.

## 10.6 Módulo de reportes

**Objetivo:** Permitir la generación y consulta de reportes sobre la información almacenada en el sistema, con el fin de apoyar el control y seguimiento de la biblioteca.

**Interfaz:** El formulario `FrmReportes` está compuesto por un `ComboBox` (`cmbTipoReporte`) para seleccionar el tipo de reporte a generar, los botones `btnGenerar` y `btnLimpiar`, y un `DataGridView` (`dgvReportes`) donde se muestra el resultado del reporte seleccionado.

**Clases y métodos utilizados:**
- `Conexion`: clase encargada de establecer la conexión con la base de datos.
- `CargarTiposReporte()`: carga las opciones disponibles en el `ComboBox` de tipo de reporte.
- `btnGenerar_Click`: según el tipo de reporte seleccionado, ejecuta la consulta correspondiente y muestra el resultado en el `DataGridView`.
- `btnLimpiar_Click`: limpia la selección del `ComboBox` y el contenido del `DataGridView`.

**Reportes disponibles:**
- **Préstamos activos:** lista los préstamos con estado "Prestado", mostrando el usuario, el libro y la fecha de préstamo.
- **Préstamos devueltos:** lista los préstamos con estado "Devuelto", mostrando el usuario, el libro, la fecha de préstamo y la fecha de devolución.
- **Inventario de libros:** lista todos los libros junto con su autor, editorial, categoría, año y existencias disponibles.

**Funcionalidades:**
- Generar reportes de préstamos activos, préstamos devueltos e inventario de libros.
- Limpiar el reporte generado.

**Validaciones:**
- Se debe seleccionar un tipo de reporte antes de generarlo.

------------------------------------------------------------------------

# 11. CAPTURAS DE PANTALLA DEL SISTEMA

A continuacion se incluyen evidencias de las principales funcionalidades que brinda el sistema.

## 11.1 Menú principal

![Menú principal](/Capturas%20de%20pantalla%20del%20sistema/Captura%20menu%20principal.png)

**Descripción:** Pantalla inicial del sistema, desde la cual el usuario puede navegar hacia los módulos de Libros, Usuarios, Autores, Editoriales, Préstamos y Reportes.

## 11.2 Gestión de libros

![Gestión de libros](/Capturas%20de%20pantalla%20del%20sistema/Captura%20gestion%20de%20libros.png)

**Descripción:** Permite registrar, consultar, actualizar, eliminar y buscar libros por ISBN.

## 11.3 Gestión de usuarios

![Gestión de usuarios](/Capturas%20de%20pantalla%20del%20sistema/Captura%20gestion%20de%20usuarios.png)

**Descripción:** Permite registrar, consultar, actualizar y eliminar los usuarios que pueden solicitar préstamos.

## 11.4 Gestión de autores

![Gestión de autores](/Capturas%20de%20pantalla%20del%20sistema/Captura%20gestion%20de%20prestamos.png)

**Descripción:** Permite registrar, consultar, actualizar y eliminar los autores asociados a los libros.

## 11.5 Gestión de editoriales

![Gestión de editoriales](/Capturas%20de%20pantalla%20del%20sistema/Captura%20gestion%20de%20editoriales.png)

**Descripción:** Permite registrar, consultar, actualizar y eliminar las editoriales asociadas a los libros.

## 11.6 Registro de préstamos

![Registro de préstamos](/Capturas%20de%20pantalla%20del%20sistema/Captura%20gestion%20de%20prestamos.png)

**Descripción:** Permite registrar el préstamo de un libro a un usuario, así como tambien registrar su devolución y eliminar préstamos existentes.

## 11.7 Reportes

![Reportes](/Capturas%20de%20pantalla%20del%20sistema/Captura%20gestion%20de%20reportes.png)

**Descripción:** Permite generar reportes de préstamos activos, préstamos devueltos e inventario de libros.

---------------------------------------------

# 12. PRUEBAS DE FUNCIONAMIENTO

## 12.1 Estrategia de pruebas

El funcionamiento del sistema se verificó realizando pruebas manuales
sobre cada módulo, ingresando tanto datos válidos como datos inválidos
o incompletos, con el fin de comprobar que las validaciones y las
reglas de negocio se comportaran de la manera esperada.

## 12.2 Casos de prueba

| ID | Funcionalidad | Entrada / Acción | Resultado esperado | Resultado obtenido | Estado |
|---|---|---|---|---|---|
| CP01 | Registrar libro | Datos válidos | Libro registrado correctamente | Libro registrado correctamente | Aprobado |
| CP02 | Registrar libro | ISBN repetido | Mostrar mensaje de error | Mensaje de error mostrado | Aprobado |
| CP03 | Registrar usuario | Datos válidos | Usuario registrado correctamente | Usuario registrado correctamente | Aprobado |
| CP04 | Registrar préstamo | Libro con existencias disponibles | Préstamo registrado y existencias actualizadas | Préstamo registrado y existencias actualizadas | Aprobado |
| CP05 | Registrar préstamo | Libro sin existencias disponibles | No permitir el registro del préstamo | Préstamo no permitido | Aprobado |
| CP06 | Registrar devolución | Préstamo activo | Devolución registrada y existencias actualizadas | Devolución registrada y existencias actualizadas | Aprobado |
| CP07 | Generar reporte | Seleccionar "Inventario de libros" | Mostrar el listado de libros con su información | Listado mostrado correctamente | Aprobado |

**Prueba CP01 — Registrar libro con datos válidos**

![Evidencia CP01](/Capturas%20evidencias/Prueba%20CP01%20-%20Registrar%20libro%20con%20datos%20válidos.png)
![Evidencia CP01](/Capturas%20evidencias/Prueba%20CP01.1%20-%20Registrar%20libro%20con%20datos%20válidos.png)

**Resultado:** El libro se registró correctamente en la base de datos y
apareció de inmediato en el `DataGridView`, tal como se esperaba.

**Prueba CP02 — Registrar libro con ISBN repetido**

![Evidencia CP02](/Capturas%20evidencias/Prueba%20CP02%20-%20Registrar%20libro%20con%20ISBN%20repetido.png)

**Resultado:** El sistema detectó el ISBN repetido y mostró el mensaje
de error correspondiente, sin permitir que se duplicara el registro.

**Prueba CP03 — Registrar usuario con datos válidos**

![Evidencia CP03](/Capturas%20evidencias/Prueba%20CP03%20-%20Registrar%20usuario%20con%20datos%20válidos.png)

**Resultado:** El usuario se registró correctamente en la base de datos y apareció de inmediato en el `DataGridView`.

**Prueba CP04 — Registrar préstamo con libro disponible**

![Evidencia CP04](/Capturas%20evidencias/Prueba%20CP04%20-%20Registrar%20préstamo%20con%20libro%20disponible.png)

**Resultado:** El préstamo se registró correctamente y las existencias del libro se descontaron en uno, tal como se esperaba.

**Prueba CP05 — Registrar préstamo sin existencias disponibles**

![Evidencia CP05](/Capturas%20evidencias/Prueba%20CP05%20-%20Registrar%20préstamo%20sin%20existencias%20disponible.png)

**Resultado:** El sistema no permitió registrar el préstamo y mostró el mensaje de advertencia correspondiente.

**Prueba CP06 — Registrar devolución de un préstamo activo**

![Evidencia CP06](/Capturas%20evidencias/Prueba%20CP06%20—%20Registrar%20devolución%20de%20un%20préstamo%20activo.png)

![Evidencia CP06](/Capturas%20evidencias/Prueba%20CP06.1%20-%20Registrar%20devolución%20de%20un%20préstamo%20activo.png)

**Resultado:** La devolución se registró correctamente, actualizando el estado del préstamo a "Devuelto" y aumentando nuevamente las existencias del libro.

**Prueba CP07 — Generar reporte de inventario de libros**

![Evidencia CP07](/Capturas%20evidencias/Prueba%20CP07%20-%20Generar%20reporte%20de%20inventario%20de%20libros.png)

**Resultado:** El sistema mostró correctamente el listado completo de libros con su información asociada (autor, editorial, categoría, año y existencias).

# 13. CONCLUSIONES

**Conclusión 1**
Con el desarrollo de este proyecto se logró construir un sistema de escritorio funcional para la gestión de una biblioteca, capaz de administrar libros, autores, editoriales, usuarios y préstamos, dando solución al manejo manual de la información que presentaba la
institución.

**Conclusión 2**
Durante el desarrollo se aplicaron conceptos de Programación Orientada a Objetos, como el uso de clases, objetos, constructores, métodos, propiedades y encapsulamiento, además del uso de la herencia propia del framework de Windows Forms.

**Conclusión 3**
El uso de SQL Server como motor de base de datos, junto con la separación de la conexión en una clase independiente (`Conexion`), permitió mantener organizada la comunicación entre la aplicación y la información almacenada, facilitando su mantenimiento.

**Conclusión 4**
La parte más compleja del desarrollo fue el manejo correcto de la disponibilidad de los libros (existencias), ya que era necesario actualizarla tanto al registrar un préstamo como al registrar su devolución, asegurando que la información se mantuviera siempre consistente.

# 14. RECOMENDACIONES

Como posible mejora a futuro, me gustaría separar el registro de devoluciones del botón "Editar", y en general hacer que el módulo de préstamos sea más fácil de manejar y editar — por ejemplo, permitiendo modificar los datos de un préstamo (usuario, libro, fechas) de forma más clara, y no solo a través de una única acción que además cumple la función de devolución.

En cuanto a seguridad, sería importante agregar un inicio de sesión con roles de usuario (por ejemplo, administrador y bibliotecario), ya que actualmente cualquier persona que abra el programa tiene acceso completo a todas sus funciones.

Para facilitar el mantenimiento del sistema más adelante, sería bueno separar la lógica de negocio y el acceso a datos en clases propias, en lugar de tener las consultas directamente dentro de cada formulario como está actualmente.

Como nuevas funcionalidades, se podría agregar la opción de exportar los reportes a PDF o Excel, y también manejar la categoría como una entidad propia (con su propia tabla), en lugar de un simple campo de texto dentro del libro.

Por último, considero que valdría la pena hacer copias de seguridad periódicas de la base de datos, para evitar la pérdida de información en caso de algún fallo con el equipo donde se ejecuta el sistema.

# ANEXOS

## Anexo A. Repositorio GitHub

**Repositorio:** Para ingresar al repositorio dar click en: [Repositorio](https://github.com/KevinscrtRep/SwBiblioteca.git)

## Anexo B. Script de base de datos

**Archivo:** [Script_Biblioteca](/BaseDatos/Script_Biblioteca.sql)

## Anexo C. Evidencia de Git y GitHub


**Creación del repositorio y Commits realizados.**
![Repositorio](/Capturas%20evidencias/Commits%20realizados.png)

**Organización del proyecto.**
![Repositorio](/Capturas%20evidencias/Organizacion%20proyecto.png)

**Publicación del código.**
![Repositorio](/Capturas%20evidencias/Publicacion%20codigo.png)

**README**
Para ver la documentacion de click en:[README](/Documentacion%20Programacion%20Avanzada/Documentacion_ACA_Programacion_Avanzada_SwBiblioteca.md)

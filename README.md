# Proyecto_BD-POO_Grupo_9

### Tabla de Contenido:
<!--

Generated with [markedpp](#markedpp). Get [nodejs](https://nodejs.org) first

1. $ npm i -g markedpp
2. $ markedpp --github -o README.md README.md

-->

<!-- !toc (minlevel=2 omit="Table of Contents") -->
* [Proceso de cita](Documentacion)
* [Proceso de cita](#Proceso-de-cita)
    * [Ingresar datos al formulario](#Ingresar-los-siguientes-datos-en-el-formulario).
* [Protocolo del dia efectivo](#Protocolo-del-dia-efectivo)
    * [Prechequeo](#Prechequeo)
    * [Proceso de vacunacion](#Proceso-de-vacunacion)
<!-- toc! -->


 # Documentacion oficial <a name = "Documentacion"></a>
 -------------------------------------
  ## Aspectos tecnicos
| Sistema operativo: | Windows 10 |
|--------- |------|
| Sistema de gestion de base de datos: | SQL Server 19|
| Entorno Integrado SQL: | SQL Server Management Studio 18 (SSMS) |
| Entorno de Desarrollo Integrado: | JetBrains Rider 20221.1.1 |

| Paquete Nugget | Version |
| -------------- | ------- |
| Microsoft.EntityFrameworkCore | 5.0.7 |
| Microsoft.EntityFrameworkCore.SqlServer | 5.0.7 |
| Microsoft.EntityFrameworkCore.Design | 5.0.7 |

# Diseño de Software
---------
> Nombre del patron y clasificacion: Pipeline
##Intento:
> Procesa un dato en una serie de etapas, teniendo un aporte de una entrada inicial para luego almacenarla y realizar procesos con esta en las siguientes etapas.
## Explicacion: 
> El modelo de pipeline usa procesos ordenados en secuencia, en donde la informacion introducida funciona para los procesos que se realizaran con posteriodad, teniendo asi gran importancia los datos de entrada introducidos en el programa.
## Motivacion:    
> El proceso del manejo de citas requiere la manipulacion de datos durante distintas etapas, teniendo asi la necesidad de una estructura que facilite las operaciones y el traslado de los resultados obtenidos de regreso a la base de datos.   

## Participantes:
> * SignIn: Es la primera clase que se encontraria un usuario (Manager de citas) y donde se introducen los datos correspondientes para que sus credenciales sean almacenadas con la finalidad de ser verificadas por el sistema al inicializarse.
> * LogIn: En esta clase funciona como verificador de los datos introducidos en el SignIn, se buscan las credenciales enviadas con anterioridad a la base de datos por SignIn, comparandola con el input del login. Una vez se verificar que son correspondientes se le da acceso al usuario.
> * ProcesoCita: Es la primera clase en la que es necesaria la interaccion del manager con un miembro de la poblacion civil, los datos introducidos son enviados y almacenados a la base de datos para luego ser usados y procesados.
> * Prechequeo: El Prechequeo se encarga del proceso de datos de ProcesoCita, se utilizan datos ingresados con anterioridad para calcular cuando y donde sera la siguiente cita, asi como tambien es necesario introducir nueva informacion para complementar el proceso de vacunacion.
## Patrones Relacionados:
 * [Cadena de responsabilidad](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern)
 * [Active Object](https://en.wikipedia.org/wiki/Active_object)

# Manual de Usuario
## Creacion de un nuevo manager
* En dado caso no se tengan credenciales para ingresar al programa, es necesario crear un nuevo perfil de manager e
![alt text](blob:https://web.whatsapp.com/63cf61d9-a42d-4381-8b42-e585ee075abf)
## Proceso de cita <a name="Proceso-de-cita"></a> 
* Ingresar los siguientes datos en el formulario: <a name="Ingresar-los-siguientes-datos-en-el-formulario"></a>
    * DUI.
    * Nombre.
    * Direccion.
    * Domicilio actual.
    * Telefono de contacto (puede ser celular o fijo).
    * (Opcional) Correo electronico.
* Ingresar lista de enfermedades cronicas que padece.
* (Opcional) Ingresar si pertenece a institucion esencial.

## Protocolo del dia efectivo <a name="Protocolo-del-dia-efectivo"></a>
* Prechequeo: <a name="Prechequeo"></a>
    * Seleccionar "Seguimiento de citas".
    * Ingreso de identificacion. 
    * Ingresar el DUI para verificacion de datos. 
* Proceso de vacunacion: <a name="Proceso-de-vacunacion"></a>
    * Registrar fecha y hora.
    * Esperar a que se genere la fecha de 
    la cita para segunda dosis.

 

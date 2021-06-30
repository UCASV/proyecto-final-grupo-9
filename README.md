# Proyecto_BD-POO_Grupo_9

 # Documentacion oficial
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

#Diseño:
> NOmbre del patron y clasificacion: Pipeline
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

## Manual de Usuario

 

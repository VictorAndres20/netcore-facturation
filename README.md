# Víctor Andrés Pedraza - 2019
# Algunas especificacones a tener en cuenta para la prueba del software

Program language c#

###############
# Entregables
###############

- Database -> Contiene el script de la base de datos.
- CodigoFuente -> Contiene la carpeta del proyecto AppFacturacion

####################
# Aspectos técnicos
####################

- Desarrollado bajo entorno linux, distribución Ubuntu 16.04
- ASP.NET Core 2.2 - Patrón MVC
- Entity Framework Core 2.2.2
- Motor de base de datos SQL Server

##############################
# Requerimientos del sistema Linux y Windows
##############################

- Microsoft .NET Core SDK versión 2.2
- Microsoft SQL Server

##############################
# Abrir proyecto en Visual Studio 2017
##############################

Si se desea abrir el proyecto en Visual Studio 2017,
Abrir con Visual Studio 2017 el archivo AppFacturacion.csproj
que se encuentra dentro de CodigoFuente/AppFacturacion

###############################
# Configuración de conexión a base de datos SQL Server
###############################

En la carpeta raiz del proyecto AppFacturacion, hay un archivo llamado appsettings.json.
En este archivo se deberá cambiar la configuración de conexión:

"ConnectionStrings": {
    "FacturacionContext": "Server=<HOST>;Database=<NOMBRE BASE DE DATOS>;User Id=<USUARIO>;Password=<CONTRASEÑA>;"
  } 

Como ejemplo en Linux:

"ConnectionStrings": {
    "FacturacionContext": "Server=localhost;Database=facturacionstd;User Id=safacturacion;Password=Facturacion123*;"
  } 

Como ejemplo en Windows:

"ConnectionStrings": {
    "FacturacionContext": "Server=LAPTOP-6U9DQ622;Database=facturacionstd;User Id=safacturacion;Password=Facturacion123*;"
  } 
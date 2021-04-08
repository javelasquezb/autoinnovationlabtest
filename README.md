# Auto Innovation Lab Test
Prueba de desarrollo en .Net para la empresa Auto Innovation Labs 

# Descripcion de los proyecto:
    -autoinnovationlabtest.API : Web Api realizada en .Net 5
    -autoinnovationlabtest.Web : App Web realizada en .Net 5 Mvc
    -autoinnovationlabtest.Movil: App movil realizada en Xamarin

# Para la ejecucion del Web Api:
    1.- Ir a autoinnovationlabtest.API > appsettings.json y cambiar en la etiqueta ConnectionStrings > DefaultConnection el valor de Source con la instancia de base de datos a usar.
    2.- Abrir Package Manager Console
    3.- Seleccionar proyecto autoinnovationlabtest.Data y ejecutar el comando update-database
    4.- Click derecho al proyecto autoinnovationlabtest.API > Debug > Start New Instance
    5.- Se desplegara una pagina web con la herramienta swagger configurada con todos los metodos.

# Para la ejecucion del App Web:
    1.- Ir a autoinnovationlabtest.API > appsettings.json y cambiar la etiqueta UrlApi con el valor que entrego la pagina desplegada por el api con el siguiente formato: https//(direccion:puerto)/api/
    2.- Click derecho autoinnovationlabtest.Web > Debug > Start New Instance
    3.- Se desplegara una pagina web con toda la app web de prueba desarrollada

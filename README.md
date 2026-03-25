📔 Proyecto Agenda Personal IATEC

Este proyecto es una solución integral para la gestión de agendas personales y eventos compartidos, desarrollada con una arquitectura desacoplada (Backend API y Frontend Web).

🛠️ Configuración Inicial

1. Crear una base de datos en postgresSQL con el nobmre

           "bd_agenda"
2. configurar la contraseña del postgresql en

           /AgendaApi/appsettings.json
           "DefaultConnection": "Host=localhost;Database=bd_agenda;Username=postgres;Password=123456"

3.- Para ejecutar el proyecto en la terminal en la carpeta raiz

           dotnet restore

4.- entrar a AgendaApi y ejecutar
	
           cd AgendaApi
           dotnet ef database update
        
🏃‍♂️ Ejecución del Proyecto

Para que el sistema funcione correctamente, debes iniciar ambos servidores simultáneamente:Iniciar el Backend (API)
5.- se debe ejecutar tanto el backend y el froendt al mismo tiempo
      
           cd AgendaApi
           dotnet watch run 
      
           cd .\AgendaWeb
           dotnet watch run
      

🔑 Credenciales de PruebaPara que puedas evaluar todas las funcionalidades, puedes usar las siguientes cuentas ya creadas:
*********************************
Usuario: eddy@gmail.com
Contraseña: Password123!
*****************************
Usuario: lizeth@gmail.com
Contraseña: Password123!





Proyecto Hotel Arquitectura DDD - Pruebas Unitarias

Este proyecto forma parte del Trabajo Práctico de Laboratorio de Software, en el cual se implementa una arquitectura DDD (Domain-Driven Design) para gestionar un sistema de reservas de hotel. En este documento se describe el funcionamiento de las pruebas unitarias realizadas para validar la funcionalidad de los componentes del sistema.

Pruebas Unitarias
Las pruebas unitarias son esenciales para garantizar la calidad del software. Permiten verificar que cada componente del sistema funcione correctamente de manera aislada. En este proyecto, las pruebas unitarias se centran en el repositorio de clientes en memoria y en la clase Cliente.

Componentes Probados
Cliente
La clase Cliente representa un cliente del sistema y contiene las siguientes propiedades:

Id: Identificador único del cliente.
Nombre: Nombre del cliente.
Email: Correo electrónico del cliente.
Password: Contraseña del cliente.
FechaNacimiento: Fecha de nacimiento del cliente.
ClienteRepositorioEnMemoria
La clase ClienteRepositorioEnMemoria es una implementación de un repositorio en memoria que gestiona objetos de tipo Cliente. Proporciona métodos para listar, grabar y eliminar clientes.

Descripción de las Pruebas
Prueba: Listar Todos Los Clientes
Objetivo: Verificar que el repositorio pueda listar todos los clientes almacenados.
Escenario: Se agregan dos clientes al repositorio y se verifica que ambos clientes estén presentes al listar todos los clientes.
Validación: Se comprueba que la cantidad de clientes listados sea igual a 2 y que ambos clientes agregados estén presentes en la lista.
Prueba: Grabar Un Cliente
Objetivo: Verificar que el repositorio pueda agregar un nuevo cliente.
Escenario: Se agrega un cliente al repositorio y se verifica que este cliente esté presente en la lista de clientes.
Validación: Se comprueba que la cantidad de clientes listados sea igual a 1 y que el cliente agregado esté presente en la lista.
Prueba: Eliminar Un Cliente
Objetivo: Verificar que el repositorio pueda eliminar un cliente.
Escenario: Se agregan dos clientes al repositorio, se elimina uno de ellos y se verifica que solo el cliente no eliminado esté presente en la lista de clientes.
Validación: Se comprueba que la cantidad de clientes listados sea igual a 1, que el cliente eliminado no esté presente en la lista y que el cliente no eliminado sí esté presente.
Cómo Ejecutar las Pruebas
Para ejecutar las pruebas unitarias, sigue estos pasos:

Clona el Repositorio

Clona el repositorio y abre el proyecto en tu IDE preferido.
Instala las Dependencias

Asegúrate de tener todas las dependencias necesarias instaladas en tu entorno de desarrollo.
Ejecuta las Pruebas

Navega a la carpeta de pruebas en tu proyecto y ejecuta los tests utilizando el comando de tu framework de pruebas. Por ejemplo, si estás usando XUnit, puedes usar el comando:
bash
Copiar código
dotnet test
Revisa los Resultados

Revisa los resultados de las pruebas para asegurarte de que todas pasen correctamente. Si alguna prueba falla, revisa el código para identificar y corregir el problema.
Importancia de las Pruebas Unitarias
Las pruebas unitarias son cruciales para el desarrollo de software de calidad debido a los siguientes motivos:

Detección Temprana de Errores

Ayudan a detectar errores en etapas tempranas del desarrollo, lo que facilita su corrección antes de que se conviertan en problemas mayores.
Evitación de Regresiones

Aseguran que los cambios en el código no introduzcan nuevos errores, permitiendo que el sistema evolucione sin comprometer la estabilidad.
Documentación del Comportamiento

Documentan el comportamiento esperado de los componentes del sistema, lo que es útil para los desarrolladores actuales y futuros.
Facilitación del Mantenimiento

Facilitan el mantenimiento y la evolución del sistema, ya que las pruebas aseguran que el código siga funcionando correctamente después de las modificaciones.

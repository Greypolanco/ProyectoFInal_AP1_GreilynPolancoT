### Sistema de Compras
Este es un sistema de compras desarrollado en C# que permite llevar un registro de productos, el cual cuenta con la categoria correspondiente, proveedores, compras y sus detalles. El sistema se diseñó para ser utilizado por una empresa que requiere llevar un control de sus compras y los productos adquiridos.

####  Características
El sistema de compras incluye las siguientes características:

- Registro de productos: permite registrar nuevos productos, modificar su información y eliminar productos existentes. Cada producto se asigna a una categoría, aparte de que por defecto cada registro le asigna un Id.
- Categorias: este se encuentra en el contexto del programa dentro del ModelCreating, se especifica el Id que contiene esa categoria, el nombre y su total de inicio. (Cabe destacar que la cantidad total de la categoria dependera de los productos y su existencia en la cual se registran). 
- Registro de proveedores: permite registrar nuevos proveedores, modificar su información y eliminar proveedores existentes.
- Registro de compras: permite registrar compras realizadas a proveedores, especificando los productos adquiridos y la cantidad de cada producto comprado.
- Detalle de compra: muestra el detalle de cada compra realizada, incluyendo el proveedor, los productos adquiridos y la cantidad de cada producto, la igual que el costo y su total tanto en cantidad como en costo.

------------


#### Requisitos del sistema
- C#: el sistema fue desarrollado utilizando C#. Se requiere tener instalado Visual Studio para poder utilizar el sistema.
- Base de datos: se utiliza SQlite para almacenar los registros de productos, proveedores, compras y detalles de compra. Se requiere tener instalado SQL Managements y configurar correctamente las credenciales de acceso.

------------


#### Consultas
Este proyecto cuenta con funcionalidad de consultas que permiten filtrar datos de acuerdo a ciertos criterios. En particular, se puede filtrar por fecha o por algún otro campo del modelo de datos.

------------


#### Filtro por fecha
La función de filtro por fecha permite seleccionar un rango de fechas para consultar los datos que se encuentren dentro de ese rango. La consulta devuelve todos los registros que cumplan con esa condición.

Para utilizar la función de filtro por fecha, se debe seleccionar el rango de fechas utilizando los campos de fecha disponibles en el sistema. Luego, se debe hacer clic en el botón "Buscar" para obtener los resultados.

Filtro por otros datos del modelo
Además del filtro por fecha, se pueden realizar consultas filtrando por otros campos del modelo de datos. Por ejemplo, se puede buscar todos los registros que contengan un valor específico en algún campo determinado o con algun caracteter.

Para utilizar el filtro por otros datos del modelo, se deben seleccionar los criterios de búsqueda utilizando los campos disponibles en el sistema. Luego, se debe hacer clic en el botón "Buscar" para obtener los resultados.

cabe destacar que cada resgistro porpocionado en este proyecto cuenta con su consulta y el filtro de datos, esto con el fin de eficientizar la busqueda de datos dentro del sistema, ya realizado, con lo que en las consulta se proporciona un opcion donde el usuario puede ir a visualizar ese modelo ya registrado en el registro con el fin de poder ser modificado o eliminado.

------------


#### Uso del sistema
El sistema de compras es fácil de utilizar. Cuando lo ejecutes, verás un menú principal ubicado en la parte izquierda de la pantalla con las opciones disponibles:

- Registrar productos
- Modificar información de un producto existente
- Eliminar un producto existente
- Registrar proveedores
- Modificar información de un proveedor existente
- Eliminar un proveedor existente
- Registrar compras
- Ver detalle de una compra existente
- Salir

#### Conclusion
EL proyecto fue realizado en Blazor server , se utilizaron varias librerias como las de Radzen que proporcionaba la visualizacion de pequeños mensajes dentro de la pantalla, y personalizacion de la pantalla tanto con css y etiquetas HTML.

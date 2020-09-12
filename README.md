# 2020SAPractica5
Codigo del ejemplo que genera una simulación de un proceso de compra y envío de comida desde un restaurante hacia un cliente, a través de un repartidor. Para esto se implementaron tres microservicios para facilitar la comunicación entre los actores (cliente, restaurante, repartidor). El proceso inicia con el cliente realizando un pedido a través del consumo del microservicio de Cliente-Restaurante, mediante el cual puede estar verificando el estado de su pedido. El restaurante utiliza un microservicio para comunicar el estado del pedido y la solicitud de un repartidor para enviar dicho pedido. Por último, el repartidor y el cliente se comunican a través de un microservicio específico. Toda la simulación fue hecha a través de aplicaciones de consola de windows. 

## Especificación de API's 🚀
Esta práctica esta simulada utilizando tres microservicios tipo REST levantados desde un servidor local a través del framework de visual studio 2017. La descricpión de los microservicios utilizados se define a continuación:

### Microservicio Cliente-Restaurante
Este microservicio se levantó para poder tener funciones de comunicación para la recepción de pedidos de parte del cliente hacia el restaurante directamente. El cliente recibe el menú del restaurante a través de una petición GET y luego utiliza un elemento POST para enviar su pedido al restaurante. El restaurante envía actualización del estado del pedido a través de una función GET que es accedida por el cliente para visualizar la información: 

* GET /api/Menu -> Para obtener el menú del restaurante.
* POST /api/Menu/{id} -> Donde {id} es el número del combo que el cliente desa incluir en el pedido.
* GET /api/EstadoPedido -> Retorna el estado actual del pedido del cliente.
* PUT /api/EstadoPedido/{id} -> Actualiza el estado del pedido. 

### Microservicio Restaurante-Repartidor
Este microservicio se implementó para poder tener un medio de comunicación entre el restaurante y el repartidor, ya que a través de una función PUT el restaurante podía actualizar el estado del pedido a terminado, para que el repartidor pudiera tomar el pedido y trasladarlo al cliente:

* PUT /api/Repartidor/{id} -> Actualiza el estado del pedido entre el restaurante y el repartidor.

### Microservicio Cliente-Repartidor
Este microservicio se implementó para tener un feedback entre el cliente y el rapartidor en cuanto al pedido realizado. Para esto se utilizaron métodos GET y POST para poder comunicar a ambas aplicaciones:

* GET /api/PedidoTraslado/ -> Obtiene el estado del envío de pedido por parte del repartidor.
* POST /api/PedidoTraslado/{id} -> Actualiza el estado del envío desde el repartidor hacia el cliente.

## Construido con 🛠️

* [Visual Studio 2017](https://visualstudio.microsoft.com/es/) - El framework utilizado
* [C#] - Lenguaje de code-behind utilizado
* Tipo de servicios utilizado - REST

## Autores ✒️


* **Luis Carlos Valiente Salazar - 201122864** - *Desarrollo*

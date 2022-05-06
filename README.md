# PII Full GRASP and SOLID
## FIT
### Universidad Católica del Uruguay

En este programa trabajaremos con recetas de cocina que involucran ingredientes y equipamiento.

## Desafío(s)

️➡️ **Modifiquen el código provisto para evitar preguntar por el destino de la impresión en la clase AllInOnePrinter para imprimir en diferentes destinos -impresora o consola-.**

//Borre AllInOnePrinter y cree una interfaz con el metodo que utilizaria en cada clase
//Cree ConsolePrinter y FilePrinter, usando como interfaz Iprinter, usando el metodo definido en la interfaz pero con resultados diferentes
//defini un Iprinter y le asigne en un primer momento ConsolePrinter() y llame a la funcion 
//Luego le asigne a printer FilePrinter() y llame a la funcion

➡️ **¿Qué patrón o principio usan para asignar esta responsabilidad? Escriban la respuesta en comentarios en el código.** 

//Use el patron de Polymorphism, ya que la operacion de IPrinter es implementada por 2 tipos diferentes.
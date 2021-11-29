using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Una empresa de delivery debe implementar un sistema que permita el ingreso de pedidos por orden de llegada y además el
//ingreso de estos pedidos en una estructura de datos tipo árbol.
//Desarrolle lo siguiente:
//1) Elabore una demo que permita el ingreso de 5 pedidos y se almacenen en las dos estructuras de datos:
//Una estructura que guarde la información por orden de llegada.
//Una estructura de datos tipo árbol
//2) Muestre la lista de pedidos en orden de llegada y también estos pedidos en preorden, inorden y postorden.
//3) Finalmente, ingrese un nuevo pedido que tenga prioridad alta y muestre nuevamente la lista de pedidos en orden de
//llegada y también estos pedidos en preorden, inorden y postorden.


namespace EFCaso1
{
    public class Nodo
    {
        public int id;
        public int prioridad;
        public int costo;
        public string pedido;
        public string cliente;
        public Nodo anterior;
        public Nodo siguiente;
    }
}

using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(1, "Ceviche");
            arbol.InsertarNodo(2, "Chifa");
            arbol.InsertarNodo(3, "Makis");
            arbol.InsertarNodo(4, "Pollo a la brasa");
            arbol.InsertarNodo(5, "Pizza");

            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            arbol.BuscarPorLlave(5);
            Console.WriteLine("");

            arbol.BuscarPorValor(arbol.GetRaiz(), "Pizza", 0);
            Console.WriteLine("");

            arbol.Eliminar(arbol.GetRaiz(), 1);
            Console.WriteLine("");

            arbol.BuscarPorLlave(5);
            Console.WriteLine("");

            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.Read();
        }
    }
}
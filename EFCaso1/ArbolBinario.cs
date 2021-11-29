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
    class ArbolBinario
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.anterior);
                Console.WriteLine("{0}, valor {1}", raiz.prioridad, raiz.pedido);
                Inorden(raiz.siguiente);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("{0}, valor {1}", raiz.prioridad, raiz.pedido);
                Preorden(raiz.anterior);
                Preorden(raiz.siguiente);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.anterior);
                Postorden(raiz.siguiente);
                Console.WriteLine("{0}, valor {1}", raiz.prioridad, raiz.pedido);
            }
        }

        public void InsertarNodo(int prioridad, string pedido)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                prioridad = prioridad,
                pedido = pedido
            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (prioridad < puntero.prioridad)
                    {
                        puntero = puntero.anterior;
                        if (puntero == null)
                        {
                            padre.anterior = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.siguiente;
                        if (puntero == null)
                        {
                            padre.siguiente = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }

        public void BuscarPorValor(Nodo puntero, string pedido, int contador)
        {
            if (puntero != null)
            {
                contador += 1;
                if (puntero.pedido == pedido)
                {
                    Console.WriteLine("{0} encontrado en posición {1}", puntero.pedido, puntero.prioridad);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                BuscarPorValor(puntero.anterior, pedido, contador);
                BuscarPorValor(puntero.siguiente, pedido, contador);
            }
            else
            {
                Console.WriteLine("Total de iteraciones:" + contador);
            }
        }

        public void BuscarPorLlave(int llave)
        {
            int contador = 0;
            Nodo puntero = raiz;
            while (puntero != null)
            {
                contador += 1;
                if (puntero.prioridad == llave)
                {
                    Console.WriteLine("Llave {0} encontrada", puntero.prioridad);
                    Console.WriteLine("Valor de la llave: {0} ", puntero.pedido);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                else
                {
                    if (llave > puntero.prioridad)
                    {
                        puntero = puntero.siguiente;
                    }
                    else
                    {
                        puntero = puntero.anterior;
                    }
                }
            }
            Console.WriteLine("No se encontró la llave");
            Console.WriteLine("Total de iteraciones:" + contador);
        }

        public Nodo Eliminar(Nodo puntero, int llave)
        {
            if (puntero == null)
            {
                return puntero;
            }
            if (llave < puntero.prioridad)
            {
                puntero.anterior = Eliminar(puntero.anterior, llave);
            }
            if (llave > puntero.prioridad)
            {
                puntero.siguiente = Eliminar(puntero.siguiente, llave);
            }
            if (llave == puntero.prioridad)
            {
                if (puntero.anterior == null && puntero.siguiente == null)
                {
                    puntero = null;
                    return puntero;
                }
                else if (puntero.anterior == null)
                {
                    Nodo temp = puntero;
                    puntero = puntero.siguiente;
                    temp = null;
                }
                else if (puntero.siguiente == null)
                {
                    Nodo temp = puntero;
                    puntero = puntero.anterior;
                    temp = null;
                }
            }
            return puntero;
        }
    }
}

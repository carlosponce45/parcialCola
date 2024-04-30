using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cola
{
    public class Cola
    {
        Nodo inicio;
        Nodo fin;

        public Cola() 
        {
            inicio = null;
            fin = null;
        }

        public void insertar(int orden)
        { 
            Nodo nodo = new Nodo(orden);
            if (inicio == null)
            { 
                inicio = nodo;
                fin = nodo;
            }
            else 
            { 
                fin.siguiente = nodo;
                fin = nodo;
            
            }
        }
        public void listar(ListBox listaCola)
        {
            listaCola.Items.Clear();
            if (inicio == null) listaCola.Items.Add("Lista Vacia");
            else
            {
                Nodo actual = inicio;
                while (actual != null)
                {
                    listaCola.Items.Add(actual.orden);
                    actual = actual.siguiente;
                }
            }
        }

    }
}

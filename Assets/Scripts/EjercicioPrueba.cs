using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPrueba : MonoBehaviour {

    public int dias;
    int cantTotal = 0;
    public string codigo;

	void Start ()
    {
        if (dias >= 3)
        {
            switch (codigo)
            {
                case "G":
                    cantTotal = dias * 300;
                    break;

                case "PP":
                    cantTotal = dias * 400;
                    break;

                case "PG":
                    cantTotal = dias * 700;
                    break;

                default:
                    Debug.Log("Porfavor ingrese un código válido");
                    break;
            }

            if (cantTotal > 0)
            {
                Debug.Log("Para ese período se necesitan " + cantTotal + " gramos de alimento");
                Debug.Log("El costo total será de $" + (cantTotal / 100) * 80);
            }
        }
        else
        {
            Debug.Log("Porfavor ingrese una cantidad de días mayor a 3");
        }
	}
		
}

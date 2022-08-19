using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_Puntajes : MonoBehaviour
{

    [SerializeField] int[] puntajes = new int[10];

    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El nivel con menor puntaje es " + ObtenerNivelDeMenorPuntaje());
        Debug.Log("El promedio de puntos es " + ObtenerPuntajePromedio());
    }

    
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {
        int mayorPuntaje = 0;

        foreach (int puntaje in puntajes)
        {
            if(puntaje > mayorPuntaje)
            {
                mayorPuntaje = puntaje;
            }
        }

        return mayorPuntaje;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivelMenorPuntaje = 0;
        int MenorPuntaje = puntajes[0];
        for(int i = 0; i < puntajes.Length; i++)
        {
            if (puntajes[i] < MenorPuntaje)
            {
                MenorPuntaje = puntajes[i];
                indiceNivelMenorPuntaje = i;
            }
        }

        return indiceNivelMenorPuntaje;
    }

    float ObtenerPuntajePromedio()
    {
        float promedio = 0;
        float suma = 0;
        foreach (int num in puntajes)
        {
            suma += num;
        }
        promedio = suma / puntajes.Length;

        return promedio;
    }


}

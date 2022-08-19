using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_DiasYMeses : MonoBehaviour
{
    [SerializeField] string[] NombresMeses = new string[12];
    [SerializeField] int[] diasPorCadaMes = new int[12];
    public string fechaIngresada;

    
    void Start()
    {
        ValidarFormatoFecha(fechaIngresada);
    }


    bool ValidarFormatoFecha(string fecha)
    {
        bool FechaValida = false;

        if(fecha.Length == 4)
        {
            string dia = "";
            string mes = "";
            dia += fecha[0];
            dia += fecha[1];
            int DiaNumber=int.Parse(dia);
            Debug.Log(dia);
            mes += fecha[2];
            mes += fecha[3];
            int MesNumber = int.Parse(mes);
            if(DiaNumber > 0 && DiaNumber <= 31 && MesNumber>0 && MesNumber<=12)
            {
                FechaValida = true;
            }
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto");
        }

        return FechaValida;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioDinheiro : MonoBehaviour
{
    // Start is called before the first frame update

  
    [Header("Valor saque:")]
    [SerializeField] int retirada;

    void Start()
    {
      

        int duzentos = retirada/ 200;
        int notas200 = retirada - (retirada - duzentos);
        int restante200 = retirada - (200 * notas200);


        int cem = restante200 / 100;
        int notas100 = restante200 - (restante200 - cem);
        int restante100 = restante200 - (100 * notas100);


        int cinquenta = restante100 / 50;
        int notas50 = restante100 - (restante100 - cinquenta);
        int restante50 = restante100 - (50 * notas50);


        int vinte = restante50 / 20;
        int notas20 = restante50 - (restante50 - vinte);
        int restante20 = restante50 - (20 * notas20);

        int dez = restante20 / 10;
        int notas10 = restante20 - (restante20 - dez);
        int restante10 = restante20 - (10 * notas10);

        int cinco = restante10 / 5;
        int notas5 = restante10 - (restante10 - cinco);
        int restante5 = restante10 - (5 * notas5);

        int dois = restante5 / 5;
        int notas2 = restante5 - (restante5 - dois);
        int restante2 = restante5 - (5 * notas2);



        Debug.Log($"{notas200} : Notas de 200,00$, {notas100} : Notas de 100,00$, {notas50} : Notas de 50,00$, {notas20} : " +
              $"Notas de 200,00$, {notas10} : Notas de 10,00$ : {notas5} : Notas de 5,00$, {notas200} : Notas de 2,00$ ");

        
        
    }
}
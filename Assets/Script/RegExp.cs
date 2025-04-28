using UnityEngine;
using System.Text.RegularExpressions;

public class RegExp : MonoBehaviour
{


    //chaines a tester 

    string codePostal = "31000";


    //modele/ paterne
    string modele = "3";



    /* 
    ^ debut du modele 
    $ fin du modele 

 a|b       je veux un a ou un b 

 . n'importe quel caracter 
    \. caracter d'echappement 
    {n} n fois le caracter qui precede 
    {n,}n caracter minimum
    {n,m}



 */

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool test1 = Regex.IsMatch(codePostal,modele);

        if (test1)
        {
            Debug.Log("Ca marche");

        }
        else
        {
            Debug.Log("ca marcge pas");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

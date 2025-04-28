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
    {n,m} n cara minimu et m maximum 

    abc+ a suivi d'un b et suivi de 1 ou + de c (--> abc{1,})
    abc* a suivi d'un b et suivi de 0 ou + de c  (--> abc{0,}
    abc? a suivi d'un b et suivi de 0 ou 1 c (--> abc{1,}) 
    
    //split: decoupe une chaine donnée avec un paterne 

 */

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // 
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


    Match test2 =  Regex.Match(codePostal, modele); 
        
        if(test2.) 
    // Update is called once per frame
    void Update()
    {
        


    }
}

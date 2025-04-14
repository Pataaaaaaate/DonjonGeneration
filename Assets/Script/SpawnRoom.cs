using UnityEngine;

public class SpawnRoom : MonoBehaviour
{
    // lettres renseignant le type de template qu'on va utiliser 


    [SerializeField] private string doorDirection;

    private DonjonManager donjonManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // recup de la liste des salles dispos 

        donjonManager = GameObject.FindWithTag("Template").GetComponent<DonjonManager>(); 
        

    }

    
}

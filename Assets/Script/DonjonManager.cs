using UnityEngine;

public class DonjonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // tableau de toutes les salles 


    public GameObject[] roomList;

    // Quantité de salles max 

    [SerializeField] private int maxRooms = 20;
     private int spawednRooms = 0;

    // style du hud

    private GUIStyle style;
    void Start()
    {
        
    }

    private void OnGUI()
    {
        //parametrage
        style = new GUIStyle(GUI.skin.box);

        style.alignment = TextAnchor.MiddleLeft;

        style.padding.left = 10;

        //Affichage 
        GUI.Box(new Rect(10, 10, 160, 40), "Nbr total de salles: " + maxRooms +"\n", "Nbr de salles spawned: " + style);
    }

}

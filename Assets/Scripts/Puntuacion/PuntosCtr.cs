using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosCtr : MonoBehaviour
{
    //status: ok
    // Objetos privados
    public TextMeshProUGUI level;
    public TextMeshProUGUI points;

    // Objetos publicos
    public GameObject player;

    /* Start() (first method called)
     * Inicializa objetos segun la informacion en player.
     */
    private void Start()
    {
        level.text = level.text + " " + player.GetComponent<MiniGamesManager>().getLevel();
        points.text = points.text + " " + player.GetComponent<MiniGamesManager>().getCorrectAnsw();
    }

    /* exit() PUBLIC
     * metodo para la destruccion de la vista creada.
     */
    public void exit()
    {
        Destroy(gameObject);
    }
}

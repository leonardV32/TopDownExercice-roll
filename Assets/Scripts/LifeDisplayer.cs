using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDisplayer : MonoBehaviour
{
    public GameObject heart;

    private HealthBehaviour playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindWithTag("Player");
        playerHealth = player.GetComponent<HealthBehaviour>();
    }

    // Update is called once per frame
    public void UpdateHearts(int heartNumber) // permet d'itérer sur les éléments du tableau
    {
        foreach (Transform child in transform) // pouyr chacun des enfants dans le transform de l'objet ou ce script est appliqué
        {
            Destroy(child.gameObject); // on vide le tableau de tous ses coeurs
        }

        for (var i = 0; i < heartNumber; i++) // ici on vient instancier le bon nombre de coeurs
        {
            Instantiate(heart, Vector3.zero, Quaternion.identity, transform);
        }
    }

    //On a donc une boucle de destruction et instanciation à chaque appel de la fonction.
    private void Update()
    {
        UpdateHearts(playerHealth.currentHealth);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDisplayer : MonoBehaviour
{
    public GameObject heart;

    // Start is called before the first frame update
   
    // Update is called once per frame
    public void UpdateHearts(int heartNumber) // permet d'it�rer sur les �l�ments du tableau
    {
        foreach (Transform child in transform) // pouyr chacun des enfants dans le transform de l'objet ou ce script est appliqu�
        {
            Destroy(child.gameObject); // on vide le tableau de tous ses coeurs
        }

        for (var i = 0; i < heartNumber; i++) // ici on vient instancier le bon nombre de coeurs
        {
            Instantiate(heart, Vector3.zero, Quaternion.identity, transform);
        }
    }
}

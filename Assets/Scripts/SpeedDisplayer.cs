using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedDisplayer : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private new Rigidbody2D rigidbody2D;
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindWithTag("Player");
        rigidbody2D = player.GetComponent<Rigidbody2D>();
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
    }

    private void DisplaySpeed(float playerSpeed)
    {
        textMeshPro.text = playerSpeed.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        DisplaySpeed(rigidbody2D.velocity.magnitude);
        // la magnitude c'est la taille du vecteur de la vélocité 
       
    }
}

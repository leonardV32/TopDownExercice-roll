using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SpeedDisplayer : MonoBehaviour
{
    
    private TextMeshProUGUI textMeshPro;
    
    

    // Start is called before the first frame update
    void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    
    public void UpdateText(float playerSpeed)
    {
        textMeshPro.text = playerSpeed.ToString();
    }
}
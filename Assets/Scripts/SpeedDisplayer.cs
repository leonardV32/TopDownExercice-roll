using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedDisplayer : MonoBehaviour
{
    public PlayerSpeedTunnel playerSpeedTunnel;
    private TextMeshProUGUI textMeshPro;
    public float playerSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        playerSpeedTunnel.speedDisplayer = this;
    }
    public void UpdateText(float playerSpeed)
    {
        textMeshPro.text = playerSpeed.ToString();
    }

    private void OnDisable()
    {
        playerSpeedTunnel.speedDisplayer = null;
    }
}
using UnityEngine;

[CreateAssetMenu]
public class PlayerSpeedTunnel : ScriptableObject
{
    [HideInInspector]public SpeedDisplayer speedDisplayer;

    public void DisplaySpeed(float playerSpeed)
    {
        speedDisplayer.UpdateText(playerSpeed);
    }
}

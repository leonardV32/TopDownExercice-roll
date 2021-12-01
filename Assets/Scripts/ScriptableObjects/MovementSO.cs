using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]

public class MovementSO : ScriptableObject
{
    public float enemyspeed { get; private set; }

    //public Slider speedSet;

    void Awake()
    {   
        //var Slider = UI.Slider;
        //speedSlider = GetComponent<Slider.value>();
    }
    
    //newSpeed = speedSet.value
    public void SetSpeed(float newSpeed)
    {
        enemyspeed = newSpeed;
    }
    
    
}

using UnityEngine;
using UnityEngine.Events;

public class VelocityMove2DSOBased : Mover2D // même comportement que velocitymove2D
{
    // remplacer par un paramètre SO ennemi move
    //public MovementSO movement;   
    public float enemyspeed { get; set; }
    public UnityEvent<float> speedChanged;
    public void SetSpeed(float newSpeed)
    {
        enemyspeed = newSpeed;
    }

    public override void Move(Vector2 direction)
    {
        rigidbody2D.velocity = direction.normalized * enemyspeed;
    }
}

// appliquer la classe au ennemis et faire communiquer le slider avec


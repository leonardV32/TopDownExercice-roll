using UnityEngine;

public class VelocityMove2DSOBased : Mover2D // m�me comportement que velocitymove2D
{
    public float speed; // remplacer par un param�tre SO ennemi move

    public override void Move(Vector2 direction)
    {
        rigidbody2D.velocity = direction.normalized * speed;
    }
}

// appliquer la classe au ennemis et faire communiquer le slider avec


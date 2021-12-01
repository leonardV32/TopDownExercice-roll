using UnityEngine;

public class AddForceMove2D : Mover2D
{
    public float acceleration;
    public float maxSpeed;
    //public PlayerSpeedTunnel playerSpeedTunnel;
    public override void Move(Vector2 direction)
    {
        if (rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce(direction.normalized * acceleration);
        //playerSpeedTunnel.DisplaySpeed(rigidbody2D.velocity.magnitude);
    }
}

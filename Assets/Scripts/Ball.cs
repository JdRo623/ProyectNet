using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    [Header("Ball targets")]
    public Transform[] oponentTargets;
    public Transform[] playerTargets;

    [Header("Force components")]
    public float horizontal;
    public float vertical;
    public float depht;

    public enum Rotation {Topspin, Underspin, Nospin}; //Enum representing the three rotations

    private Vector3 initialPosition = new Vector3(0, 1.17f, -1.384f);
    private Rotation rotation = Rotation.Topspin;
    new private Rigidbody rigidbody;

    public void Start(){
        rigidbody = GetComponent<Rigidbody>();
    }

    /*
    Change the rotation property of the ball to topspin and calls the hitBall funcion whit the player parameter
    */
    public void topspin(int player){
        this.rotation = Rotation.Topspin;
        hitBall(player);
    }

    /*
    Change the rotation property of the ball to underspin and calls the hitBall funcion whit the player parameter
    */
    public void underspin(int player){
        this.rotation = Rotation.Underspin;
        hitBall(player);
    }
    
    /*
    Change the rotation property of the ball to nospin and calls the hitBall funcion whit the player parameter
    */
    public void nospin(int player){
        this.rotation = Rotation.Nospin;
        hitBall(player);
    }

    /*
    Sets the forces of the ball to 0 and applys a new force to the ball, the direction of the force on it's z component is defined by the player parameter
    */
    private void hitBall(int player){
        Vector3 dir;
        int position = (int)Random.Range(0.0f, 3.0f);
        if (!rigidbody.useGravity) rigidbody.useGravity = true;
        if (player == -1) dir = playerTargets[position].position - transform.position;
        else dir = oponentTargets[position].position - transform.position;
        rigidbody.velocity = new Vector3();
        rigidbody.AddForce(new Vector3(dir.x * horizontal, vertical, depht * player));
    }

    /*
    Resets the rotation, velocity, angular velocity and position of the ball to it's initial state when the ball hits the floor object
    */
    public void OnCollisionEnter(Collision collider){
        if(collider.transform.name.Equals("Floor")){
            resetBall();
        }
    }

    /*
     Resets the ball to it´s initial position
     */
    public void resetBall(){
        rigidbody.velocity = new Vector3();
        rigidbody.angularVelocity = new Vector3();
        rigidbody.useGravity = false;
        transform.position = initialPosition;
        transform.rotation = new Quaternion();
    }

}

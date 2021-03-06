using UnityEngine;

public class Tempoponent : MonoBehaviour
{
    [Header("Fisical Object")]
    public Ball ball;

    [Header("Atributes")]
    public int direction;

    //Use a random number generator to decide how to return the ball
    public void OnCollisionEnter(Collision colider)
    {
        if (colider.gameObject.name.CompareTo("Ball") == 0)
        {
            int spin = (int) Random.Range(0.0f, 3.0f);
            switch (spin)
            {
                case 0: 
                    ball.topspin(direction);
                    break;
                case 1:
                    ball.underspin(direction);
                    break;
                case 2:
                    ball.nospin(direction);
                    break;
                default:
                    break;
            }
        }
    }
}

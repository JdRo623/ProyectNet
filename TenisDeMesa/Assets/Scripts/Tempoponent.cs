using UnityEngine;

public class Tempoponent : MonoBehaviour
{
    public Ball ball;

    //Use a random number generator to decide how to return the ball
    public void OnCollisionEnter(Collision colider)
    {
        if (colider.gameObject.name.CompareTo("Ball") == 0)
        {
            int spin = (int) Random.Range(0.0f, 3.0f);
            switch (spin)
            {
                case 0: 
                    ball.topspin(-1);
                    break;
                case 1:
                    ball.underspin(-1);
                    break;
                case 2:
                    ball.nospin(-1);
                    break;
                default:
                    break;
            }
        }
    }
}

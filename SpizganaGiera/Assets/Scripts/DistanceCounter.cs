using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class DistanceCounter : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}

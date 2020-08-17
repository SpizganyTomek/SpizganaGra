using UnityEngine;
using UnityEngine.UI;
public class Distance : MonoBehaviour
{
    public Transform player;
    public Text distanceText;
    void Update()
    {
        distanceText.text = Mathf.Abs(player.position.x).ToString("0");
        
    }
}

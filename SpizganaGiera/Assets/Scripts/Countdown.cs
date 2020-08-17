using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public Text textBox;


    void Update()
    {
        GameObject orc = GameObject.Find("orc");
        Player player = orc.GetComponent<Player>();
        if (player.start >= 0)
        {
            textBox.text = Mathf.Round(player.start).ToString();
        } else if (player.Duration < player.durationRecharge)
        {
           textBox.text = "You're invincible!";
        } else
        {
             textBox.text = "ready";
        }
    }
}

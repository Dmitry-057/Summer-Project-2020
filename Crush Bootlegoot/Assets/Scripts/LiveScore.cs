
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LiveScore : MonoBehaviour
{
    public TextMeshProUGUI livesCounter;

    public void SubstractLive()
    {
        livesCounter.text = FindObjectOfType<PlayerHP>().lives.ToString();
    }

    public void AddLive()
    {

    }

}

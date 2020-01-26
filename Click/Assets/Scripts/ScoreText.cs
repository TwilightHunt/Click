using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;

    private void Update()
    {
        int allCoins = Click.coin;
        GetComponent<Text>().text = $"{allCoins}";
    }

}

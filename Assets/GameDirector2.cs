using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
    GameObject hpGauge2;

    void Start()
    {
        this.hpGauge2 = GameObject.Find("hpGauge2");
    }
    public void DecreseHp2()
    {
        this.hpGauge2.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.hpGauge2.GetComponent<Image>().fillAmount <= 0.01f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}


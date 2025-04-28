using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //¶–îˆó‚ª‰Ÿ‚³‚ê‚½
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1, 0, 0); //¶‚É3“®‚©‚·
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }
    }
}

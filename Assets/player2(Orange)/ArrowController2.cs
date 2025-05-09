using UnityEngine;

public class ArrowController2 : MonoBehaviour
{
    GameObject player2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player2 = GameObject.Find("player_2");
    }
    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で落下させる
        transform.Translate(0, -0.005f, 0);

        //画面外に出たらオブジェクトを破棄する
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player2.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d<r1+r2)
        {
            //監督スクリプトにプレイやと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector2");
            director.GetComponent<GameDirector2>().DecreseHp2();

            //衝突した場合は矢を消す
            Destroy(gameObject);
        }
    }
}

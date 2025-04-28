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
        //�t���[�����Ƃɓ����ŗ���������
        transform.Translate(0, -0.005f, 0);

        //��ʊO�ɏo����I�u�W�F�N�g��j������
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player2.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d<r1+r2)
        {
            //�ēX�N���v�g�Ƀv���C��ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector2");
            director.GetComponent<GameDirector2>().DecreseHp2();

            //�Փ˂����ꍇ�͖������
            Destroy(gameObject);
        }
    }
}

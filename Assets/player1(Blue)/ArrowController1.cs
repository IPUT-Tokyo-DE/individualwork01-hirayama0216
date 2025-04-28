using UnityEngine;

public class ArrowController1 : MonoBehaviour
{
    GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("player_1");
    }
    // Update is called once per frame
    void Update()
    {
        //�t���[�����Ƃɓ����ŗ���������
        transform.Translate(0, -0.03f, 0);

        //��ʊO�ɏo����I�u�W�F�N�g��j������
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d<r1+r2)
        {
            //�ēX�N���v�g�Ƀv���C��ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreseHp();

            //�Փ˂����ꍇ�͖������
            Destroy(gameObject);
        }
    }
}

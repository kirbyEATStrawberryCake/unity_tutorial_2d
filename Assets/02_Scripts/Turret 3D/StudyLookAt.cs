using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePos; // �߻� ��ġ

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        turretHead.LookAt(targetTf.GetChild(0));

        timer += Time.deltaTime; // -> Ÿ�̸��� ����� ��
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            //            ���� ���    ����� ���� ��ġ  ����� ȸ�� ����
        }
    }
}

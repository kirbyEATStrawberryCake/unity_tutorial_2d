using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePos; // 발사 위치

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        turretHead.LookAt(targetTf.GetChild(0));

        timer += Time.deltaTime; // -> 타이머의 기능을 함
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            //            생성 대상    대상의 생성 위치  대상의 회전 상태
        }
    }
}

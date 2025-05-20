using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1f;
    void Start()
    {
    }
    // ���⼭ this�� �� ��ũ��Ʈ�� ����ִ� gameobject �̸��̴�.

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }
    }



}

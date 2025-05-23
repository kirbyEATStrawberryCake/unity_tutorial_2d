using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector3 pos;
    [SerializeField] private Quaternion rot;

    private void Awake()
    {
        CreateCharacter();

    }
    private void Start()
    {
    }

    private void CreateCharacter()
    {
        GameObject obj = Instantiate(prefab, pos, rot); // GameObject를 생성하는 기능
        obj.name = "플레이어 캐릭터";

        Transform objTrans = obj.transform;
        int count = objTrans.childCount;
        // Instantiate(prefab, pos, rot).name = "플레이어 캐릭터";
        // 로 적어도 되지만 가독성이 좋지 않음.

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTrans.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTrans.GetChild(count - 1).name}");
        
    }
}

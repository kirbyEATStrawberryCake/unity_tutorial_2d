using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Study_Component : MonoBehaviour
{
    public GameObject obj;

    public Mesh objMesh;
    public Material objMat;


   // public GameObject obj = new GameObject();
    // �̰� �ȵ�. ��Ÿ�ӿ��� �����Ǵ°� �ƴϱ� ����.

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CreateCube();
        CreateCube("Hellow World");
    }

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name); // �̰� ��.
        // obj = new GameObject();
        // obj.name = "Cube";

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = objMesh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = objMat;

        obj.AddComponent<BoxCollider>();
    }

}

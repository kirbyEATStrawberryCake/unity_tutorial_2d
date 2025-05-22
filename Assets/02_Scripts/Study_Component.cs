using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Study_Component : MonoBehaviour
{
    public GameObject obj;

    public Mesh objMesh;
    public Material objMat;


   // public GameObject obj = new GameObject();
    // 이거 안됨. 런타임에서 생성되는게 아니기 때문.

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CreateCube();
        CreateCube("Hellow World");
    }

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name); // 이건 됨.
        // obj = new GameObject();
        // obj.name = "Cube";

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = objMesh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = objMat;

        obj.AddComponent<BoxCollider>();
    }

}

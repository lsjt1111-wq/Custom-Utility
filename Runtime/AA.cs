using LEETest;
using UnityEngine;

public class AA : MonoBehaviour
{
    public GameObject test;
    public Rigidbody rb;

    void Start()
    {
        transform.ResetLocal();
        transform.DestoryChildren();

        Debug.Log($"더한 값 : {MyMath.Add(5, 3)}");
    }

    void Update()
    {
        
    }
}

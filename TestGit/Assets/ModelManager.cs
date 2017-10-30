using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour
{
    private int tag = 0;

	void Start () {
        Debug.Log("git测试");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Time.deltaTime * 280);
	}

    private void PrintMsg()
    {
        Debug.Log("小郭提交的一个方法");
    }
}

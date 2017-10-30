using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour
{
    private int tag = 2;
    
    private string model_name = "hello";

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
    
    public void SetVisible(bool visible){
    	gameObject.SetActive(visible);
    }
}

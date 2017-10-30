using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour {

	void Start () {
        Debug.Log("git测试");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Time.deltaTime * 30);
	}
}

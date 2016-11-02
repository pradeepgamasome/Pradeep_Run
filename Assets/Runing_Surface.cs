using UnityEngine;
using System.Collections;

public class Runing_Surface : MonoBehaviour {
	public GameObject g;
	public float z=30;
	//public float  val=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
//		if (val ==100) {
//			Instantiate (g,new  Vector3(0, 0,30), Quaternion.identity);
//			val=0;
//		}


		transform.position = new Vector3 (0, 0, z);
		z--;
		if (this.transform.position.z <-8) {
			z = 10;
		}


		//val++;
	}
}

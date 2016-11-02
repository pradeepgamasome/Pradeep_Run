using UnityEngine;
using System.Collections;
using System.IO;

public class Running_Player : MonoBehaviour {
	float speed;
	int score=0;
	int count=0;
	float position=3;
	float pos_x=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			pos_x = -3;
			transform.position = new Vector3 (pos_x, 0, 0);


		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			pos_x = 3;
			transform.position = new Vector3 (pos_x, 0, 0);


		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) 
		{
			position = 25;

				transform.position = new Vector3 (0, position, 0);


			}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {

			pos_x = 0;
			position = 3;
			transform.position = new Vector3 (pos_x,position, 0);


		}






	if(position>3)
	{
		position--;
	}
		if (pos_x < -2) {
			pos_x++;
		}
		if (pos_x > 2) {
			pos_x--;
		}

		transform.position = new Vector3 (pos_x, position, 0);
		if (count == 10) {
			score++;
			print (score);
			count = 0;
		}
		count++;
	}


}
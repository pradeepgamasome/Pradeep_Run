using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameEventManager : MonoBehaviour {
	public float count;
	float pos_z=100;
	int index;
	//float pos_x=0;


	public List<GameObject> obstacle_list;



	public List<GameObject> obstacle_gameplay_list;
	public List<int> Obstacle_Values;


	// Use this for initialization
	void Start () {
	
		//for(int i=0;i<obstacle_list.Count;i++)



	}
	
	// Update is called once per frame
	void Update () {
		


//
//		if (count == 100) 
//		{	
//
//			obstacle_gameplay_list.Add((GameObject)Instantiate (obstacle_list [Random.Range (0, obstacle_list.Count)], new Vector3 (0,0,0), Quaternion.identity));
//			count = 0;
//			pos_z = 100;
//		}
//		count++;
//		for(int i=0;i<obstacle_gameplay_list.Count;i++)
//		{
//			obstacle_gameplay_list[i].transform.position = new Vector3 (this.transform.position.x, 0, pos_z);
//		pos_z--;
//		}
		//index=Random.Range(0,obstacle_list.Count);


		if (count == 100) 
		{
			count = 0;
			

			Creat_Obstacle ();

			pos_z = 100;

		}



		count++;

		for(int i=0;i<obstacle_gameplay_list.Count;i++)
				{
			obstacle_gameplay_list[i].transform.Translate(Vector3.back *40*Time.deltaTime);//				transform.position = new Vector3 (0, 0,pos_z+Time.deltaTime);
		
			//pos_z--;
				}



	}

	void Creat_Obstacle()
	{

		obstacle_gameplay_list.Add ((GameObject)Instantiate (obstacle_list[Random.Range(0,obstacle_list.Count)], new Vector3 (0, 0,Random.Range(30,50)), Quaternion.identity));
	}
}

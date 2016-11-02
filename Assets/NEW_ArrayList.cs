using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NEW_ArrayList : MonoBehaviour {
	public ArrayList al= new ArrayList();
	public ArrayList al1=new ArrayList();
	IList<int> List1=new List<int>();
	// Use this for initialization
	void Start () {


		for (int i = 0; i < 45; i++) 

		{

			al.Add (i+3);
		}
		print ("Arrya added");
		foreach (int i in al) 
		{
			print ("The value of :" + i + "is :-");
			print (i);
		}

	

		al1.Add (45);
		al1.Add (145);
		al1.Add (455);
		al1.Add (451);
		al1.Add (88475);
		al1.Add (845);
		al1.Sort();
		foreach (int i in al1) {
			print ("the value of the new array ");
			print (i);
		}

		List1.Add (1);


	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

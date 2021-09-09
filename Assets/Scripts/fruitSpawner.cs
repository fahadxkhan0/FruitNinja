using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour {

	public GameObject fruit;
	public float maxX;
	public GameObject bomb;

	// Use this for initialization
	void Start () {
		//startSpawn();
		Invoke ("startSpawn",1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startSpawn(){
		InvokeRepeating ("spawnFruitGroup",1f,7f);
		InvokeRepeating ("bombSpawner",8f,9f);
	     // spawnFruitGroup();
	}
	public void stopSpawn(){
		CancelInvoke ("spawnFruitGroup");
		StopCoroutine ("spawnFruit");

	}

	public void spawnFruitGroup(){
		
		StartCoroutine ("spawnFruit");
		//if(Random.Range(0,6)>4){
           //bombSpawner();
		//}
		

		
		
	}
	public void bombSpawner(){
		float rrand = Random.Range (-maxX, maxX);
		Vector3 poooS = new Vector3 (rrand, transform.position.y, 0);
		GameObject a = Instantiate (bomb, poooS, Quaternion.identity) as GameObject;
		a.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		a.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-70f,70f));
	}



	IEnumerator spawnFruit(){

		//for(int i = 0; 0 < 5; i++){

		float Rand = Random.Range (-maxX, maxX);
		Vector3 pos = new Vector3 (Rand, transform.position.y, 0);
		GameObject f = Instantiate (fruit, pos, Quaternion.identity) as GameObject;
		f.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		f.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		yield return new WaitForSeconds (0.5f);
		//}

		float rand = Random.Range (-maxX, maxX);
		Vector3 Pos = new Vector3 (rand, transform.position.y, 0);
		GameObject g = Instantiate (fruit, Pos, Quaternion.identity) as GameObject;
		g.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		g.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		yield return new WaitForSeconds (0.5f);

		float Raand = Random.Range (-maxX, maxX);
		Vector3 poos = new Vector3 (Raand, transform.position.y, 0);
		GameObject h = Instantiate (fruit, poos, Quaternion.identity) as GameObject;
		h.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		h.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		yield return new WaitForSeconds (0.5f);

		float Rannd = Random.Range (-maxX, maxX);
		Vector3 poss = new Vector3 (Rannd, transform.position.y, 0);
		GameObject j = Instantiate (fruit, poss, Quaternion.identity) as GameObject;
		j.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		j.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		yield return new WaitForSeconds (0.5f);

		float Randd = Random.Range (-maxX, maxX);
		Vector3 ppos = new Vector3 (Randd, transform.position.y, 0);
		GameObject k = Instantiate (fruit, ppos, Quaternion.identity) as GameObject;
		k.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		k.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		yield return new WaitForSeconds (0.5f);

		float Rrand = Random.Range (-maxX, maxX);
		Vector3 pooos = new Vector3 (Rrand, transform.position.y, 0);
		GameObject l = Instantiate (fruit, pooos, Quaternion.identity) as GameObject;
		l.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		l.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		yield return new WaitForSeconds (0.5f);

        

		
	}
}

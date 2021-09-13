using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour 
{
    public static fruitSpawner instance;
    public GameObject fruit;
	public float maxX;
	public GameObject bomb;
    public GameObject Button;
    public bool Gamestarted;

	private void Awake()
	{
        instance = this;
    }
    // Use this for initialization
    void Start () {
        Gamestarted = false;
    }

	public void StartButton()
	{
		if(Gamestarted == false)
		{
			Invoke("startSpawn",0.1f);
        	Button.SetActive(false);
            Gamestarted = true;
        }
		
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startSpawn(){
		InvokeRepeating ("spawnFruitGroup",1f,7f);
		//InvokeRepeating ("bombSpawner",8f,9f);
	     // spawnFruitGroup();
	}
	public void stopSpawn(){
		CancelInvoke ("spawnFruitGroup");
		StopCoroutine ("spawnFruit");

	}

	public void spawnFruitGroup()
	{
		StartCoroutine ("spawnFruit");	
	}

	public void bombSpawner(){
		float rrand = Random.Range (-maxX, maxX);
		Vector3 poooS = new Vector3 (rrand, transform.position.y, 0);
		GameObject a = Instantiate (bomb, poooS, Quaternion.identity) as GameObject;
		a.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		a.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-70f,70f));
	}



	IEnumerator spawnFruit()
	{
        if (Random.Range(0,6) > 3)
		{
            bombSpawner();
        }
		for(int i = 0; 0 < 5; i++)
		{

		float Rand = Random.Range (-maxX, maxX);
		Vector3 pos = new Vector3 (Rand, transform.position.y, 0);
		GameObject f = Instantiate (fruit, pos, Quaternion.identity) as GameObject;
		f.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 15f), ForceMode2D.Impulse );
		f.GetComponent<Rigidbody2D> ().AddTorque(Random.Range(-20f,20f));
		}
		
		yield return new WaitForSeconds (3f);
	}
}

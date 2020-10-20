using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Diver : MonoBehaviour
{
    // Start is called before the first frame update
	public int Cash;
	public int Val;
	public int Object;
	public int Lvl;
	public float oxy=100;
	private SpriteRenderer render;
	public GameManager manager;
	private Sampah trash;
	public float speedx;
	public BoxCollider2D bx;
	public SpriteRenderer sr;
	public Text tex;
	public Text tex2;
	public float temp = 2;
	void Start()
    {
		
		manager = manager.GetComponent<GameManager>();

		Lvl = 1;
		PlayerPrefs.SetFloat("x1", transform.position.x);
	}

    // Update is called once per frame
    void Update()
    {
		tex.GetComponent<Text>().text = Cash.ToString();
		Debug.Log(Cash + "     " + Val) ;
		speedx = transform.position.x - PlayerPrefs.GetFloat("x1");
		PlayerPrefs.SetFloat("x1", transform.position.x);
		if (speedx <= 0)
		{
			bx.offset = new Vector2(-1.43f, -0.36f);
			sr.GetComponent<SpriteRenderer>().flipX = false;
		}
		else if(speedx > 0)
		{
			bx.offset = new Vector2(1.43f, -0.36f);
			sr.GetComponent<SpriteRenderer>().flipX = true;
		}
		if (transform.position.y >= 1364)
		{
			if (oxy <= 100)
			{
				oxy += 1f;
			}
			else oxy += 0;
		}
		else {
			if (oxy > 0)
			{
				oxy -= 0.05f;
			}
			else manager.gameOver = true;
		}

		//lvl up

		if (Input.GetKeyDown(KeyCode.Q))
		{
			if (Lvl >= 2)
			{
				Debug.Log("already bought");
			}
			else if (Cash >= 1000)
			{
				Lvl = 2;
				Cash = Cash - 1000;
			}

		}
		else if (Input.GetKeyDown(KeyCode.W))
		{
			if (Lvl >= 3)
			{
				Debug.Log("already bought");
			}
			else if (Cash >= 4000)
			{
				Lvl = 3;
				Cash = Cash - 4000;
			}

		}
		//check game over
		if (manager.gameOver!=true)
		{
			//input movement
			if (Cash >= 10000)
			{
				tex2.gameObject.SetActive(true);
			}
			if (Input.mousePosition.x>=1920)
			{
				transform.position =new Vector3 (1920,Input.mousePosition.y,-5); Cursor.lockState = CursorLockMode.Locked;
			}
			else if (Input.mousePosition.x <= 0)
			{
				transform.position = new Vector3(0, Input.mousePosition.y,-5);			Cursor.lockState = CursorLockMode.Locked;
			}
			else if (Input.mousePosition.y >= 1540)
			{
				transform.position = new Vector3(Input.mousePosition.x, 1540,-5);		Cursor.lockState = CursorLockMode.Locked;
			}
			else if (Input.mousePosition.y <= -368)
			{
				transform.position = new Vector3(Input.mousePosition.x, -472,-5);		Cursor.lockState = CursorLockMode.Locked;
			}
			else transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,-5); 	Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			this.GetComponent<Rigidbody2D>().gravityScale = 15;

			temp = temp - Time.deltaTime;
			if ( temp <= 0)
			{
				SceneManager.LoadScene("Front");
			}
		}

Cursor.lockState = CursorLockMode.None;
	}
	private void Add(){
		//event diver dengan sampah
		

	}
	private	bool gameover(){
		//gameover kondisi
		return true;
	}
	public void OnTriggerEnter2D(Collider2D collision)
	{


		if (collision.gameObject.name.Contains("trasha") && Lvl >= 1)
		{
			Debug.Log("true goddamnit");
			Val = Val + collision.gameObject.GetComponent<Sampah>().getVal();
			Cash = Cash + collision.gameObject.GetComponent<Sampah>().getCash();
		}
		else if (collision.gameObject.name.Contains("trashb") && Lvl >= 2)
		{
			Val = Val + collision.gameObject.GetComponent<Sampah>().getVal();
			Cash = Cash + collision.gameObject.GetComponent<Sampah>().getCash();
		}
		else if (collision.gameObject.name.Contains("trashc") && Lvl >= 3)
		{
			Val = Val + collision.gameObject.GetComponent<Sampah>().getVal();
			Cash = Cash + collision.gameObject.GetComponent<Sampah>().getCash();
		}
		else
			manager.gameOver = true;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool isPaused = false;
	// Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	}
	public void miniManager(float yyy, bool isPaused)
	{
		Time.timeScale = yyy;
	}*/
	public void Escape()
	{
		SceneManager.LoadScene("Menu");
	}
	/*public void unPause()
	{
		miniManager(1,false);
	}*/
}

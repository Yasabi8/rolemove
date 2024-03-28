using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JJu : MonoBehaviour
{
    Rigidbody2D rb;
    public Collider2D ss;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D ss)
    {
        Debug.Log("quit");
        Application.Quit();
    }
     public void SS() {
        SceneManager.LoadScene(1);
    }

}

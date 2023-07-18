using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "NewCapybara")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 50f;
    private float heightUp = 1000f;
    private SpriteRenderer sr;
    public static int countCoin = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float right = Input.GetAxis("Horizontal");
        if (right != 0)
        {
            var position = transform.position;
            position += Vector3.right * right * Time.deltaTime * speed;
            rb.MovePosition(position);
        }

        if (right < 0)
        {
            sr.flipX = true;
        }
        else if (right > 0)
        {
            sr.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var position = transform.position;
            position += Vector3.up * Time.deltaTime * heightUp;
            rb.MovePosition(position);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            countCoin++;
            scoreText.text = "Count of coints : " + countCoin;
        }
    }
}

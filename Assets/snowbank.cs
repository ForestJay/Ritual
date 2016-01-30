using UnityEngine;
using System.Collections;

public class snowbank : MonoBehaviour
{

    public Sprite empty;
    public Sprite Hidden;

    public GameObject target;

    public bool ishiding = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = empty;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
        }
    }


    void hidden(bool check)
    {
        if (check == true)
        { 
        spriteRenderer.sprite = Hidden;
        }

        if (check == false)
        {
        spriteRenderer.sprite = empty;
        }
    }
}

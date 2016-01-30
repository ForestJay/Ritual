using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour
{

    public Sprite full;

    public GameObject target;

    public int value = 5;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = full;
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

    void pick()
    {
        target.SendMessage("resourcecollect", value);
        Destroy(gameObject);
            
    }

}

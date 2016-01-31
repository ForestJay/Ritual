using UnityEngine;
using System.Collections;

public class Foodperm : MonoBehaviour
{

    public Sprite full;
    public Sprite empty;
    public bool berries = true;

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

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
        }
    }

    void pick()
    {
        if (berries == true)
        {
            berries = false;
            target.SendMessage("resourcecollect", value);
            spriteRenderer.sprite = empty;
        }
    }

}

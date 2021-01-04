using UnityEngine;

public class Slime : MonoBehaviour{

    Transform player;
    public float speed = 1f;

    void Start () => player = GameObject.FindWithTag("Player").transform;

    void Update(){
        var u = (player.transform.position - transform .transform.position).normalized;
        transform.transform.position += u * speed * Time.deltaTime;
    }

    void OnCollisionEnter(){
        Destroy(gameObject);
    }

}

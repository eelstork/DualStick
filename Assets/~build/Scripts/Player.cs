using UnityEngine;

public class Player : MonoBehaviour{

    public float speed = 1f;
    public float bulletImpulse = 10f;

    void  Update(){
        var u = Vector3.zero;
        if (Input.GetKey(KeyCode.A)) u += Vector3.left;
        if (Input.GetKey(KeyCode.D)) u += Vector3.right;
        if (Input.GetKey(KeyCode.W)) u += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) u += Vector3.back;
        if (Input.GetKeyUp(KeyCode.Space)) Shoot();
        //
        transform .transform.position += u * speed * Time.deltaTime ;
    }

    void Shoot(){
        var bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        var t = bullet.transform;
        t.transform.position = transform .transform.position;
        t.localScale = Vector3.one * 0.25f;
        var body = bullet.gameObject.AddComponent<Rigidbody>();
        body.useGravity = false;
        body.AddForce(Vector3.forward * bulletImpulse, ForceMode.Impulse);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Dart : InteractionBehaviour
{
    Vector3 _defaultPosition;
    private MainScript parent;
    // Start is called before the first frame update
    void Start()
    {
        _defaultPosition = this.transform.position;
        parent = this.transform.parent.GetComponent<MainScript>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckY();
    }
    void CheckY()
    {
        if (this.transform.position.y < -10)
            Respawn();
    }
    void Respawn()
    {
        this.transform.position = _defaultPosition;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Ground Collider")
        {
            Respawn();
        }
        if (other.name == "Board")
        {
            string AnswerHit = other.tag;
            Debug.Log(AnswerHit);
            this.rigidbody.velocity = new Vector3(-this.rigidbody.velocity.x, this.rigidbody.velocity.y, -this.rigidbody.velocity.z);
            this.rigidbody.angularVelocity = new Vector3(-this.rigidbody.angularVelocity.x, this.rigidbody.angularVelocity.y, -this.rigidbody.angularVelocity.z);
            int ans = 0;
            switch (AnswerHit)
            {
                case "A":
                    ans = 0;
                    break;
                case "B":
                    ans = 1;
                    break;
                case "C":
                    ans = 2;
                    break;
                case "D":
                    ans = 3;
                    break;
            }
            parent.onAnswer(ans);
        }
    }
}

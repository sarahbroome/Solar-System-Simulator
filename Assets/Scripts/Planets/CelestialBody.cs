using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof (Rigidbody))]
public class CelestialBody : GravityObject {

    public float radius;
    public float surfaceGravity = 0f;
    public Vector3 initialVelocity;
    public string bodyName = "Unnamed";
    Transform meshHolder;

    public string type = "Star";
    public Rigidbody host_rb;

    public Vector3 velocity { get; private set; }
    public float mass { get; private set; }
    Rigidbody rb;

    void Awake () {
        rb = GetComponent<Rigidbody> ();
        rb.mass = mass;
        velocity = initialVelocity;
    }

    public void UpdateVelocity (CelestialBody[] allBodies, float timeStep) {
        if (this.type == "Planet" || this.type == "Moon") {
            float sqrDst = (host_rb.position - rb.position).sqrMagnitude;
                Vector3 forceDir = (host_rb.position - rb.position).normalized;

                Vector3 acceleration = forceDir * Universe.gravitationalConstant * host_rb.mass / sqrDst;
                velocity += acceleration * timeStep;
        }
    }

    public void UpdateVelocity (Vector3 acceleration, float timeStep) {
        velocity += acceleration * timeStep;
    }

    public void UpdatePosition (float timeStep) {
        rb.MovePosition (rb.position + velocity * timeStep);

    }

    void OnValidate () {
        mass = surfaceGravity * radius * radius / Universe.gravitationalConstant;
        meshHolder = transform.GetChild (0);
        meshHolder.localScale = Vector3.one * radius;
        gameObject.name = bodyName;
    }

    public Rigidbody Rigidbody {
        get {
            return rb;
        }
    }

    public Vector3 Position {
        get {
            return rb.position;
        }
    }

}
using UnityEngine;

public class Mouse_Control : MonoBehaviour {
	/// <summary>
	/// 1 - The speed of the ship
	/// </summary>
	public Vector2 speed = new Vector2(5f, 2f);
    public Animation run;
    public Animation idle;
    bool mouseClick = false;
    private Animator animator;
    private Rigidbody2D rb;

	//The position you clicked
	public Vector2 targetPosition;
	//That position relative to the players current position (what direction and how far did you click?)
	public Vector2 relativePosition;
	
	// 2 - Store the movement
	private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;
	
	void Update()
	{
		// 3 - Retrieve the mouse position
		if(Input.GetKeyDown(KeyCode.Mouse0))	
		{	
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseClick = true;
			
		}	

		//4 - Find the relative poistion of the target based upon the current position 
		// Update each frame to account for any movement
        if(mouseClick == true){
		    relativePosition = new Vector2(
			targetPosition.x - gameObject.transform.position.x,
			targetPosition.y - gameObject.transform.position.y );
            
        }
		float move = Input.GetAxis("Horizontal");
		animator.SetFloat("Speed", Mathf.Abs(move));
	}

	
	void FixedUpdate()
	{
		// 5 - If you are about to overshoot the target, reduce velocity to that distance
        //      Else cap the Movement by a maximum speed per direction (x then y)
    	if (mouseClick){
        if(	speed.x * Time.deltaTime >=  Mathf.Abs(relativePosition.x)) {
			movement.x = relativePosition.x;	

		} else{
			movement.x = speed.x * Mathf.Sign(relativePosition.x);
		}
		if(	speed.y * Time.deltaTime >=  Mathf.Abs(relativePosition.y) ) {
			movement.y = relativePosition.y;
		} else{
			movement.y = speed.y * Mathf.Sign(relativePosition.y);
		}

		// 6 - Move the game object using the physics engine
		GetComponent<Rigidbody2D>().linearVelocity = movement;
        }
	}
}
using UnityEngine;
using System.Collections;

public class CannonControls : MonoBehaviour {

	private float nextFireTime;
	public float reloadTime = 1f;
		public float cannonPower = 100f;
		public GUIText rotText;
		public GUIText velText;
		public float rayDistance = 25f;
		public float rotationSpeed = 5f;
        public Transform target = null;
 		public Transform CannonBulletSpawn;
	public bool fired = false;
	public int shotsLeft;
	public GUIText shotsText;
	public GUIText scoreText;
	public float scoreAdjust;
 	//private Quaternion desiredRotation;
 		public GameObject Bullet;
            // Use this for initialization
 
            void Start () {
		scoreAdjust = 0 - transform.position.z;
 
 
            }
 
            // Update is called once per frame
 
            void Update () {
		/*Ray ray = new Ray(CannonBulletSpawn.position, transform.forward);
		//Debug.DrawLine(ray.origin, ray.direction * rayDistance, Color.red);
		RaycastHit rayHit = new RaycastHit();
		Vector3 reflecDir = Vector3.Reflect( ray.direction,Vector3.forward);
		
		if (Physics.Raycast( ray, out rayHit, rayDistance))
		{
			Debug.DrawRay(rayHit.point, reflecDir * rayDistance, Color.green);
			
		}
*/
		if(Input.GetKey(KeyCode.W)&&(cannonPower<2000)){
			cannonPower++;
			
			
		}
		if(Input.GetKey(KeyCode.A)&& transform.rotation.eulerAngles.y>1){
			transform.Rotate(0f,-5f*rotationSpeed*Time.deltaTime,0f);
		}
		
		if(Input.GetKey(KeyCode.D)&& transform.rotation.eulerAngles.y<180){
			transform.Rotate(0f,5f*rotationSpeed*Time.deltaTime,0f);
		}
		
		if(Input.GetKey(KeyCode.S)){
			cannonPower--;
		}
	
		if(Input.GetKeyDown(KeyCode.Space) && !fired && shotsLeft>0)
 
       	{

			FireProjectile ();
			fired=true;
			shotsLeft--;
		 
        }

		string rotString = rigidbody.rotation.eulerAngles.y.ToString();
		
		rotText.text = "Rotation: " + rotString;
		if ((rotString.IndexOf(".") > -1) && (rotString.Length>rotString.IndexOf(".")+ 4)){
			rotText.text = "Rotation: " + rotString.Substring(0, rotString.IndexOf(".") ) + rotString.Substring(rotString.IndexOf("."), 3);
		}
		
		
		string velString = cannonPower.ToString();
		velText.text = "Velocity : " + velString;
		if ((velString.IndexOf(".") > -1) && (velString.Length>velString.IndexOf(".")+ 4)) {
			velText.text = "Velocity: " + velString.Substring(0, velString.IndexOf(".") ) + velString.Substring(velString.IndexOf("."), 3);
		}
		shotsText.text = "Shots Left: " + shotsLeft.ToString();

		string scoreString = (transform.position.z + scoreAdjust).ToString();
		string[] scoreSplitter = scoreString.Split ('.');
		scoreText.text = "Score: " + scoreSplitter[0];
	}
	void FireProjectile()
	{
		
		GameObject clone = Instantiate (Bullet, CannonBulletSpawn.transform.position, transform.rotation ) as GameObject ;
		clone.rigidbody.AddForce(CannonBulletSpawn.transform.forward * cannonPower);

		nextFireTime = Time.time+reloadTime;


	}

 
           // Rigidbody clone;
           // clone = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody;
           // clone.velocity = transform.TransformDirection(Vector3.forward * 10);
  
       }
       
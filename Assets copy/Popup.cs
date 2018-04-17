namespace GoogleVR.HelloVR {
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;
	public class Popup : MonoBehaviour {
		public Transform message;
		public Text warn;
		public Transform kitten;
		public Transform ball;
		public Transform plate;
		public Transform clean_sink;
		public Animator anim;
		public Text status;
		public Transform hoster;
		public bool move_flag = false;
		public bool playball_flag = false;
		public bool clean_flag = false;
		public bool feed_flag = false;
		
		bool showFlag = false;
		int health = 8;
		int hungry = 8;
		int clean = 8;
		int affinity = 8;
		int min = 0;
		int max = 10;
		private WaitForSeconds actionDuration = new WaitForSeconds(5.07f);
		// Use this for initialization
		void Start () {
			message = GameObject.Find("DemoInputManager").transform;
			anim = GameObject.Find("KittenObject").GetComponent<Animator>();
			status = GameObject.Find("Status").GetComponent<Text>();
			kitten = GameObject.Find("KittenObject").GetComponent<Transform>();
			ball = GameObject.Find("ball").GetComponent<Transform>();
			plate = GameObject.Find("food").GetComponent<Transform>();
			clean_sink = GameObject.Find("clean").GetComponent<Transform>();
			warn = GameObject.Find("warning").GetComponent<Text>();
			hoster = GameObject.Find("Player").GetComponent<Transform>();
			Debug.Log(anim);
		}
		
		// Update is called once per frame

		public void toggleShow() {
			if (showFlag == false) {
				message.localScale = new Vector3(1, 1, 1);
			} else {
				message.localScale = new Vector3(0, 0, 0);
			}
			showFlag = !showFlag;
		}

		private void reset() {
			anim.SetBool("run", false);
			anim.SetBool("walk", false);
			anim.SetBool("jump", false);
			anim.SetBool("itch", false);
			anim.SetBool("meow", false);
		}

		private void warnPrint() {
			string warnText = "";
			if (health < 2) {
				warnText += "Health is low! ";
			}
			if (hungry < 2) {
				warnText += "Hungry is low! ";
			}
			if (clean < 2) {
				warnText += "Clean is low! ";
			}
			if (affinity < 2) {
				warnText += "Affinity is low! ";
			}
			if (warnText == "") {
				warnText = "Pet Condition: Everything is good for you pet!";
			}
			warn.text = warnText;
		}

		private void statusPrint() {
			if (health > 10) {
				health = 10;
			}
			if (health < 0) {
				health = 0;
			}
			if (hungry > 10) {
				hungry = 10;
			}
			if (hungry < 0) {
				hungry = 0;
			}
			if (clean > 10) {
				clean = 10;
			}
			if (clean < 0) {
				clean = 0;
			}
			if (affinity > 10) {
				affinity = 10;
			}
			if (affinity < 0) {
				affinity = 0;
			}

			status.text = "Health: " + health + " / 10\r\nHungry: " + hungry + " / 10\r\nClean: " + clean + " / 10\r\nAffinity: " + affinity + " / 10";
		}

		public void run() {
			this.reset();
			anim.SetBool("run", true);
			
		}

		public void meow() {
			this.reset();
			anim.SetBool("meow", true);
		}

		public void itch() {
			this.reset();
			anim.SetBool("itch", true);
		}

		public void jump() {
			this.reset();
			anim.SetBool("jump", true);
		}

		public void walk() {
			this.reset();
			anim.SetBool("walk", true);
		}

		public void runToMe() {
			move_flag = true;
			playball_flag = false;
			clean_flag = false;
			feed_flag = false;
			health = health + 1;
			hungry = hungry - 1;
			clean = clean - 1;
			affinity = affinity + 1;
			run();
		}

		public void playBall() {
			playball_flag = true;
			move_flag = false;
			clean_flag = false;
			feed_flag = false;
			health = health + 1;
			hungry = hungry - 1;
			clean = clean - 1;
			run();
		}

		public void goClean() {
			playball_flag = false;
			move_flag = false;
			feed_flag = false;
			clean_flag = true;
			health = health + 1;
			hungry = hungry - 1;
			clean = clean + 1;
			run();
		}

		public void feed() {
			playball_flag = false;
			move_flag = false;
			clean_flag = false;
			feed_flag = true;
			health = health + 1;
			hungry = hungry + 1;
			run();
		}

		void Update() {
			if (move_flag) {
				float step = 1 * Time.deltaTime;
				kitten.LookAt(hoster.position);
				kitten.position = Vector3.MoveTowards(kitten.position, hoster.position, step);
				if (kitten.position == hoster.position) {
					move_flag = false;
					itch();
				}
			}

			if (playball_flag) {
				float step = 1 * Time.deltaTime;
				kitten.LookAt(ball.position);
				kitten.position = Vector3.MoveTowards(kitten.position, ball.position, step);
				if (kitten.position == ball.position) {
					playball_flag = false;
					jump();
				}
			}

			if (clean_flag) {
				float step = 1 * Time.deltaTime;
				kitten.LookAt(clean_sink.position);
				kitten.position = Vector3.MoveTowards(kitten.position, new Vector3(4.94f, 0, 7), step);
				if (kitten.position == new Vector3(4.94f, 0, 7)) {
					clean_flag = false;
					itch();
				}
			}

			if (feed_flag) {
				float step = 1 * Time.deltaTime;
				kitten.LookAt(plate.position);
				kitten.position = Vector3.MoveTowards(kitten.position, new Vector3(-5, 0, 5), step);
				if (kitten.position == new Vector3(-5, 0, 5)) {
					feed_flag = false;
					meow();
				}
			}

			warnPrint();
			statusPrint();
		}
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour {

	private UnityEngine.Video.VideoPlayer videoPlayer;

	public GameObject audioGeysir;
	public GameObject audioWaterfall;
	public GameObject geysirParticleSystem;

	[SerializeField]
	// private AudioSource audioSource;

	void Start () {

		videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();

		if (videoPlayer.clip != null) {
			
			videoPlayer.EnableAudioTrack (0, true);
			// videoPlayer.SetTargetAudioSource(0, audioSource);
		}

		geysirParticleSystem.SetActive (false);
	}
		
	void Update(){

		checkParticleSystemGeysir ();
	}

	private void checkParticleSystemGeysir() {

		// toggle particles visibility to appear only during geyser
		if (videoPlayer.time > 44 && videoPlayer.time < 50) {

			geysirParticleSystem.SetActive (true);
		
		} else {

			geysirParticleSystem.SetActive (false);
		}
	}

	public void PlayPauseVideo() {

		if (videoPlayer.isPlaying) {
			
			videoPlayer.Pause ();
		}
		else {

			videoPlayer.Play();
			// audioSource.Play();
		}
	}

	public void RestartVideo() {

		if (videoPlayer.isPlaying) {

			videoPlayer.Pause ();
			// audioSource.Pause ();
		}

		videoPlayer.time = 0;
		videoPlayer.Play ();
	}

	public void GotoBlackBeach() {

		videoPlayer.time = 59;
	}

	public void GotoWaterfalls() {

		videoPlayer.time = 116;
	}

}
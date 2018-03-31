using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour {

	private UnityEngine.Video.VideoPlayer videoPlayer;


	[SerializeField]
	private AudioSource audioSource;



	void Start () {
		videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();


		if (videoPlayer.clip != null) 
		{
			videoPlayer.EnableAudioTrack (0, true);
			videoPlayer.SetTargetAudioSource(0, audioSource);
		}
	}
		
	void Update(){
	}

	public void PlayPauseVideo() {

		if (videoPlayer.isPlaying) {

			videoPlayer.Pause ();
		}
		else {

			videoPlayer.Play();
			audioSource.Play();
		}
	}

	public void RestartVideo() {

		if (videoPlayer.isPlaying) {

			videoPlayer.Pause ();
			audioSource.Pause ();
		}

		videoPlayer.frame = 1;
		videoPlayer.Play ();
	}

	public void GotoBlackBeach() {

		videoPlayer.frame = 200;
	}

	public void GotoWaterfalls() {

		videoPlayer.frame = 500;
	}

}
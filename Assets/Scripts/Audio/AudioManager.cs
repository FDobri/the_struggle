using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;

[System.Serializable]
public class Sound
{
	public string soundName;

	public AudioClip audioClip;

	public bool loop;

	[Range(0f, 1f)]
	public float volume;

	[HideInInspector]
	public AudioSource audioSource;
}

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;
	public AssetReference[] soundtracks;
	//private int _playingSoundtrack = 0;

	public static AudioManager _audioManagerInstance;

	void Awake()
	{
		if (_audioManagerInstance == null)
		{
			_audioManagerInstance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
		SetupAudioSources();
	}

	private void Start()
	{
		//StartCoroutine(PlayAudioTest());
	}

	//private IEnumerator PlayAudioTest()
	//{
		//var newAudioSource = gameObject.AddComponent<AudioSource>();
		//while (true)
		//{
		//	var currentOperationHandle = soundtracks[_playingSoundtrack].LoadAssetAsync<AudioClip>();
		//	yield return currentOperationHandle;
		//	var newAudioClip = currentOperationHandle.Result;
		//	newAudioSource.clip = newAudioClip;
		//	newAudioSource.Play();

		//	yield return new WaitUntil(() => newAudioSource.isPlaying == false);

		//	newAudioSource.clip = null;
		//	Addressables.Release(currentOperationHandle);

		//	_playingSoundtrack = (_playingSoundtrack + 1) % soundtracks.Length;
		//}

		//((AudioClip)addressableRef.Asset);
		//var newAudioSource = gameObject.AddComponent<AudioSource>();
		//var loading = soundtracks[0].LoadAssetAsync<AudioClip>();
		//yield return new WaitUntil(() => loading.IsDone);
		//newAudioSource.clip = loading.Result;
		//newAudioSource.volume = 1;
		//newAudioSource.loop = true;
		//newAudioSource.playOnAwake = true;
		//newAudioSource.Play();
	//}

	//public void SetSoundsVolume(float amount, string typeOfAudio)
	//{
	//	switch (typeOfAudio)
	//	{
	//		case "sounds":
	//			var nonLoopSounds = _sounds.Where(s => !s.Loop).ToArray();
	//			foreach (var item in nonLoopSounds)
	//			{
	//				item.AudioSource.volume = amount;
	//			}
	//			break;
	//		case "music":
	//			var loopingSounds = _sounds.Where(s => s.Loop).ToArray();
	//			foreach (var item in loopingSounds)
	//			{
	//				item.AudioSource.volume = amount;
	//			}
	//			break;
	//	}
	//}

	public void PlaySound(string audioName)
	{
		sounds.First(sound => sound.soundName.Equals(audioName)).audioSource.Play();
	}

	private void SetupAudioSources()
	{
		foreach (Sound sound in sounds)
		{
			sound.audioSource = gameObject.AddComponent<AudioSource>();
			AudioSource audioSource = sound.audioSource;
			audioSource.clip = sound.audioClip;
			audioSource.volume = sound.volume;
			audioSource.loop = sound.loop;

			if (sound.audioSource.loop)
			{
				sound.audioSource.Play();
			}
		}
	}
}

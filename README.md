
# Welcome to DracoArts

![Logo](https://dracoarts-logo.s3.eu-north-1.amazonaws.com/DracoArts.png)




#  Dotween A Unity Tween Engine  Example 
Dotween (short for "Demigiant's Tween Engine") is a high-performance animation/tweening library for Unity, designed to simplify the creation of smooth, dynamic animations with minimal code. It is lightweight, fast, and easy to use, making it a favorite among Unity developers for UI effects, gameplay animations, transitions, and more.

Unlike Unity’s built-in Animator (which requires state machines and keyframes), Dotween allows you to animate properties procedurally with just a few lines of code.

# What is Tweening?
A tween (short for "in-between") is an animation that smoothly transitions a property (position, rotation, scale, color, etc.) from a start value to an end value over a specified duration.

### Example:

- Moving a button from (0,0) to (100,0) in 1 second.

- Fading a sprite from opaque (1) to transparent (0) in 2 seconds.

### How Dotween Works
#### You define:

- What to animate (e.g., position, scale, color).

- From and To values.

- Duration (how long the animation takes).

- Easing (how the motion accelerates/decelerates).

- Dotween handles the interpolation automatically.

# Key Features of Dotween

### ✔ Smooth & Efficient Animations
- Optimized for performance (low garbage collection).

- Supports 60FPS+ animations even on mobile devices.

### ✔ Simple & Chainable Syntax

- Methods can be chained for complex sequences.

### ✔ Supports Multiple Animation Types
- Transforms (DOMove, DORotate, DOScale)

- UI Elements (DOFade, DOColor, DOAnchorPos)

- Materials & Shaders (DOColor, DOFloat)

- Custom Values (animate any float, Vector3, Color, etc.)
### ✔ Advanced Control
- Sequences (combine multiple tweens in order).

- Callbacks (run code when an animation starts/ends).

- Loops (repeat, yoyo, or incremental animations).

- Time Scaling (slow down/speed up tweens).

### ✔ Easing Functions (30+ Presets)
- Linear → Smooth, constant speed.

- Elastic → Bouncy, spring-like effect.

- Bounce → Object bounces at the end.

- Back → Slight overshoot before settling.

# Core Features of Dotween\

### 🔹 Smooth Animations
- Move, rotate, scale, fade, and change colors smoothly.

- Supports 60+ easing types (linear, bounce, elastic, etc.).

### 🔹 Chaining & Sequencing
- Combine multiple animations in order.

- Create complex sequences (e.g., move → rotate → fade).

### 🔹 UI Animations
- Perfect for button effects, menu transitions, and loading animations.

- Works seamlessly with Canvas and UGUI elements.

### 🔹 Physics-Like Motion
- Simulate bouncing, springing, and elastic movements.

- Add screen shake for impact effects.

### 🔹 Path Animations
- Move objects along custom paths (bezier curves, splines).

### 🔹 Callbacks & Events
- Run functions when animations start, complete, or update.

- Useful for triggering game logic after animations.

### 🔹 Looping & Reversing
- Play animations infinite times or back-and-forth (yoyo effect).

# How to Get Started
###  Installation
- Download from the Unity Asset Store
   [Dotween](https://assetstore.unity.com/packages/tools/visual-scripting/dotween-pro-32416?srsltid=AfmBOorTwgxZ0Ha0WAxIJWPh-VZ3Pd72uhu4USNBKklQzFAnsjw58B1D)

- Import into your Unity project.



## Usage/Examples
Basic Example 

    using DG.Tweening;
    using UnityEngine;

    public class BasicTweenExample : MonoBehaviour
     {
    
    public Transform _transform;
    public void Move()
    {
        _transform.DOMove(new Vector3(5, 0, 0), 2f);
    
    }
    public void Rotate()
    {
        _transform.DORotate(new Vector3(0, 180, 0), 3f).SetDelay(0.5f);
    }

    public void Scale()
    {
        _transform.DOScale(Vector3.one * 2, 0.5f)
            .SetLoops(4, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);

    }

    }
UI Example 

    using DG.Tweening;
    using JetBrains.Annotations;
    using UnityEngine;
    using UnityEngine.UI;

    public class UITweenExample : MonoBehaviour
    {
    public CanvasGroup panel;
    public Button button;

    void Start()
    {
       
        button.onClick.AddListener(() =>
        {
            panel.transform.DOMoveX(Screen.width, 3f)
                .SetEase(Ease.InBack)
                .OnComplete(() => panel.gameObject.SetActive(false));
        });
    }
    public void Fade(){

    panel.DOFade(1, 3f).From(0); 
    }
    }


  Follow Example 

    using UnityEngine;
    using System.Collections;
    using DG.Tweening;

    public class Follow : MonoBehaviour
    {
	public Transform target; // Target to follow
	Vector3 targetLastPos;
	Tweener tween;

	void Start()
	{
	
		tween = transform.DOMove(target.position, 2).SetAutoKill(false);
	
		targetLastPos = target.position;
	}

	void Update()
	{

		if (targetLastPos == target.position) return;
		tween.ChangeEndValue(target.position, true).Restart();
		targetLastPos = target.position;
	}
    }
## Image

## Part 1
![](https://github.com/AzharKhemta/Gif-File-images/blob/main/Dotweeen_1-ezgif.com-video-to-gif-converter.gif?raw=true)

## Part 2
![](https://github.com/AzharKhemta/Gif-File-images/blob/main/Dotween_2-ezgif.com-video-to-gif-converter.gif?raw=true)

## Part 3
![](https://github.com/AzharKhemta/Gif-File-images/blob/main/Dotween_4-ezgif.com-video-to-gif-converter.gif?raw=true)

## Part 4
![](https://github.com/AzharKhemta/Gif-File-images/blob/main/Dotween_3-ezgif.com-video-to-gif-converter.gif?raw=true)

## Authors

- [@MirHamzaHasan](https://github.com/MirHamzaHasan)
- [@WebSite](https://mirhamzahasan.com)


## 🔗 Links

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/company/mir-hamza-hasan/posts/?feedView=all/)
## Documentation

[Official Documentation:](http://dotween.demigiant.com/)




#### YouTube Tutorials:
 Search "Dotween Tutorial"


## Tech Stack
**Client:** Unity,C#

**Plugin:** DoTWeen Pro




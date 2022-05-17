# Unity Retro TV CRT\NTSC Effect

Unity package. Flexible code to implement in your retro style project.

## Features

- Easy to use. Just give it two textures: input and output
- An example of how to make a TV. You can take as a basis for creating a retro room! 📺💖
	- Plays video on tv screen
- An example of how to make a 2D game with old school style. Use it as a base
	- Adaptive dynamic resolution
- In the examples, all settings are hidden in presets

## Demonstration

This is the most popular example of dithering!
![alt text](https://github.com/YooPita/com.yoopita.retrotvfx/blob/main/DemoImages/md_sonic_demo.png)

TV example. It's called "RenerTextureFx" and is located in the "Examples" folder.
![alt text](https://github.com/YooPita/com.yoopita.retrotvfx/blob/main/DemoImages/tv_demo.png)

Screen effect example. It's called "CameraFx" and is located in the "Examples" folder.
![alt text](https://github.com/YooPita/com.yoopita.retrotvfx/blob/main/DemoImages/tv_fx_2d_widescreen_demo.png)

## Description of shader settings from the original repository

- Rolling sync flicker — enables a "rolling flicker" type effect you'd see when recording a CRT television with a camera
- Rolling flicker factor — sets the opacity of the rolling flicker effect
- Rolling V-Sync time — sets the phase duration of the V-Sync. 1.0 is perfectly synchronized and will not display any "rolling". Any value other than 1.0 will simulate the "desynchronized" effect
and cause it to roll faster or slower
- RF Noise — sets the amount of RF noise added to the image (RF only)
- YIQ Filter — allows the YIQ signal to be distorted. The chroma plane can be scaled and offset, and the luma signal can also be sharpened here
- Enable burst count animation — enable animating the NTSC burst phase, which causes the scanline flickering. Disabling this will freeze the animation and make the scanline artifacts more apparent, but some
old consoles did work this way.
- Anti flicker — when burst count animation is enabled, this adds an option to reduce the amount of flickering by blending the current and previous frames together. This adds a "motion blur" like effect, but reduces the amount of flickering which may be desirable.

## Installation

Make sure you have standalone [Git](https://git-scm.com/downloads) installed first.

![alt text](https://github.com/YooPita/com.yoopita.retrotvfx/blob/main/DemoImages/installation.png)

And paste this: `https://github.com/YooPita/com.yoopita.retrotvfx.git#1.0.0`

Or just copy the repository to your project files.

## About

This repository is based on this [repository](https://github.com/GlaireDaggers/RetroTVFX). This repository is an improved codebase to make it easier to implement into your project and write custom features with this effect. The author of the original repository did not like this implementation and offered to base his repository on top of it.

- NTSC effect shader by @GlaireDaggers
- Code architecture && examples by @YooPita

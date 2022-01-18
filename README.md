# CameraScaler project
This project contains solutions for some problems that I have encountered with regards to aspect ratio and fullscreen in standalone 2D-apps. 

## CameraScaler.cs
* Place this script on your main camera. (Works only for orthographic projection)
* Specify a target width and hight (this will be used to determine the desired aspect ratio)
* Optionally specify a dynamic max width and/or height to let the camera grow in either direction. Make sure to check the correspondning "Use dynamic width" and/or "Use dynamic height" as well.
* Add another camera (as show in the example) to decide the color of the letterbox.

## FullscreenHandler.cs
* Attempts to solve the resolution issues that can occur when switching between windowed and fullscreen mode. 


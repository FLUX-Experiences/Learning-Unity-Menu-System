# Learning-Unity-Menu-System

![alt text](https://raw.githubusercontent.com/shacharoz/Learning-Unity-Menu-System/master/Builds/intro.png)

Menu System Handling Methods

Every game you ever make will have multiple screens. Home screen, In-Game screen and a Feedback screens are just a few examples. A full product also has the Store, World/Level selections, Character Customizations, etc.

Unity offers two main approaches for dealing with menu system. The thing is, it might take between a day to a week to switch between the two models. So you’d better understand both models and decide which works better for you.

This project showcases the two methods, and it is open source tutorial, free for any use.

Method 1: Entire Game in One Scene
Have your entire game in one Scene and switch between the various screens by toggling the UI Panel’s GameObject.

![alt text](https://raw.githubusercontent.com/shacharoz/Learning-Unity-Menu-System/master/Builds/one-scene.png)

Method 2: One Scene Per Screen
Separate each screen into a different Unity Scene and switch between them using the functionality of Scene Loading. 
Built for large projects that wish to save performance by removing assets from the current Scene. 
It means the developer need to make sure to transfer user states between screens.

![alt text](https://raw.githubusercontent.com/shacharoz/Learning-Unity-Menu-System/master/Builds/scene-per-screen.png)

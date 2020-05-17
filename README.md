Professor Nathan,

I'm sorry for the late submission. I have had a lot of personal issues going on and I did not want to submit an incomplete game.
I wanted to make it as functional as possible and even though I did not include everything I wanted, it works. 
I'm really sorry for not demonstrating better skills this semester.

Assets Used:
HandGun Inventory Display Image: https://www.freepngs.com/handgun-pngs?pgid=izrbzjjx-344b178c-5461-11e8-a9ff-063f49e9a7e4
Key Inventory Display: https://www.freepngimg.com/png/36710-key-clipart
HandGun Display: https://www.pikpng.com/downpngs/TxxxmR_report-abuse-aim-with-gun-clipart/
Rifle Display: https://forum.zdoom.org/viewtopic.php?f=3&t=15080&p=922926
Ammo box: https://assetstore.unity.com/packages/3d/props/weapons/ammo-box-7701
Keys: https://assetstore.unity.com/packages/3d/handpainted-keys-42044
Rifle: https://assetstore.unity.com/packages/3d/props/guns/rifle-25668
Health: https://assetstore.unity.com/packages/3d/props/first-aid-kit-army-148353
Level: https://assetstore.unity.com/packages/3d/environments/snaps-prototype-office-137490

Tutorials Used:
Shooting: https://youtu.be/4H6-obIxnjg
Enemy Following: https://youtu.be/ntDhEmd8kCQ
Part of door interaction: https://youtu.be/nONlAXpCkag

_______________________________________________________________________________________________________________________
# Start_Unity_Github_Project
Use this template to start a Unity3D project using Git and Github. 

The goal of this repository is to make it easy to get started with source control in Unity.  

The article in the link below explains why git is difficult, but not impossible, to use with unity with git and how you can setup your project to be a bit more "git" friendly [How to Git with Unity](https://thoughtbot.com/blog/how-to-git-with-unity)

The following directions assume that you have github desktop [[Download Here]](https://desktop.github.com/) and git-lfs[[Download Here]](https://git-lfs.github.com/) already installed on your computer, as well as having a github account.  I will also assume that if you are familar with git/github and use either the command line or a GUI other that github desktop you should be okay without step by step instructions.

Once you are ready:

1. Click the "Use this template" button on this page. This will create a new repository in your account
2. Give This repository a name related to your game
3. Click "Create repository from template"
4. Click "Clone or Download"
5. Click "Open in Desktop".  This will open the Github Desktop application
6. Select a folder on your system and Click "Clone"
7. Open the new folder with this README.md in your file manager
8. Copy your existing Unity project folder into this folder
9. Go back to Github Desktop and create a commit message, then Click "Commit"
10. Once the commit is complete Click "Push"

If your Library folder is not being ignored open your command line tool in your this folder and run:

`git rm -r --cached Library`

then

`git commit -m "Removed Library Folder from repository"`
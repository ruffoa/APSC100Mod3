# APSC100Mod3

APSC 100 Kinect Based Responsive Display Project – Group 490A

Basic Project Overview

System Requirements:

To run this project, you will require a computer with these minimum specs on it:
•	Core 2 Duo or later
•	Minimum 2GB of ram (4 recommended though)
•	Windows 8.1 or newer (Windows 10 is a free upgrade from 7 onwards, therefore this program was designed for Windows 10, and thus it is recommended)
•	A USB 3.0 port (the blue ones) with nothing else plugged into the neighboring 3.0 ports
•	A projector or display with a minimum resolution of 640x480 (720p is recommended)
•	An open space with at least a meter of room
•	A place to mount the Kinect at around eye level (although there is a fairly big range of heights that should still work fine)

Install Project Files:
Go to https://github.com/ruffoa/APSC100Mod3/releases, which is the link for the project files. Navigate to the newest version and click ‘Download’.  Make sure to download the ‘setup.exe’ file and the ‘Mod3-Project.application’ file. Follow all instructions to download the files on the computer into the same folder.  Click on the setup.exe file and wait for the installer to finish.

Set-up: 

Connect the necessary Kinect cords with the computer, including the power cord, the Kinect power adapter, the Kinect USB adapter and the USB cable. Open the project application that you previously installed in step one (this should be called Mod3-Project unless you renamed it during the install). The computer is now ready to run the project. 

![Main Menu](https://raw.githubusercontent.com/ruffoa/APSC100Mod3/master/img/menu.jpg)

The Main Menu:

This is what the main menu of the application looks like.  Upon successful startup, you should arrive at a screen that looks like this.  At this point, the Kinect should be initialized if plugged in, and it should start detecting users after around a second.  The default content types are an interactive quiz game, a video player, and a page full of information.

The Auto Help Guide:

After a few seconds of having no detected users, the software will automatically launch the help tutorial.  If you are trying to update content (see next section), this may occur and kick you out of the login screen.  Simply try again, as once in the tutorial, the pressing of the HOME key will bypass the automatic redirect and allow you to login.

![CMS](https://raw.githubusercontent.com/ruffoa/APSC100Mod3/master/img/cms.jpg)

Updating the Display Content:
To access the content management system, or CMS, click the home key on your keyboard while within the Mod3-Project program. A username and password pop-up prompt appears, for which the default password is “test”. The content management system then opens, allowing for editing of text, videos, quiz game, and other facets of the project. To update the information, simply click the appropriate buttons.  

Note that the password lock will be disabled for 5 minutes after entering the correct password.  At any point within this time period, one may simply click the HOME key in order to go straight into the CMS system.

![CMS Upload](https://raw.githubusercontent.com/ruffoa/APSC100Mod3/master/img/cms-up.jpg)

File Formats:

This system will accept both PNG and JPEG files for photos, and MP4 and WMV files for videos.  Note that by default however, all photos and videos must retain the same name as they previously did in order for the program to display them.  These names can be easily modified in the source code (see next section) in order to allow for different file formats and names.

Other Useful Tips:

Press the END key at any time to open the help tutorial.  This can be set to a button as well if in the future a physical button is desired in order to open the tutorial.

The video player can also play videos from an online server.  To do this, you will have to modify the source code (available at the link provided under the <code> tab), and change the “source” field of the video to the URL that you have the video hosted on. 

Warning:

While this system has been designed to be able to update content without having to relaunch the program, doing so requires more system resources than if the program was simply restarted every time.  Due to this, after several edits, the program may become buggy, glitchy, or become unresponsive.  To fix this, simply restart the program and or your computer, and the software should be back to normal.


2016 Group 490A


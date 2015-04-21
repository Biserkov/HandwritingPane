# HandwritingPane.exe

A small program to open the Handwriting pane on Windows.


### Background

By default the purple button of the Surface pen launches OneNote.

![](http://biserkov.com/files/SurfacePenOnenote.png)

The button can be customized to run a user-specified .exe by changing the following registry key:

```
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\CN\DesktopAppPath
```

### Purpose

HandwritingPane.exe is intended to be such an .exe and save you a few clicks.


|Default workflow                | with HandwritingPane |
|:-------------------------------|:---------------------|
|Tap/click touch keyboard icon   | Click purple button  | 
|Tap/click input method icon     | Enjoy writing        |
|Tap/click handwriting pane icon |                      |
|Enjoy writing                   |                      |

### Tested and works on

1. Windows 8.1 x64 (Surface Pro 3)
2. Windows 10 Preview build 10049 (Virtual Box)

### References

* Pen button customization method https://www.reddit.com/r/Surface/comments/2j04x1/
* Code for opening the handwriting pane adapted from the excellent http://stackoverflow.com/a/24777212/1068014

### Technical notes

* The code was created using Microsoft Visual Studio Community 2013
* The code was optimized to be as short as possible. Some readability was lost in the process.
* I don't know how to make TabTip.exe re-read the settings from registry so I kill it and start it again. Feedback welcome.

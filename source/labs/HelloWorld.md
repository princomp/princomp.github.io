<!-- UNSURE IF THIS NEEDS A TAG SINCE IT IS JUST INTRO. ADDED SORTME TAG IN COMMENT FOR NOW
---
tags:
- SORTME
---
-->

#  Hello World

This lab serves multiple goals:

- To have you download, open, compile and execute your very first program,
- To understand how to back-up a program,
- To become familiar with your IDE,
- To introduce you to reading error messages given by your compiler.

## Your First Program

In this lab, we will guide you in downloading, opening, compiling, executing and breaking (!) your very first program.
It is customary to start the study of a programming language with a ["Hello World"](https://en.wikipedia.org/wiki/%22Hello,_World!%22_program) program that simply displays "Hello World".
Although such a program has no real interest nor purpose, it is used to make sure that your setup is correctly configured and to guide you gently in the discovery of programs and their language!

### Opening Your First Program

#. Download [HelloWorld_Solution.zip](./code/projects/HelloWorld_Solution.zip) and save it on your computer.
#. [Unzip the program file](./docs/programming_and_computer_usage/unzipping_archives#unzipping-files)^[Be careful: some file explorers will simply _preview_ the (zip) archive if you simply double-click on it, but most IDE will not accept to open a file if it has not been actually extracted / unzipped!].
#. Go in the HelloWorld folder that was created.
#. Double-click on `HelloWorld_Solution.sln` file
#. Clicking the `.sln` file should launch your default C# IDE that [you installed previously](./docs/programming_and_computer_usage/installing_software) or that is pre-loaded on the computer lab you are using.

    - If you get prompted for which application to use, choose the IDE you installed previously.
    - If the IDE does not launch or launches in a different program, right click on the `.sln` file and look for an option to `open with`, then select to open it with the IDE you installed previously.

| ❓ Question       |
|:---------------------------|
| Have you actually checked where the HelloWorld (zip) archive was hosted? Was it on a trustworthy website? If yes, is it trustworthy because of the [domain name](https://en.wikipedia.org/wiki/Domain_name), because we told you to do so, or for some other reasons? |

<details><summary>Elements of solution</summary>
The zip archive we asked you to download is hosted on <https://princomp.github.io/>, that is, on [Github pages](https://pages.github.com/).
There *can be* malware hosted on Github pages, and the fact that this website is secure (it uses http*s*) is in no ways a guarantee of safety.
So, in short, this archive is safe because we told you so, and because we are careful how it is updated. 

Ultimately, many security decisions rest on trust, and you will have to trust us during this course.
If you continue your study in our School, you will learn about [virtualization](https://en.wikipedia.org/wiki/Virtualization), that allows you to execute programs you cannot trust in a safe environment.
</details>

| ❓ Question       |
|:---------------------------|
| How is an IDE different from other types of software? Identify 3 differences between an IDE and a web browser. Can you identify 3 similarities? |

<details><summary>Elements of solution</summary>
This is really up to you! Among the similarities, one can remark that an IDE and pretty much every other software you have ever used both have:

- A graphical user interface (this is not always the case!),
- The capacity of connecting to the internet,
- A manual.
</details>


### Compiling and Executing Your First Program

For this part, everything will take place inside the IDE that was started previously.

#. Within the IDE, first locate `Program.cs`.

    This file will be visible in panel called "Solution Explorer" or "Explorer", depending on the IDE. If you do not see such panel right away, explore the IDE menus to find and open it.

#. After you have located `Program.cs` double click on it. This is the *source code* of the application you are actually considering.

#. Let's compile this program. Look for an option to `Build solution` and click on it. What happened?

#. Let's execute this program. The exact wording varies between different IDEs, but look for one of the following: `Debug > Start without Debugging` or 
   `Run > Start without Debugging` or `Run > Run Project` and click on it. What happened?

#. You will **extensively** compile and execute programs in this class. Instead of having to click twice, it is recommended that you start memorizing shortcuts. You should study your IDE to see the exact shortcuts for your IDE for compiling and running a program. Here are the *usual* shortcuts for different operating systems:

Windows/Linux:

- Build solution: <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>B</kbd>
- Run / Start Debugging: <kbd>Ctrl</kbd> + <kbd>F5</kbd>
- Exit any program: <kbd>Alt</kbd> + <kbd>F4</kbd>

MacOS:

- Build solution: <kbd>Cmd</kbd> + <kbd>B</kbd>
- Run / Start Debugging: <kbd>Cmd</kbd> + <kbd>return</kbd> &nbsp; -or- &nbsp; <kbd>F5</kbd>
- Exit any program: <kbd>Cmd</kbd> + <kbd>q</kbd>

That makes 3 shortcuts already!
You can find many more [on this resource page](./docs/programming_and_computer_usage/keyboard_shortcuts).

### Backups

Now we need to make sure you know how to save your work and access it. This is especially important if you are using the computer lab rooms, as **you can not store files permanently on the lab's computer, and you will have to store them either online in your cloud storage or on a USB drive**.

#### Finding The Right Tool

You can save your project:

- On your hard drive, if you are using your own computer.
- On an external/removable data storage: USB flash drive, external hard disk drive, or any kind of USB mass storage device.
- On a server: the University has a [partnership](https://www.augusta.edu/its/box/) with [box.com](https://box.com/), and you can follow [this tutorial](https://www.augusta.edu/its/box/quickstart.php) to get started, but any service ([Google Drive](https://www.google.com/drive/), [Dropbox](https://www.dropbox.com/), [OneDrive](https://www.microsoft.com/en-us/microsoft-365/onedrive/online-cloud-storage), etc.) would do.

Having _two_ backups is generally recommended.

If you chose the "remote" option (i.e., using a server) and are in a computer lab, **do not** try to install a synchronization program (like [Google Drive and Sync](https://www.google.com/drive/download/), [Box's app](https://app.box.com/app-center?category=63), etc.) on the lab computer; it will likely not work, due to [University rules](https://augusta.policytech.com/dotNet/documents/?docid=5702). Instead, create the structure/project/files on the computer during the lab and upload them (using the web-interface) at the end of the lab.
Make sure to always upload your files before logging out of the computer.

### Making Sure You Have the Right Files

After selecting where you want to store your backup files

#. Create a folder for this class (`CSCI1301`)
#. Create subfolder for the `HelloWorld` lab. Put all of the files related to the "HelloWorld" solution in this folder.
#. Explore your backup. Check that you have multiple folders. Specifically check that your backup contains at least the following files:

    - `HelloWorld_Solution.sln` - this is called a solution file. It tells the IDE how to load your C# source code in the IDE.
    - `HelloWorld_Project.csproj` - this a project file. Every C# solution contains at least 1 project. Dividing code into multiple project is useful for very large programs and allows integrating projects written in different languages under the same solution.
    - `Program.cs` - this is the actual source code of your program and where you write code.

    It is useful to understand the purpose and role of these different files (`.sln`, `.csproj`, `.cs`) when you want to backup or share (i.e. turn in) C# programs.

| ❓ Question       |
|:---------------------------|
| Now that you understand the basic files that go into a C# program, can you identify which files you should always include when you prepare to submit your code for evaluation? Can you develop a strategy with a friend, a classmate, or a second computer, to always make sure that your submission is correctly uploaded and complete? |

### How Was the Backup?

Once you are done, test that you performed the backup properly.

#. Re-download or transfer the files you just saved (the whole `HelloWorld` folder) on the computer -- or even better, share it with a classmate and ask them to complete the following steps with you, or do it _on a different computer_,
#. Make sure you can still open the project in your IDE
#. Do you remember...
    #. How to build the solution
    #. How to start the program without debugging?
    #. Some shortcuts?

If not, go have another look back at the ["Compiling and Executing Your First Program"](#compiling-and-executing-your-first-program) section.

If your backup went wrong (you cannot open the project, it refuses to compile, …), try to understand what happened.
Then re-download the `HelloWorld_Solution.zip`, unzip it, and make sure you can build the solution and execute the program.

Action:
Note that for such a small project, it is easy to re-download it and use it locally. Now imagine the program you are studying is the code of an operating system, spanning across millions of [lines of code](https://en.wikipedia.org/wiki/Source_lines_of_code); such a strategy would not be very efficient, to say the least. Yet mistakes happen, and for that very reason, programmers generally use [version control](https://en.wikipedia.org/wiki/Version_control) which allows them to _undo indefinitely_! Look up [Distributed version control](https://en.wikipedia.org/wiki/Distributed_version_control) and try to understand its importance.

### Orientation

<!-- generic steps you can do in any editor -->

IDEs have many features and require practice. Explore your IDE and try to complete the following tasks:

#. If you currently have a solution open in the IDE, close that solution.
#. Use the IDE file menu to locate and re-open HelloWorld program.
#. Build the program.
#. Try to find `Clean solution`. Cleaning is the action of removing all generated files (e.g. the compiled program).
#. Close `Solution Explorer` or `Explorer` and make sure you can re-open it.
#. Try to change the font size of your editor window.

### Breaking Your Program

If you followed the instructions carefully, you were able to build the solution and start the program without debugging after each step. [As you know, C# has precise rules](./lectures/intro/csharp_fundamentals#rules-of-c-syntax), and not respecting them can prevent your solution from being built by the IDE.

In this exercise, you are asked to do the following:

#. Change the program so that it violates one of the syntax rules of `C#`.
#. Build the solution, and note that an error is reported. The IDE will report a build error similar to the following:

       Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped

    If you do not see an error, look in different tabs. If you still cannot see an error, open build output view from the IDE menu. It is usually labelled as `View > Output`, `View > Tool Windows > Build`, or similar. Then retry building the program to see the error.


#. Make sure you understand the meaning of the error message.
#. Undo your change by pressing

    Windows/Linux:
    ~ 
        <kbd>Ctrl</kbd> + <kbd>z</kbd>

    MacOS:
    ~ 
    
        <kbd>Cmd</kbd> + <kbd>z</kbd>

#. Make sure you can build the solution without a new error message.

#. Break your program three times, in order to identify three different error messages, and three ways of breaking C\#'s rules.

If you have time or need ideas, you can try with the following and see which one(s) make the building impossible (do not forget to undo your change after):

- Remove the semicolon after `using System`
- Replace `class Program` with `class TestOne`
- Remove the brace (or "curly bracket", i.e., the `}` symbol) at the last line.
- Add three new lines at the end of the file
- Replace `Console.WriteLine` with `CONSOLE.WriteLine`
- Replace `Console.WriteLine` with `Console.WRITELINE`
- Add a new line between `Console.` and `WriteLine`
- Add a new line between `WriteLine` and `(`
- Add a new line between `Write` and `Line`
- Replace  `Main()` with `Method()`
- Remove the indentation (i.e., the space between the beginning of the line and the first character of the instruction) on all lines

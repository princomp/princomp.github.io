---
tags:
- IO/file
- datatypes/strings
--- 

# Files

## Questions

#. What is the name of the class we use to read from files?

    - [ ] `FileReader`
    - [ ] `StreamOpener`
    - [ ] `ReadFile`
    - [x] `StreamReader`
    - [ ] `FileStream`

#. What is of crucial importance?

    - [ ] Always call the `Open` method before reading from or writing into a file.
    - [ ] Always assume the user has `C:\` as their main drive.
    - [x] Always call the `Close` method after being done reading from or writing into a file. 
    - [ ] Never read from or write into a file inside a `try…catch` block.

## Problems

#. Write a program that create a text file called `HelloWorld.txt` in its `bin/Debug` folder and store "Hello" followed by a name entered by the user in it.

    <details><summary>Solution</summary>```
    !include`snippetStart="// Variable used to store the user name.",snippetEnd="finally"` code/projects/HelloWorldFile/HelloWorldFile/Program.cs
    ```
    </details>

#. Write a program that ask the user for a filename, makes sure the filename ends with ".txt" and does not begin with a "." (otherwise, the file would be hidden on unix systems), does not match a file with the same name in the `bin/Debug` folder of your program, then create it in the `bin/Debug` folder of your program and write in it all the number from 1 to 1,000,000 (both included). Out of curiosity, what is the file size?

    <details><summary>Solution</summary>```
    !include`snippetStart="// Variable for file name and file path.",snippetEnd="finally"` code/projects/FileCreation/FileCreation/Program.cs
    ```
    
    The resulting file is about 6.6 MB on Unix system, 7.52 MB on Windows system.
    </details>

#. Execute the following program, then write a program that find the greatest number in the `RandomNumber.txt` file.

    ```
    !include`snippetStart="// between 0 and 999.",snippetEnd="// We now search for the highest number stored in this file."` code/projects/FileRandomNumber/FileRandomNumber/Program.cs
    ```
        
    <details><summary>Solution</summary>```
    !include`snippetStart="// We now search for the highest number stored in this file.",snippetEnd="finally"` code/projects/FileRandomNumber/FileRandomNumber/Program.cs
    ```
    </details>

#. Write a program that asks the user to enter a sentence, and store it in a file *where the maximum width is 40*: if the string entered is more than 40 characters long, then it should span over multiple lines of no more than 40 characters each. For example, if the user enters

    ```text
    In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content. Lorem ipsum may be used as a placeholder before the final copy is available.
    ```
    
    then the text file should contain
    
    ```text
    In publishing and graphic design, Lorem 
    ipsum is a placeholder text commonly use
    d to demonstrate the visual form of a do
    cument or a typeface without relying on 
    meaningful content. Lorem ipsum may be u
    sed as a placeholder before the final co
    py is available.
    ```

    <details><summary>Solution</summary>```
    !include`snippetStart="// Begin solution",snippetEnd="// End solution"` code/projects/FileTruncate/FileTruncate/Program.cs
    ```
    </details>

#. Write a program that counts the number of words in itself! Ideally, empty lines should not count toward the word count. 

    Hint: `Program.cs` is normally located at
    
    ```
    Path.Combine(
        new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.ToString(),
        "Program.cs"
    )
    ```

    <details><summary>Solution</summary>```
    !include code/projects/FileCountProgram/FileCountProgram/Program.cs
    ```
    </details>
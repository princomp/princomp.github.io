---
tags:
- IO/file
- datatypes/strings
--- 

# Files (Solutions)

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
    - [ ] Never read from or write into a file inside a `try-catch` block.

## Problems

#. Write a program that create a text file called `HelloWorld.txt` in its `bin/Debug` folder and store "Hello" followed by a name entered by the user in it.

    <details><summary>Solution</summary>
    ```{download="./code/projects/HelloWorldFile.zip"}
    !include`snippetStart="// Variable used to store the user name.",snippetEnd="finally"` code/projects/HelloWorldFile/HelloWorldFile/Program.cs
    ```
    </details>

#. Write a program that ask the user for a filename, makes sure the filename ends with ".txt" and does not begin with a "." (otherwise, the file would be hidden on unix systems), does not match a file with the same name in the `bin/Debug` folder of your program, then create it in the `bin/Debug` folder of your program and write in it all the number from 1 to 1,000,000 (both included). Out of curiosity, what is the file size?

    <details><summary>Solution</summary>
    ```{download="./code/projects/FileCreation.zip"}
    !include`snippetStart="// Variable for file name and file path.",snippetEnd="finally"` code/projects/FileCreation/FileCreation/Program.cs
    ```
    
    The resulting file is about 6.6 MB on Unix system, 7.52 MB on Windows system.
    </details>

#. Execute the following program, then write a program that find the greatest number in the `RandomNumber.txt` file.

    ```
    !include`snippetStart="// between 0 and 999.",snippetEnd="// We now search for the highest number stored in this file."` code/projects/FileRandomNumber/FileRandomNumber/Program.cs
    ```
        
    <details><summary>Solution</summary>
    ```{download="./code/projects/FileRandomNumber.zip"}
    !include`snippetStart="// We now search for the highest number stored in this file.",snippetEnd="finally"` code/projects/FileRandomNumber/FileRandomNumber/Program.cs
    ```
    </details>

#. Suppose that at `filePath` is located a file where each line is either

    - a decimal (e.g., 12.4, -14, 0.34),
    - the word "STOP",
    - some other string ("Test", "The sky is blue", "Ignore this line", "My file contains"), that may contain the characters "STOP".
    
    Write a program that displays the average of the decimals in the file knowing that
    
    - your program should ignore the values after a line containing "STOP" and only "STOP" if it is present,
    - all the other strings should simply be ignored.
    
    For example, for the following three files, "4.0", "10.0" and "7.5" should be displayed, as (12.48 - 2.48 + 2) / 3 = 4 (13 been ignored), (15 + 5) / 2 = 10, and (11 + 4) / 2 = 7.5 (12 being ignored).
    
    ```text
    ┌────────────────┐
    │12.48           │
    │This is a test  │     
    │-2.48           │
    │2               │
    │STOP            │
    │13              │
    └────────────────┘
    
    ┌────────────────┐
    │My file contains│
    │STOP but        │
    │averages        │
    │15              │
    │     and        │
    │5               │ 
    └────────────────┘

    ┌────────────────┐
    │This 12 will be │
    │ignored         │
    │but not         │
    │11              │
    │     nor        │
    │4               │ 
    └────────────────┘
    ```
    
    <details><summary>Solution</summary>
    ```{download="./code/projects/AverageNumberFromFiles.zip"}
    !include`snippetStart="// read, and the average.",snippetEnd="// We return the average."` code/projects/AverageNumberFromFiles/AverageNumberFromFiles/Program.cs
    ```
    </details>


#. Suppose that at `filePath` is located a file containing text. Write a program that, for each line, displays the content of that line if it does not start with a `%` character, and that furthermore displays as a dollar amount the content of that line if it is (only) a `decimal`.

    For example, the following file on the left would be rendered as shown on the right.
    
    ```text
    FILE                    OUTPUT SCREEN
    ┌────────────────┐     ┌────────────────┐
    │Receipt test    │     │Receipt test    │
    │% Ignore me     │     │$12.48          │
    │12.48           │     │$2.00           │
    │2               │     │** Total **     │
    │** Total **     │     │$14.48          │
    │14.48           │     │                │
    │% 00.00         │     │                │
    └────────────────┘     └────────────────┘
    ```

    <details><summary>Solution</summary>
    ```{download="./code/projects/ReceiptDisplayFromFile.zip"}
    !include`snippetStart="// Begining of the actual answer.",snippetEnd="// End of the actual answer."` code/projects/ReceiptDisplayFromFile/ReceiptDisplayFromFile/Program.cs
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

    <details><summary>Solution</summary>
    ```{download="./code/projects/FileTruncate.zip"}
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

    <details><summary>Solution</summary>
    ```{download="./code/projects/FileCountProgram.zip"}
    !include code/projects/FileCountProgram/FileCountProgram/Program.cs
    ```
    </details>

#.  Write a program that

    #. Asks the user to enter a path,
    #. Checks if there is a file at this path:
        #. If there is a file, display its content at the screen.
        #. If there is no file, ask the user to enter text. When the user enters exactly "!DONE!", on a single line, without the quotes, write the text entered before !DONE! into a file located at the given path.

    Your program should be able to handle graciously possible issues (such as an invalid path).

    Below are two examples of execution, taking place one after the other.
    
    
    ### Example execution #1

    ```text
    Enter a path  
    /͟h͟o͟m͟e͟/͟u͟s͟e͟r͟/͟C͟S͟C͟I͟_͟1͟3͟0͟2͟/͟f͟i͟n͟a͟l͟/͟t͟e͟s͟t͟.͟t͟x͟t͟
    Now creating a file at /home/user/CSCI_1302/final/test.txt.  
    Enter your text, one line at a time. When done, type "!DONE!" (without the quotes), then enter.  
    T͟h͟i͟s͟ ͟i͟s͟ ͟a͟ ͟t͟e͟s͟t͟
    s͟p͟a͟n͟n͟i͟n͟g͟ ͟o͟v͟e͟r͟
    t͟h͟r͟e͟e͟ ͟l͟i͟n͟e͟s͟.͟  
    !͟D͟O͟N͟E͟!͟
    File correctly written.
    ```

    ### Example execution #2

    ```text
    Enter a path  
    /͟h͟o͟m͟e͟/͟u͟s͟e͟r͟/͟C͟S͟C͟I͟_͟1͟3͟0͟2͟/͟f͟i͟n͟a͟l͟/͟t͟e͟s͟t͟.͟t͟x͟t͟
    Now displaying file at /home/user/CSCI_1302/final/test.txt.  
    This is a test  
    spanning over  
    three lines.  
    Done displaying file.  
    ```
    
    <details><summary>Solution</summary>
    ```{download="./code/projects/ReadOrWritePath.zip"}
    !include code/projects/ReadOrWritePath/ReadOrWritePath/Program.cs
    ```
    </details>

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
    !include`snippetStart="// Variable used to store the user name.", snippetEnd="finally"` code/projects/HelloWorldFile/HelloWorldFile/Program.cs
    ```
    </details>
